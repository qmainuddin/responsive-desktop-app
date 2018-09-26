using HSDL_IDM_P2.Lib.Entity.AccessControl;
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
    /// Interaction logic for UserRightContent.xaml
    /// </summary>
    public partial class UserRightContent : UserControl
    {
        private object totalUserAccessControlList = null;
        private object selectedUserAccessControlList = null;
        private bool isExpand = false;
        public bool isRole = false;
        public UserRightContent(object _userAC, String typeOfContent, String targetName, object _selectedValueList)
        {
            this.totalUserAccessControlList = _userAC;
            this.selectedUserAccessControlList = _selectedValueList;
            InitializeComponent();
            this.shoulExpand(false);
            if (typeOfContent.ToUpper().Equals(Utils.Defs.PERMISSION_ROLE.ToUpper()))
            {
                this.isRole = true;
            }
            this.prepareContent(typeOfContent, targetName);
        }
        private bool shouldCheckContent(object obj)
        {
            if (this.selectedUserAccessControlList == null) return false;
            if (obj == null) return false;
            if (this.selectedUserAccessControlList is List<GroupDBEntity> && obj is GroupDBEntity)
            {
                List<GroupDBEntity> groupList = this.selectedUserAccessControlList as List<GroupDBEntity>;
                GroupDBEntity grp = obj as GroupDBEntity;
                foreach (GroupDBEntity selectedGrp in groupList)
                {
                    if (grp.Id == selectedGrp.Id)
                    {
                        return true;
                    }
                }
            }
            if (this.selectedUserAccessControlList is List<RoleDBEntity> && obj is RoleDBEntity)
            {
                List<RoleDBEntity> roleList = this.selectedUserAccessControlList as List<RoleDBEntity>;
                RoleDBEntity role = obj as RoleDBEntity;
                foreach (RoleDBEntity selectedRole in roleList)
                {
                    if (role.Id == selectedRole.Id)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        public void makeReadOnly()
        {
            if (this.userAccessControlConent.Children != null)
            {
                foreach (UserACInnerContent uac in this.userAccessControlConent.Children)
                {
                    uac.userAccessControlCheckBox.IsEnabled = false;
                }
            }
        }
        private void prepareContent(String typeOfContent, String targetName)
        {
            this.LblUserAccessControlHeaderName.Text = typeOfContent + " " + targetName;
            if (this.totalUserAccessControlList != null)
            {
                if (this.totalUserAccessControlList is List<GroupDBEntity>)
                {
                    List<GroupDBEntity> groupList = this.totalUserAccessControlList as List<GroupDBEntity>;

                    foreach (GroupDBEntity groupEntity in groupList)
                    {
                        this.userAccessControlConent.Children.Add(new UserACInnerContent(groupEntity.Name, groupEntity.Description,
                            groupEntity, this.shouldCheckContent(groupEntity)));
                    }
                }
                else if (this.totalUserAccessControlList is List<RoleDBEntity>)
                {
                    List<RoleDBEntity> roleList = this.totalUserAccessControlList as List<RoleDBEntity>;

                    foreach (RoleDBEntity roleEntity in roleList)
                    {
                        this.userAccessControlConent.Children.Add(new UserACInnerContent(roleEntity.Name, roleEntity.Description,
                            roleEntity, this.shouldCheckContent(roleEntity)));
                    }
                }
            }
        }
        private void userAccessControlHeader_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (this.Parent != null && this.Parent is StackPanel)
            {
                this.collapseAll(this.Parent as StackPanel);
            }
            this.shoulExpand(true);
        }
        private void collapseAll(StackPanel parentObj)
        {
            try
            {
                foreach (UserRightContent rightContent in parentObj.Children)
                {
                    rightContent.shoulExpand(false);
                }
            }
            catch { }
        }
        public void shoulExpand(bool expandStatus)
        {
            this.isExpand = expandStatus;
            if (expandStatus)
            {
                this.caretImg.Source = new BitmapImage(new Uri(@"/HSDL_IDM_P2;component/Resources/caret_down.gif", UriKind.Relative));
                this.userAccessControlScroller.Visibility = Visibility.Visible;
                this.headerSperator.Visibility = Visibility.Visible;
            }
            else
            {
                this.caretImg.Source = new BitmapImage(new Uri(@"/HSDL_IDM_P2;component/Resources/caret_left.gif", UriKind.Relative));
                this.userAccessControlScroller.Visibility = Visibility.Collapsed;
                this.headerSperator.Visibility = Visibility.Collapsed;
            }
        }
        public object getSelectedContent()
        {
            if (this.userAccessControlConent.Children == null ||
                this.userAccessControlConent.Children.Count <= 0)
            {
                return null;
            }

            if (this.isRole)
            {
                return this.getSelectedRoleList();
            }
            else
            {
                return this.getSelectedGroupList();
            }
        }
        public List<RoleDBEntity> getSelectedRoleList()
        {
            List<RoleDBEntity> selectedRoleList = new List<RoleDBEntity>();

            foreach (UserACInnerContent content in this.userAccessControlConent.Children)
            {
                if (content.isChecked)
                {
                    selectedRoleList.Add(content.content as RoleDBEntity);
                }
            }
            return selectedRoleList;
        }
        public List<GroupDBEntity> getSelectedGroupList()
        {
            List<GroupDBEntity> selectedGroupList = new List<GroupDBEntity>();

            foreach (UserACInnerContent content in this.userAccessControlConent.Children)
            {
                if (content.isChecked)
                {
                    selectedGroupList.Add(content.content as GroupDBEntity);
                }
            }
            return selectedGroupList;
        }
    }
}
