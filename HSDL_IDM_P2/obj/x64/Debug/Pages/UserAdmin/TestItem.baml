   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=nullI)clr-namespace:HSDL_IDM_P2.Pages.UserAdminHSDL_IDM_P2.Pages.UserAdmin  5      *    $HSDL_IDM_P2.Pages.UserAdmin.TestItem   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ;local)clr-namespace:HSDL_IDM_P2.Pages.UserAdmin     5      -   5        $	��850��5      $
��1300��6     � 	Resources  5	         BasicSmallButton �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� Triggers P� Property P� Value	 �� 
TargetName  BasicButton
 �� CornerRadius4  .System.Windows.Controls.DataGridTemplateColumn  DGTemplateActionColumn   CellTemplate �� Orientation � ToolTip �� Triggers ��Name J� OpacityMask��%�	  &	        &	 �    &	 �    �� 5
   
   " ��6)   .�5      ��  �@�OverridesDefaultStyle .  66   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��0,1,0,1q�5      $	 4,2q�5      ���#a0a0a0#��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $	 border��6)    � �� �#a0a0a06T   5      5      5      5      �� 5   
   " ��6$   .�5       ��  �@�OverridesDefaultStyle . 66   �� 5!       � ��$ 5q�6'   �� 5"       � �� 5#      �� 5$      " ��6&   .R�5%      �� $��border��6!   $��1q�5&      $	 4,2q�5'      
�������$
 3��5)      #��z��5*      ._�5+      �� $��Center=�6/   $��Center=�6L   5,       5-      P� 5.       �@J�IsMouseOver . . �5/   "   �� $	 border��6)    � ��
 �   �6T   50      52      54      55        56   
    57      �� 58      .R�59      �� $ 
Horizontal=�6!   $��Center=�6:   $��Center=�6W   $	��0,2q�6r   .+�5:      �� $��	BtnUpdate��6!   -   5        $��25��5:   2   $��25��6=   $��2,0,0,0q�6I   $ Update��5;   !   
������ 
������ ��5=      �� 5>   "   " ��6(    5?   &   P� 5@   *    � {� .  . �5A   .   ��  �@J�Opacity$ .5Q�6H   5B   +   P� 5C   *    � {� . . �5D   .   ��  �@J�Opacity$ 1Q�6H   5E   +   5G   #   .��5I      �� $ 
view_image��6$   $��/Resources/ico_edit.png��5J   $   # � ��5K   $   $��UniformToFill=�5L   $   5M      �� 5N      $��BtnView��6!   -   5        $��25��5N   0   $��25��6;   $��2,0,0,0q�6G   
������ 
������ $
 View��5P   !   .��5Q      �� $ 
edit_image��6$   $��/Resources/ico_view.png��5R   $   # � ��5S   $   $��UniformToFill=�5T   $   5U      �� 5V      $��	BtnDelete��6!   -   5        $��25��5V   2   $��25��6=   $��2,0,0,0q�6I   
������ 
������ $ Delete��5X   !   ��5Y      �� 5Z   "   " ��6(    5[   &   P� 5\   *    � {� .  . �5]   .   ��  �@J�Opacity$ .5Q�6H   5^   +   P� 5_   *    � {� . . �5`   .   ��  �@J�Opacity$ 1Q�6H   5a   +   5c   #   .��5e      �� $ delete_image��6$   $��/Resources/ico_delete.png��5f   $   # � ��5g   $   $��UniformToFill=�5h   $   5i      5k      5l      5n      5w      .��5x      � .+�5y   
   &   System.Windows.Controls.DataGrid  -   5          Name$ table_dataGrid��5y       �� AlternationCount$ 2��5z         HeadersVisibility$ Column=�6-   
������ $��0q�5{         CanUserAddRows .     
IsReadOnly .    ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6T      EnableRowVirtualization .  $
��Left=�5}   Y   ��5~      ��  �� Path$ ActualHeight� �� ElementName$ DataGridContainer����5      �� $ ActualWidth�$ DataGridContainer��   Columns 5�      4  .System.Windows.Controls.DataGridCheckBoxColumn  5�      ,  &System.Windows.Controls.DataGridColumn   Header 5�      �� 5�      -   5        $��CheckBox_header��5�   @   $��Center=�6#   6W      	CellStyle 5�      �� 5�      5�      5�      5�      5�      5�      