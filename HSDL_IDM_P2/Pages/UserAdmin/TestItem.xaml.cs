using HSDL_IDM_P2.Lib.Entity.UserAdmin;
using HSDL_IDM_P2.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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

namespace HSDL_IDM_P2.Pages.UserAdmin
{
    /// <summary>
    /// Interaction logic for TestItem.xaml
    /// </summary>
    public partial class TestItem : UserControl
    {
        bool isFirstClicked = true;
        bool isCalledFromMethod = false;
        int selectionCount = 0;
        public TestItem()
        {
            InitializeComponent();
            this.PrepareDataGrid();
        }
        public void PrepareDataGrid()
        {
            ObservableCollection<UserEntity> userBeanList = new ObservableCollection<UserEntity>();

            for (int i = 0; i <= 5; i++)
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

            System.Windows.Controls.DataGridTemplateColumn col = this.FindResource("DGTemplateActionColumn") as System.Windows.Controls.DataGridTemplateColumn;
            //DataGridTemplateColumn checkBoxColumn = this.FindResource("DGTemplateCheckboxColumn") as DataGridTemplateColumn;
            this.table_dataGrid.ClearValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty);
            //checkBoxColumn.MaxWidth = 50;
            Type userEntity = typeof(UserEntity);
            int actionColumnIndex = userEntity.GetProperties().Length + 1;
            col.DisplayIndex = actionColumnIndex;
            //this.table_dataGrid.Columns.Add(checkBoxColumn);
            this.table_dataGrid.ItemsSource = userBeanList;
            this.table_dataGrid.Columns.Add(col);
        }

        private void Header_Click(object sender, RoutedEventArgs e)
        {
            CheckBox header = sender as CheckBox;
            int totalItem = this.table_dataGrid.Items.Count;
            isCalledFromMethod = true;
            if (header.IsChecked.Value)
            {
                for (int i = 0; i < totalItem; i++)
                {
                    DataGridCell cell = table_dataGrid.GetCell(i, 0);
                    cell.PreviewMouseDown += Cell_PreviewMouseDown;
                    CheckBox content = cell.Content as CheckBox;
                    content.IsChecked = true;
                    selectionCount++;
                }
            }
            else
            {
                for (int i = 0; i < totalItem; i++)
                {
                    DataGridCell cell = table_dataGrid.GetCell(i, 0);
                    CheckBox content = cell.Content as CheckBox;
                    content.IsChecked = false;
                    selectionCount--;
                }
            }
            isCalledFromMethod = false;
        }

        private void Cell_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {

            if (((sender as DataGridCell).Content as CheckBox).IsChecked.Value)
            {
                ((sender as DataGridCell).Content as CheckBox).IsChecked = false;
                CheckBox_header.IsChecked = false;
                selectionCount--;
            }
            else
            {
                ((sender as DataGridCell).Content as CheckBox).IsChecked = true;
                selectionCount++;
                if (this.table_dataGrid.Items.Count == selectionCount)
                {
                    CheckBox_header.IsChecked = true;
                }

            }
            e.Handled = true;
        }

        private void DGTemplateDelete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void BtnView_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DGTemplateView_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DGTemplateEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnEdit_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_CopyingRowClipboardContent(object sender, DataGridRowClipboardEventArgs e)
        {

        }

        private void dataGridView_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
        {
            object ab = e.Column;
        }

        private void dataGrid_LayoutUpdated(object sender, EventArgs e)
        {
            object ue = table_dataGrid.Columns[0];
        }

        private void DataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            int totalItem = this.table_dataGrid.Items.Count;

            for (int i = 0; i < totalItem; i++)
            {
                DataGridCell cell = table_dataGrid.GetCell(i, 0);
                cell.PreviewMouseDown += Cell_PreviewMouseDown;
            }
        }
    }
}


//public DataGridCell GetCell(int row, int column)
//{
//    DataGridRow rowContainer = GetRow(row);

//    if (rowContainer != null)
//    {
//        DataGridCellsPresenter presenter = GetVisualChild<DataGridCellsPresenter>(rowContainer);

//        DataGridCell cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(column);
//        if (cell == null)
//        {
//            table_dataGrid.ScrollIntoView(rowContainer, table_dataGrid.Columns[column]);
//            cell = (DataGridCell)presenter.ItemContainerGenerator.ContainerFromIndex(column);
//        }
//        return cell;
//    }
//    return null;
//}

//public DataGridRow GetRow(int index)
//{
//    DataGridRow row = (DataGridRow)table_dataGrid.ItemContainerGenerator.ContainerFromIndex(index);
//    if (row == null)
//    {
//        table_dataGrid.UpdateLayout();
//        table_dataGrid.ScrollIntoView(table_dataGrid.Items[index]);
//        row = (DataGridRow)table_dataGrid.ItemContainerGenerator.ContainerFromIndex(index);
//    }
//    return row;
//}

//public static T GetVisualChild<T>(Visual parent) where T : Visual
//{
//    T child = default(T);
//    int numVisuals = VisualTreeHelper.GetChildrenCount(parent);
//    for (int i = 0; i < numVisuals; i++)
//    {
//        Visual v = (Visual)VisualTreeHelper.GetChild(parent, i);
//        child = v as T;
//        if (child == null)
//        {
//            child = GetVisualChild<T>(v);
//        }
//        if (child != null)
//        {
//            break;
//        }
//    }
//    return child;
//}
