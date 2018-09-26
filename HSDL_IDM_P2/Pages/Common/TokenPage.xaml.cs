using System;
using System.Collections.Generic;
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
    /// Interaction logic for TokenPage.xaml
    /// </summary>
    public partial class TokenPage : UserControl
    {
        LoginPage loginPage = null;
        public TokenPage(LoginPage login)
        {
            InitializeComponent();
            this.CmbServer.ItemsSource = Utils.Defs.ipAddresses;
            this.CmbServer.SelectedIndex = 1;
            this.TargetCombo.ItemsSource = Utils.Defs.targetListGenerator();
            this.TargetCombo.DisplayMemberPath = "ValueEn";
            this.TargetCombo.SelectedValuePath = "CodeAsString";
            this.TargetCombo.SelectedIndex = 1;
            if (loginPage == null)
            {
                loginPage = login;
            }
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            this.loginPage.RootPage.initialPage_body.ShowPage(loginPage);
        }

        private void Submit_Button_Click(object sender, RoutedEventArgs e)
        {
            this.ShowErrorMessage();
        }
        public void ShowErrorMessage()
        {
            MessageBoxs.ErrorMessage msgBox = new MessageBoxs.ErrorMessage(this.loginPage.RootPage.PopupContainer);
            this.loginPage.RootPage.PopupContainer.innerContents.Content = msgBox;
            this.loginPage.RootPage.ShowModal();
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }

        private void TextBoxUserIdChangeHandler(object sender, TextChangedEventArgs e)
        {

        }

        private void PasswordChangedHandler(object sender, RoutedEventArgs e)
        {

        }
    }
}
