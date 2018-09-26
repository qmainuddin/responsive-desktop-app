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
    /// Interaction logic for BreadCrumb.xaml
    /// </summary>
    public partial class BreadCrumb : UserControl
    {
        public MainWindow RootWindow { get; set; }
        private BrushConverter bc = new BrushConverter();
        public BreadCrumb()
        {
            InitializeComponent();
        }
        public void setFirstBreadCrumb(String firstBreadCrumb)
        {
            this.HideOtherBreadCrumb();
            this.LblBreadCrumbFirst.Text = firstBreadCrumb;
            this.LblBreadCrumbFirst.IsEnabled = false;
        }
        public void setAllBreadCrumb(String firstBreadCrumb, String secondBreadCrumb, String thirdBreadCrumb)
        {
            this.ShowOtherBreadCrumb();
            this.LblBreadCrumbFirst.Text = firstBreadCrumb;
            this.LblBreadCrumbSecond.Text = secondBreadCrumb;
            this.LblBreadCrumbThird.Text = thirdBreadCrumb;
            this.LblBreadCrumbFirst.IsEnabled = true;
        }
        public void setOtherTwoBreadCrumb(String secondBreadCrumb, String thirdBreadCrumb)
        {
            setAllBreadCrumb("Dashboard", secondBreadCrumb, thirdBreadCrumb);
        }
        private void HideOtherBreadCrumb()
        {
            this.ArrowFirst.Visibility = Visibility.Collapsed;
            this.ArrowSecond.Visibility = Visibility.Collapsed;
            this.LblBreadCrumbSecond.Visibility = Visibility.Collapsed;
            this.LblBreadCrumbThird.Visibility = Visibility.Collapsed;
        }
        private void ShowOtherBreadCrumb()
        {
            this.ArrowFirst.Visibility = Visibility.Visible;
            this.ArrowSecond.Visibility = Visibility.Visible;
            this.LblBreadCrumbSecond.Visibility = Visibility.Visible;
            this.LblBreadCrumbThird.Visibility = Visibility.Visible;
        }

        private void LblBreadCrumbFirst_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (RootWindow != null)
            {
                this.RootWindow.ShowDashboard();
            }
            else
            {
                Utils.Util.GetExceptionMessageWithStackTrace(new Exception("Mainwindow is not initialized in Breadcrumb.xaml.cs as RootWindow", new Exception("This is an coding error. It may be fixed from the constructor of Mainwindow. Please check this constructor.")));
            }
        }
    }
}
