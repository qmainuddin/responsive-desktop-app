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

namespace HSDL_IDM_P2.Pages.Test
{
    /// <summary>
    /// Interaction logic for TestUserHome.xaml
    /// </summary>
    public partial class TestUserHome : UserControl
    {
        public TestUserHome()
        {
            InitializeComponent();
            this.PrepareDataGrid();
        }

        public void PrepareDataGrid()
        {
            List<UserEntity> userBeanList = new List<UserEntity>();

            for (int i = 0; i <= 100; i++)
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
            this.table_dataGrid.ClearValue(System.Windows.Controls.ItemsControl.ItemsSourceProperty);
            Type userEntity = typeof(Lib.Entity.UserAdmin.UserEntity);
            int actionColumnIndex = userEntity.GetProperties().Length;
            col.DisplayIndex = actionColumnIndex;
            this.table_dataGrid.ItemsSource = userBeanList;
            this.table_dataGrid.Columns.Add(col);
        }

        private void newMigrationBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
