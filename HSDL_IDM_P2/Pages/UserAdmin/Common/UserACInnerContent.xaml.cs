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
    /// Interaction logic for UserACInnerContent.xaml
    /// </summary>
    public partial class UserACInnerContent : UserControl
    {
        public bool isChecked = false;
        public object content = null;
        private bool isExpanded = false;
        public UserACInnerContent(String name, String description, object obj, bool shouldCheck)
        {
            InitializeComponent();
            this.userAccessControlCheckBox.IsChecked = shouldCheck;
            this.content = obj;
            this.LblUserAccessControlNameTxt.Text = name;
            this.LblUserAccessControlNameTxt.ToolTip = name;
            this.LblUserAccessControlNameTxt.TextTrimming = TextTrimming.CharacterEllipsis;
            this.LblUserAccessControlNameTxt.Width = 380;
            this.LblUserAccessControlDescription.Text = description;
            this.LblUserAccessControlDescription.ToolTip = description;
            this.LblUserAccessControlDescription.Width = 380;
            this.LblUserAccessControlDescription.TextTrimming = TextTrimming.CharacterEllipsis;
        }
        private void userAccessControlChecked(object sender, RoutedEventArgs e)
        {
            this.isChecked = true;
        }
        private void userAccessControlUnchecked(object sender, RoutedEventArgs e)
        {
            this.isChecked = false;
        }
        private void BtnExpand_Click(object sender, MouseButtonEventArgs e)
        {
            if (!this.isExpanded)
            {
                this.expandContent();
            }
            else
            {
                this.collapseContent();
            }

        }
        private void expandContent()
        {
            this.isExpanded = true;
            this.ImageExpand.Source = new BitmapImage(new Uri(@"/HSDL_IDM_P2;component/Resources/minus.png", UriKind.Relative));
            this.StackPanelUserAccessControlDescription.Visibility = Visibility.Visible;
        }
        private void collapseContent()
        {
            this.isExpanded = false;
            this.ImageExpand.Source = new BitmapImage(new Uri(@"/HSDL_IDM_P2;component/Resources/plus.png", UriKind.Relative));
            this.StackPanelUserAccessControlDescription.Visibility = Visibility.Collapsed;
        }
    }
}
