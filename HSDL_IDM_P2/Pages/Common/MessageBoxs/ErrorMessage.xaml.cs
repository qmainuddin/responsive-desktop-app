using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace HSDL_IDM_P2.Pages.Common.MessageBoxs
{
    /// <summary>
    /// Interaction logic for ErrorMessage.xaml
    /// </summary>
    public partial class ErrorMessage : UserControl
    {
        public ModalContainer RootPage = null;
        public ErrorMessage(ModalContainer _RootPage)
        {
            InitializeComponent();
            if(RootPage == null)
            {
                RootPage = _RootPage;
            }
            //this.LblMessageContent.Text = "quicksoftwaretesting.com\nsample-wsdl-urls-testing-soapui\ngoogle.com.bdsourceid\nsample-wsdl-urls-testing-soapui\ngoogle.com.bdsourceid\nsample-wsdl-urls-testing-soapui\ngoogle.com.bdsourceid";
        }
        private void OnClick_btn_Cancel(object sender, RoutedEventArgs e)
        {
            this.RootPage.CloseModal();
        }

        private void OnClick_btn_OK(object sender, RoutedEventArgs e)
        {
            this.RootPage.CloseModal();
        }
    }
}
