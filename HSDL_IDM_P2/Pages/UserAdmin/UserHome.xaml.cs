using HSDL_IDM_P2.Lib.Entity.UserAdmin;
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

namespace HSDL_IDM_P2.Pages.UserAdmin
{
    /// <summary>
    /// Interaction logic for UserHome.xaml
    /// </summary>
    public partial class UserHome : UserControl
    {
        MainWindow MW = null;
        public UserHome(MainWindow mw)
        {
            InitializeComponent();
            this.MW = mw;
            this.PrepareDataGrid();
        }
        public void PrepareDataGrid()
        {
            List<UserEntity> userBeanList = new List<UserEntity>();
            
            for (int i=0; i<=100; i++)
            {
                UserEntity userBean = new UserEntity();
                userBean.ID = i.ToString();
                userBean.UserID = "Sazal";
                userBean.Email = "sazal@tigerit.com";
                userBean.FirstName = "Mainuddin";
                userBean.LastName = "Talukdar";
                userBean.Status = "Active";
                userBean.Telephone = "01621085096";
                userBean.UserType = "TIGERIDM";
                userBeanList.Add(userBean);
            }

            System.Windows.Controls.DataGridTemplateColumn checkBoxColumn = this.FindResource("DGTemplateCheckboxColumn") as System.Windows.Controls.DataGridTemplateColumn;
            System.Windows.Controls.DataGridTemplateColumn col = this.FindResource("DGTemplateActionColumn") as System.Windows.Controls.DataGridTemplateColumn;
            this.table_dataGrid.ClearValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty);
            checkBoxColumn.MaxWidth = 50;
            Type userEntity = typeof(Lib.Entity.UserAdmin.UserEntity);
            int actionColumnIndex = userEntity.GetProperties().Length + 1;
            col.DisplayIndex = actionColumnIndex;
            this.table_dataGrid.Columns.Add(checkBoxColumn);
            this.table_dataGrid.ItemsSource = userBeanList;
            this.table_dataGrid.Columns.Add(col);
        }
        private void showUserModal()
        {
            this.MW.PopupContainer.innerContents.Content = new UserAdmin.Modals.UserModal(this.MW.PopupContainer, this.MW);
            this.MW.ShowModal();
        }
        private void OnClickAdvanceSearch(object sender, RoutedEventArgs e)
        {
            this.AdvanceSearchBox.HandleVisibilityOfAdvanceSearchBox();
        }

        private void BtnEdit_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void DGTemplateEdit_Click(object sender, RoutedEventArgs e)
        {
            this.showUserModal();
        }

        private void DGTemplateView_Click(object sender, RoutedEventArgs e)
        {
            this.MW.ShowErrorMessage();
        }

        private void BtnView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DGTemplateDelete_Click(object sender, RoutedEventArgs e)
        {
            this.MW.ShowErrorMessage();
        }

        private void BtnDelete_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Click(object sender, RoutedEventArgs e)
        {

        }

        private void dataGridView_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {

        }

        private void DataGrid_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {

        }

        private void dataGrid_LayoutUpdated(object sender, EventArgs e)
        {

        }

        private void DataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void OnHover_btn_create(object sender, MouseEventArgs e)
        {

        }

        private void OnLeave_btn_create(object sender, MouseEventArgs e)
        {

        }

        private void OnClick_Create(object sender, RoutedEventArgs e)
        {

        }

        private void OnHover_btn_export(object sender, MouseEventArgs e)
        {

        }

        private void OnLeave_btn_export(object sender, MouseEventArgs e)
        {

        }

        private void OnClick_Export(object sender, RoutedEventArgs e)
        {

        }
    }
}
