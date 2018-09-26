using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Mail;
using HSDL_IDM_P2.Pages.Common;
using HSDL_IDM_P2.Pages.UserAdmin;
using HSDL_IDM_P2.Pages.UserAdmin.Common;
using HSDL_IDM_P2.Pages.Common.MessageBoxs;

namespace HSDL_IDM_P2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private BrushConverter bc = new BrushConverter();
        private bool isHoverOn = false;
        public DashboardForm Dashboard = null;
        public PagingControl paging = null;
        public MainWindow()
        {
            InitializeComponent();
            this.MainBreadCrumb.RootWindow = this;
            this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            Dashboard = new DashboardForm();
            this.bodyContainer.Content = Dashboard;

            paging = new PagingControl();
            //this.bodyContainer.Content = paging;

            this.bodyContainer.Content = new UserHome(this);
            //this.bodyContainer.Content = new AdvanceSearchBox();
        }
        
        private void OnClick_UserHome(object sender, RoutedEventArgs e)
        {
            this.ShowErrorMessage();
        }

        private void OnClick_OrganizationHome(object sender, RoutedEventArgs e)
        {
            this.MainBreadCrumb.setOtherTwoBreadCrumb("User Admin", "Organization");
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
            this.MainBreadCrumb.setOtherTwoBreadCrumb("Administration", "Email Template");
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
            this.img_logout.Height = 20;
            this.TxtLogout.Foreground = new SolidColorBrush(Colors.Red);
        }
        private void stopHoverOnLogoutBtn()
        {
            this.isHoverOn = false;
            this.img_logout.Height = 15;
            this.TxtLogout.Foreground = (Brush)bc.ConvertFrom("#0e526a");
        }
        public void ShowDashboard()
        {
            this.MainBreadCrumb.setFirstBreadCrumb("Dashboard");
            MessageBox.Show("This is Dashboard");
        }
        public void ShowErrorMessage()
        {
            this.PopupContainer.innerContents.Content = new ErrorMessage(this.PopupContainer);
            this.ShowModal();
        }
        public void ShowModal()
        {
            Utils.Util.addWipeDownAnnimation(this.PopupContainer, (this.ActualHeight + 1000));
            Utils.Util.LoadingPage = this.loadingCanvas;
            this.loadingCanvas.Visibility = Visibility.Visible;
            this.PopupContainer.SetParent(this.mainBody);
            this.PopupContainer.ShowHandlerDialog();
        }
    }
}
