using HSDL_IDM_P2.Pages.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;
using System.Threading;
using System.Windows.Input;
using log4net;
using HSDL_IDM_P2.Utils;
using log4net.Config;
using HSDL_IDM_P2.Pages;

namespace HSDL_IDM_P2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ILog logger = LogManager.GetLogger(typeof(Application));
        private string newMsiFilePath = "";
        private StartupEventArgs appStart = null;
        private bool userRefusedToAccept = false;
        private bool hasError = false;
        
        protected override void OnExit(ExitEventArgs e)
        {
            //Environment.Exit(0);
            Application.Current.Shutdown();
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            appStart = e;
            XmlConfigurator.Configure();
            logger.Info("Application Started");

            this.ShutdownMode = ShutdownMode.OnLastWindowClose;
            userRefusedToAccept = false;
            hasError = false;
            newMsiFilePath = "";
            //UpdateProcess(this.UpdateFinishedHandler);
            RunApplication();
            //base.OnStartup(e);
        }
        private void UpdateFinishedHandler()
        {
            // Update process cancelled either by user or by network failure etc. In that case, application will not start
            if (userRefusedToAccept)
            {
                Shutdown();
                return;
            }
            StartApplication();
        }

        private void RunApplication()
        {
            // invoke login page
            base.OnStartup(appStart);
            new InitialPage().Show();
            //new Test().Show();
            //new MainWindow().Show();
        }
        //private void StartApplicationTest()
        //{
        //    MessageBox.Show("No Comment");
        //}
        private void StartApplication()
        {
            try
            {
                string myPath = Path.GetFullPath(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, @"..\"), "version.txt"));
                File.WriteAllText(myPath, "PROGRAM_VERSION:" + Assembly.GetExecutingAssembly().GetName().Version.ToString());
                if (!hasError)
                {
                    string newPath = Path.GetFullPath(Path.Combine(Path.Combine(System.Reflection.Assembly.GetExecutingAssembly().Location, @"..\"), "version.txt"));
                    if (File.Exists(newPath))
                    {
                        File.WriteAllText(newPath, "PROGRAM_VERSION:" + Assembly.GetExecutingAssembly().GetName().Version.ToString());
                    }

                    if (userRefusedToAccept)
                    {
                        Shutdown();
                        return;
                    }
                    else if (!string.IsNullOrEmpty(newMsiFilePath))
                    {
                        // Restart.
                        //Process thisprocess = Process.GetCurrentProcess();
                        //Process.Start(newMsiFilePath);
                        //thisprocess.CloseMainWindow();
                        //thisprocess.Close();
                        //thisprocess.Dispose();

                        Process p = new Process();
                        p.StartInfo.FileName = "msiexec";
                        p.StartInfo.Arguments = "/i " + newMsiFilePath;
                        p.Start();
                        p.WaitForExit();
                        Process thisprocess = Process.GetCurrentProcess();
                        thisprocess.CloseMainWindow();
                        thisprocess.Close();
                        thisprocess.Dispose();
                    }
                    else // application up-to-date
                    {
                        RunApplication();
                    }
                }
                else
                {
                    RunApplication();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                MessageBox.Show(
                   "Unable to start application. Please check your network connection or contact your System Administrator.",
                   "HSDL - TigerIDM",
                   MessageBoxButton.OK,
                   MessageBoxImage.Error);
                logger.Error(Util.GetExceptionMessageWithStackTrace(ex));
            }
            // Close the window, otherwise application will not exit after closing main window
            if (winCheckForUpdate != null)
                winCheckForUpdate.Close();
        }

        #region Check for Update

        static Window winCheckForUpdate = null;

        private string GetVersonUrlBase()
        {
            byte[] bytesToBeDecrypted = Convert.FromBase64String(ConfigurationManager.AppSettings["versionUrl"]);
            byte[] passwordBytes = Encoding.UTF8.GetBytes("");
            passwordBytes = SHA256.Create().ComputeHash(passwordBytes);

            byte[] bytesDecrypted = AES_Decrypt(bytesToBeDecrypted, passwordBytes);

            string result = Encoding.UTF8.GetString(bytesDecrypted);

            return result;
        }

        public static byte[] AES_Decrypt(byte[] bytesToBeDecrypted, byte[] passwordBytes)
        {
            byte[] decryptedBytes = null;

            // Set your salt here, change it to meet your flavor:
            // The salt bytes must be at least 8 bytes.
            byte[] saltBytes = new byte[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            using (MemoryStream ms = new MemoryStream())
            {
                using (RijndaelManaged AES = new RijndaelManaged())
                {
                    AES.KeySize = 256;
                    AES.BlockSize = 128;

                    var key = new Rfc2898DeriveBytes(passwordBytes, saltBytes, 1000);
                    AES.Key = key.GetBytes(AES.KeySize / 8);
                    AES.IV = key.GetBytes(AES.BlockSize / 8);

                    AES.Mode = CipherMode.CBC;

                    using (var cs = new CryptoStream(ms, AES.CreateDecryptor(), CryptoStreamMode.Write))
                    {
                        cs.Write(bytesToBeDecrypted, 0, bytesToBeDecrypted.Length);
                        cs.Close();
                    }
                    decryptedBytes = ms.ToArray();
                }
            }

            return decryptedBytes;
        }

        private void UpdateProcess(Action postUpdateAction)
        {

            IUpdateManager updater = new UpdateManager();

            try
            {
                VersionInfo versionInfo = null;
                bool isNewVersion = false;

                /* Check for update */
                winCheckForUpdate = new Window
                {
                    Title = "HSDL TigerIDM",
                    Height = 70,
                    Width = 300,
                    ResizeMode = ResizeMode.NoResize,
                    WindowStartupLocation = WindowStartupLocation.CenterScreen,
                };
                Grid grid = new Grid();
                TextBlock tb = new TextBlock
                {
                    Margin = new Thickness(10, 0, 10, 0),
                    Text = "Checking for update...",
                    VerticalAlignment = VerticalAlignment.Center
                };
                grid.Children.Add(tb);
                winCheckForUpdate.Content = grid;
                winCheckForUpdate.Show();

                updater.CheckForUpdateCompleted +=
                    (versionInfoRet, isNewVersionDetected) =>
                    {
                        versionInfo = versionInfoRet;
                        isNewVersion = isNewVersionDetected;

                        Dispatcher.Invoke((Action)(
                          () =>
                          {
                              if (winCheckForUpdate.IsVisible)
                                  winCheckForUpdate.Hide(); // do not close this window here, closing this window will exit the application, it should not be closed until the main window shows up

                              CheckForUpdateCompleted(postUpdateAction, updater, versionInfoRet, isNewVersionDetected);
                          }
                        ));
                    };

                updater.CheckForUpdateAsync(
                      new Uri(GetVersonUrlBase() + "/" + ConfigurationManager.AppSettings["versionFileName"].ToString()), Assembly.GetExecutingAssembly().GetName().Version);

            }
            catch (Exception ex)
            {
                hasError = true;
                logger.Error(Util.GetExceptionMessageWithStackTrace(ex));
                MessageBox.Show(
                    "There was an error verifying your version of HSDL-TigerIDM. Please check your network connection or contact your System Administrator.",
                    "HSDL TigerIDM",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                StartApplication();
                return; // shutdown current application if error occurred while checking for update
            }
        }

        private string GetFormattedFtpPath(string relativePath, string fileName)
        {
            return GetVersonUrlBase() + "/" + fileName;


        }

        private void CheckForUpdateCompleted(Action postUpdateAction, IUpdateManager updater, VersionInfo versionInfo, bool isNewVersion)
        {
            try
            {
                if (versionInfo == null)
                {
                    MessageBox.Show(
                        "There was an error verifying your version of HSDL-TigerIDM. Please check your network connection or contact your System Administrator.",
                        "HSDL-TigerIDM",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
                    logger.Error("Version Information is missing in server.");
                    hasError = true;
                    postUpdateAction();
                    return;
                }

                if (isNewVersion) // New version detected
                {
                    MessageBoxResult confirmDownload = MessageBox.Show(
                        "A new version of HSDL-TigerIDM is available for download. The process may take a few minutes. Do you want to download it now?",
                        "HSDL-TigerIDM",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Information,
                        MessageBoxResult.Yes);

                    if (confirmDownload == MessageBoxResult.No) // user cannot run the application without installing available UPDATE
                    {
                        logger.Error("User refused to download new version.");
                        userRefusedToAccept = true;
                        postUpdateAction();
                        return;
                    }
                }
                else // Installation is up-to-date
                {
                    logger.Info("Current version is up-to-date.");
                    userRefusedToAccept = false;
                    hasError = false;
                    postUpdateAction();
                    return;
                }

                /* Download update (if there is any) */
                //logger.Info("UpdateProgressView starting.");
                UpdateProgressView dlProgressWindow = new UpdateProgressView();
                dlProgressWindow.Show();
                dlProgressWindow.Cancelled +=
                    (sender, e) =>
                    {
                        updater.CancelDownloadMsi();
                    };
                //logger.Info("UpdateProgressView closed.");
                Action<AsyncCompletedEventArgs> postDownloadAction = (e) =>
                {
                    string localMsiFilePath = (string)e.UserState;
                    newMsiFilePath = localMsiFilePath;
                    if (e.Cancelled)
                    {
                        //MessageBox.Show(
                        //    "Download cancelled.",
                        //    ""HSDL Admin Portal",
                        //    MessageBoxButton.OK,
                        //    MessageBoxImage.Error);
                    }
                    else if (e.Error != null)
                    {
                        logger.Error(Util.GetExceptionMessageWithStackTrace(e.Error));
                        MessageBox.Show(
                            "There was an error downloading the latest version of HSDL-TigerIDM. Please check your network connection or contact your System Administrator.",
                            "HSDL-TigerIDM",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error);
                    }

                    // Download cancelled by user or error occurred while downloading update
                    if (e.Error != null)
                    {
                        hasError = true;
                        postUpdateAction();
                        return;
                    }

                    MessageBoxResult confirmInstall = MessageBox.Show(
                        "\nThe new version of HSDL-TigerIDM has been successfully downloaded. Do you want to install it now?",
                        "HSDL-TigerIDM",
                        MessageBoxButton.YesNo,
                        MessageBoxImage.Information,
                        MessageBoxResult.Yes);
                    if (confirmInstall == MessageBoxResult.No)
                    {
                        logger.Error("User refused to install new version after downloaded.");
                        userRefusedToAccept = true;
                        postUpdateAction();
                        return;
                    }

                    if (postUpdateAction != null)
                        postUpdateAction();
                };

                updater.DownloadProgressChanged +=
                    (sender, e) =>
                    {
                        Dispatcher.Invoke((Action)(
                          () =>
                          {
                              string bytes = GetHumanReadbleByte(e.BytesReceived);
                              dlProgressWindow.txtMessage.Text = "Downloading update... " + bytes + " of " + versionInfo.fileSize;
                              dlProgressWindow.progressBar.Value = e.ProgressPercentage;
                          }
                        ));
                    };
                updater.DownloadFileCompleted +=
                    (sender, e) =>
                    {
                        Dispatcher.Invoke((Action)(
                          () =>
                          {
                              dlProgressWindow.txtMessage.Text = "Downloading complete.";
                              dlProgressWindow.Close();
                              postDownloadAction(e);
                          }
                        ));
                    };

                //string localMsiFilePath = null;
                ThreadPool.QueueUserWorkItem(
                    new WaitCallback(obj => { updater.DownloadMsiAsync(new Uri(GetFormattedFtpPath(versionInfo.relativePath, versionInfo.SetupFileName)), versionInfo.SetupFileName); })
                    );
            }
            catch (Exception ex)
            {
                hasError = true;
                logger.Error(Util.GetExceptionMessageWithStackTrace(ex));
                MessageBox.Show(
                    "There was an error verifying your version of HSDL-TigerIDM. Please check your network connection or contact your System Administrator.",
                    "HSDL-TigerIDM",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                StartApplication();
                return;
            }
        }

        public string GetHumanReadbleByte(double size)
        {
            string[] sizes = { "B", "KB", "MB", "GB" };
            double len = size;

            int order = 0;
            while (len >= 1024 && order + 1 < sizes.Length)
            {
                order++;
                len = len / 1024;
            }

            string result = String.Format("{0:0.##} {1}", len, sizes[order]);
            return result;
        }

        private void Handle_Click(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
    }
}
#endregion
