using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace HSDL_IDM_P2.Pages.Common
{
    /// <summary>
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : UserControl
    {
        public InitialPage RootPage = null;
        //System.Threading.Thread updateThread = null;
        //BackgroundWorker uiThreadWorker = null;
        public LoginPage(InitialPage rootPage)
        {
            InitializeComponent();

            CmbServer.ItemsSource = Utils.Defs.ipAddresses;
            CmbServer.SelectedIndex = 1;
            if (this.RootPage == null)
            {
                this.RootPage = rootPage;
                //Utils.Util.RootPage = rootPage;
            }

            //uiThreadWorker = new BackgroundWorker();
            //uiThreadWorker.DoWork += UiThreadWorker_DoWork;
            //uiThreadWorker.RunWorkerCompleted += UiThreadWorker_RunWorkerCompleted;
        }

        private void TextBoxUserIdChangeHandler(object sender, TextChangedEventArgs e)
        {

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }

        private void PasswordChangedHandler(object sender, RoutedEventArgs e)
        {

        }

        private void NewUser_Button_Click(object sender, RoutedEventArgs e)
        {
            this.RootPage.initialPage_body.TransitionType = WpfPageTransitions.PageTransitionType.SlideAndFade;
            this.RootPage.initialPage_body.ShowPage(new SignupPage(this));
        }

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {
            //this.RootPage.login_loadingCanvas.Visibility = Visibility.Visible;
            //if (!uiThreadWorker.IsBusy)
            //{
            //    uiThreadWorker.RunWorkerAsync();
            //}
            //DoSomething();
            //new MainWindow().Show();
            new Test.TestPage().Show();
            this.RootPage.Close();
        }

        //private void UiThreadWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    AfterThreadEffects();
        //}

        //private void UiThreadWorker_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    DoSomething();
        //}

        //public void DoSomething()
        //{
        //    this.Dispatcher.Invoke(() => {
        //        selectAllElement();
        //    });
        //}
        //public void selectAllElement()
        //{
        //    for (long i = 0; i <= 999999; i++)
        //    {
        //        this.UpdateContent.Text = i.ToString();
        //    }
        //}
        //public void AfterThreadEffects()
        //{
        //    this.RootPage.login_loadingCanvas.Visibility = Visibility.Hidden;
        //}
        private void Forgot_Button_Click(object sender, RoutedEventArgs e)
        {
            this.RootPage.initialPage_body.TransitionType = WpfPageTransitions.PageTransitionType.SlideAndFade;
            this.RootPage.initialPage_body.ShowPage(new TokenPage(this));
        }
    }
}
