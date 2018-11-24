using HSDL_IDM_P2.Pages.Common;
using HSDL_IDM_P2.Pages.Common.MessageBoxs;
using HSDL_IDM_P2.Pages.UserAdmin;
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
using System.Windows.Shapes;

namespace HSDL_IDM_P2.Pages.Test
{
    /// <summary>
    /// Interaction logic for TestPage.xaml
    /// </summary>
    public partial class TestPage : Window
    {
        private BrushConverter bc = new BrushConverter();
        private bool isHoverOn = false;
        public DashboardForm Dashboard = null;
        public PagingControl paging = null;
        public TestPage()
        {
            InitializeComponent();
            //this.MainBreadCrumb.RootWindow = new MainWindow();
            //this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            //this.bodyContainer.Content = new UserHome(new MainWindow());
            this.bodyContainer.Content = new TestUserHome();
        }

        private void OnClick_UserHome(object sender, RoutedEventArgs e)
        {
            this.ShowErrorMessage();
        }

        private void OnClick_OrganizationHome(object sender, RoutedEventArgs e)
        {
            //this.MainBreadCrumb.setOtherTwoBreadCrumb("User Admin", "Organization");
        }

        private void OnClick_UserBulkOpHome(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Entitlement(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_GroupHome(object sender, RoutedEventArgs e)
        {
            this.bodyContainer.Content = new TestItem();
        }

        private void OnClick_Role(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_Resources(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_ReconciliationHome(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_PasswordHome(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_AuthenticationHome(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_BatchProcessHome(object sender, RoutedEventArgs e)
        {

        }

        private void OnClick_EmailTemplate(object sender, RoutedEventArgs e)
        {
            //this.MainBreadCrumb.setOtherTwoBreadCrumb("Administration", "Email Template");
        }

        private void emailConfig_subMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private void OnClickLocalization(object sender, RoutedEventArgs e)
        {

        }

        private void TxtLogout_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!isHoverOn)
            {
                startHoverOnLogoutBtn();
            }
        }

        private void img_logout_MouseEnter(object sender, MouseEventArgs e)
        {
            if (!isHoverOn)
            {
                startHoverOnLogoutBtn();
            }
        }
        private void TxtLogout_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isHoverOn)
            {
                stopHoverOnLogoutBtn();
            }
        }
        private void img_logout_MouseLeave(object sender, MouseEventArgs e)
        {
            if (isHoverOn)
            {
                stopHoverOnLogoutBtn();
            }
        }
        private void startHoverOnLogoutBtn()
        {
            this.isHoverOn = true;
            //this.img_logout.Height = 20;
            //this.TxtLogout.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void stopHoverOnLogoutBtn()
        {
            this.isHoverOn = false;
            //this.img_logout.Height = 15;
            //this.TxtLogout.Foreground = (Brush)bc.ConvertFrom("#0e526a");
        }
        public void ShowDashboard()
        {
            //this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            MessageBox.Show("This is Dashboard");
        }
        public void ShowErrorMessage()
        {
            //this.PopupContainer.innerContents.Content = new ErrorMessage(this.PopupContainer);
            this.ShowModal();
        }
        public void ShowModal()
        {
            //Utils.Util.addWipeDownAnnimation(this.PopupContainer, (this.ActualHeight + 1000));
            Utils.Util.LoadingPage = this.loadingCanvas;
            this.loadingCanvas.Visibility = Visibility.Visible;
            //this.PopupContainer.SetParent(this.mainBody);
            //this.PopupContainer.ShowHandlerDialog();
        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }

        private void onclick_user_password_changed(object sender, RoutedEventArgs e)
        {

        }
    }
}
