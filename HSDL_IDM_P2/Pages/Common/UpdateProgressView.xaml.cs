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

namespace HSDL_IDM_P2.Pages.Common
{
    /// <summary>
    /// Interaction logic for UpdateProgressView.xaml
    /// </summary>
    public partial class UpdateProgressView : Window
    {
        public event EventHandler Cancelled;

        public UpdateProgressView()
        {
            InitializeComponent();

            this.Closed += new EventHandler(UpdateProgressView_Closed);
        }

        private bool closedByApplication = false;

        public void Close()
        {
            closedByApplication = true;
            base.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Cancelled(sender, EventArgs.Empty);
        }

        void UpdateProgressView_Closed(object sender, EventArgs e)
        {
            if (!closedByApplication && Cancelled != null)
                Cancelled(sender, e);
        }
    }
}
