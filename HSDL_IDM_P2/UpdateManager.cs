using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HSDL_IDM_P2
{
    public class VersionInfo
    {
        public Version Version;
        public Uri DownloadUri;
        public string SetupFileName;
        public string relativePath;
        public string fileSize;
    }

    public interface IVersionChecker
    {
        void GetVersionInfoAsync(Uri versionInfoUri);
        event Action<VersionInfo> GetVersionInfoCompleted;
    }

    public interface IUpdateManager
    {
        event Action<VersionInfo, bool> CheckForUpdateCompleted;
        void CheckForUpdateAsync(Uri versionInfoUri, Version currentVersion);
        string DownloadMsiAsync(Uri msiLocation, string versionedFileName); // returns local MSI file path

        void CancelDownloadMsi();

        event DownloadProgressChangedEventHandler DownloadProgressChanged;
        event AsyncCompletedEventHandler DownloadFileCompleted;
    }

    public class UpdateManager : IUpdateManager
    {
        public event Action<VersionInfo, bool> CheckForUpdateCompleted;

        public void CheckForUpdateAsync(Uri versionInfoUri, Version currentVersion)
        {
            IVersionChecker versionChecker = new VersionChecker();
            versionChecker.GetVersionInfoCompleted +=
              (versionInfo) =>
              {
                  bool isNewVersionDetected = false;
                  if (versionInfo != null)
                  {
                      isNewVersionDetected = currentVersion.CompareTo(versionInfo.Version) < 0;
                  }
                  if (this.CheckForUpdateCompleted != null)
                      CheckForUpdateCompleted(versionInfo, isNewVersionDetected);
              };
            versionChecker.GetVersionInfoAsync(versionInfoUri);
        }

        private WebClient wcDownloadingMsi;
        public string DownloadMsiAsync(Uri msiLocation, string versionedFileName)
        {
            if (wcDownloadingMsi != null)
                return null;

            string fullName = System.IO.Path.GetTempPath() + "\\" + versionedFileName;

            // Delete previous copies of the MSI package if any.
            if (File.Exists(fullName))
            {
                File.Delete(fullName);
            }

            //try
            //{
            wcDownloadingMsi = new WebClient();

            wcDownloadingMsi.DownloadProgressChanged +=
              (sender, e) =>
              {
                  if (this.DownloadProgressChanged != null)
                      DownloadProgressChanged(sender, e);
              };

            wcDownloadingMsi.DownloadFileCompleted +=
              (sender, e) =>
              {
                  if (!e.Cancelled)
                      File.Move(fullName + ".tmp", fullName);

                  if (this.DownloadFileCompleted != null)
                      DownloadFileCompleted(sender, e);

                  wcDownloadingMsi = null;
              };

            wcDownloadingMsi.DownloadFileAsync(msiLocation, fullName + ".tmp", fullName);
            //}
            //catch (WebException)
            //{
            //    return null;
            //}

            return fullName;
        }

        public void CancelDownloadMsi()
        {
            if (wcDownloadingMsi != null && wcDownloadingMsi.IsBusy)
                wcDownloadingMsi.CancelAsync();
        }

        public event DownloadProgressChangedEventHandler DownloadProgressChanged;

        public event AsyncCompletedEventHandler DownloadFileCompleted;
    }

    public class VersionChecker : IVersionChecker
    {
        public event Action<VersionInfo> GetVersionInfoCompleted;

        public void GetVersionInfoAsync(Uri versionInfoUri)
        {
            WebClient wc = new WebClient();

            wc.OpenReadCompleted +=
            (sender, e) =>
            {
                VersionInfo versionInfo = null;

                if (e.Error == null)
                {
                    using (Stream s = e.Result)
                    {
                        using (StreamReader reader = new StreamReader(s))
                        {
                            versionInfo = new VersionInfo();
                            string line = string.Empty;
                            while (!string.IsNullOrEmpty(line = reader.ReadLine()))
                            {
                                string[] tokens = line.Split(':');
                                switch (tokens[0])
                                {
                                    case "PROGRAM_VERSION":
                                        versionInfo.Version = new Version(tokens[1]);
                                        break;
                                    case "SETUP_FILENAME":
                                        versionInfo.SetupFileName = tokens[1];
                                        break;
                                    case "FTP_BASE_PATH":
                                        versionInfo.relativePath = tokens[1];
                                        break;
                                    case "FILE_SIZE":
                                        versionInfo.fileSize = tokens[1];
                                        break;
                                    default:
                                        break;
                                }
                            }
                        }
                    }
                }
                else
                {
                    App.logger.Error(Utils.Util.GetExceptionMessageWithStackTrace(e.Error));
                    MessageBox.Show(e.Error.Message);
                }

                if (this.GetVersionInfoCompleted != null)
                    GetVersionInfoCompleted(versionInfo);
            };
            wc.OpenReadAsync(versionInfoUri);
        }
    }
}
