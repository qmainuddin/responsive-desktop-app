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
    /// Interaction logic for SignupPage.xaml
    /// </summary>
    public partial class SignupPage : UserControl
    {
        LoginPage loginPage = null;
        public SignupPage(LoginPage login)
        {
            InitializeComponent();
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

        }

        private void PasswordChangedHandler(object sender, RoutedEventArgs e)
        {

        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {

        }

        private void TextBoxUserIdChangeHandler(object sender, TextChangedEventArgs e)
        {

        }
    }
}
