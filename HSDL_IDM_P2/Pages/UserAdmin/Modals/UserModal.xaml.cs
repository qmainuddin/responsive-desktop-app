using HSDL_IDM_P2.Controllers.Lookup;
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

namespace HSDL_IDM_P2.Pages.UserAdmin.Modals
{
    /// <summary>
    /// Interaction logic for UserModal.xaml
    /// </summary>
    public partial class UserModal : UserControl
    {
        public Pages.Common.ModalContainer Container = null;
        MainWindow MW = null;
        public UserModal()
        {
            InitializeComponent();
        }
        public UserModal(Pages.Common.ModalContainer _Container, MainWindow mw)
        {
            InitializeComponent();
            if(Container == null)
            {
                Container = _Container;
            }
            if(MW == null)
            {
                MW = mw;
            }
            //prepareLookUp();
        }
        private void footerBtnSecond_Click(object sender, RoutedEventArgs e)
        {
            this.Container.CloseModal();
        }
        public void prepareLookUp()
        {
            LookupController.getInstance().canvas = this.MW.loadingCanvas;
            LookupController.getInstance().GenerateLookup();
            organizationComboBox.ItemsSource = LookupController.getInstance().districtList;
            organizationComboBox.DisplayMemberPath = "ValueEn";
            organizationComboBox.SelectedValuePath = "CodeAsInt";
        }

        private void OnLeave_footerBtnSecond(object sender, MouseEventArgs e)
        {

        }

        private void OnHover_footerBtnSecond(object sender, MouseEventArgs e)
        {

        }

        private void footerBtnFirst_Click(object sender, RoutedEventArgs e)
        {
            this.Container.CloseModal();
        }

        private void OnLeave_footerBtnFirst(object sender, MouseEventArgs e)
        {

        }

        private void OnHover_footerBtnFirst(object sender, MouseEventArgs e)
        {

        }

        private void validityDatePicker_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void departmentComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void divisionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void divisionComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void departmentComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void confirmEmailTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void emailTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void genderComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void genderComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dateOfBirthDatePicker_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void voterNoTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void voterNoTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void mobileTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void mobileTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void designationTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void organizationComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void organizationComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void lastNameTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void firstNameTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void targetComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void targetComboBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void userIdTextBox_PreviewKeyDown(object sender, KeyEventArgs e)
        {

        }

        private void OnClose_btn_modal(object sender, MouseButtonEventArgs e)
        {
            this.Container.CloseModal();
        }
        
    }
}
