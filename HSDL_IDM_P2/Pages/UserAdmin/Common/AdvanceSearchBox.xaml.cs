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

namespace HSDL_IDM_P2.Pages.UserAdmin.Common
{
    /// <summary>
    /// Interaction logic for AdvanceSearchBox.xaml
    /// </summary>
    public partial class AdvanceSearchBox : UserControl
    {
        public static readonly DependencyProperty ParentControlProperty = DependencyProperty.Register(
            "ParentControl", typeof(UserHome), typeof(AdvanceSearchBox), new PropertyMetadata(null));
        public UserHome ParentControl
        {
            get
            {
                return (UserHome)GetValue(ParentControlProperty);
            }
            set
            {
                SetValue(ParentControlProperty, value);
            }
        }
        public bool isOpened = false;

        private BrushConverter bc = new BrushConverter();
        public AdvanceSearchBox()
        {
            InitializeComponent();
        }
        
        private void OnHover_btn_close(object sender, MouseEventArgs e)
        {
            this.close_image.Source = new BitmapImage(new Uri(@"/Resources/b_close_hover.png", UriKind.Relative));
            this.close_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_close_lbl.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OnLeave_btn_close(object sender, MouseEventArgs e)
        {
            this.close_image.Source = new BitmapImage(new Uri(@"/Resources/b_close.png", UriKind.Relative));
            this.close_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_close_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnHover_btn_search(object sender, MouseEventArgs e)
        {
            this.search_image.Source = new BitmapImage(new Uri(@"/Resources/b_search.png", UriKind.Relative));
            this.search_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_search_lbl.Foreground = new SolidColorBrush(Colors.White);
        }

        private void OnLeave_btn_search(object sender, MouseEventArgs e)
        {
            this.search_image.Source = new BitmapImage(new Uri(@"/Resources/b_search_leave.png", UriKind.Relative));
            this.search_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_search_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnHover_btn_clear(object sender, MouseEventArgs e)
        {
            this.reset_image.Source = new BitmapImage(new Uri(@"/Resources/b_reset_hover.png", UriKind.Relative));
            this.reset_btn.Background = (Brush)bc.ConvertFrom("#FF32a3cf");
            this.user_reset_lbl.Foreground = new SolidColorBrush(Colors.White);
        }
        private void OnLeave_btn_clear(object sender, MouseEventArgs e)
        {
            this.reset_image.Source = new BitmapImage(new Uri(@"/Resources/b_reset.png", UriKind.Relative));
            this.reset_btn.Background = (Brush)bc.ConvertFrom("#FFF1ECEC");
            this.user_reset_lbl.Foreground = new SolidColorBrush(Colors.Black);
        }

        private void OnClick_btn_Close(object sender, RoutedEventArgs e)
        {
            try
            {
                this.HandleVisibilityOfAdvanceSearchBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void reset_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void search_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        
        private void telephone_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void email_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void status_ComBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lastName_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void middleName_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void firstName_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void targetComBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void userID_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void Id_textBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }
        public void HandleVisibilityOfAdvanceSearchBox()
        {
            if (!isOpened)
            {
                this.Visibility = Visibility.Visible;
                isOpened = true;
            }
            else
            {
                this.Visibility = Visibility.Hidden;
                isOpened = false;
            }
        }
    }
}
