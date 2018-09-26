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

namespace HSDL_IDM_P2.Pages
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }
        void OnChecked(object sender, RoutedEventArgs e)
        {
            object a = sender;
        }

        private void header_Click(object sender, RoutedEventArgs e)
        {
            CheckBox head = sender as CheckBox;
            if (head.IsChecked.Value)
            {
                head.IsChecked = false;
            }
            else
            {
                head.IsChecked = true;
            }
        }
    }
}
