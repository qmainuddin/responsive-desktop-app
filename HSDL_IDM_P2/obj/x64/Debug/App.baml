   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=null)clr-namespace:HSDL_IDM_P2HSDL_IDM_P2  5      ?$clr-namespace:HSDL_IDM_P2.PropertiesHSDL_IDM_P2.Properties  5          HSDL_IDM_P2.App   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      +localclr-namespace:HSDL_IDM_P2     5      9resource$clr-namespace:HSDL_IDM_P2.Properties     5        �� 	Resources  5       �� 
TargetType   manuBaseStyle �� Property �� Value �� BasedOn  ScrollThumbs �� 
TargetType �Name ��Name �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName � RowDefinitions ]�Name ]� Thumb n�Name ]� IncreaseRepeatButton ��Name J� Opacity ]� DecreaseRepeatButton P� 
SourceName  ButtonSelectBrush  	DarkBrush �� Angle  comboBoxStyle  textBoxStyle  placeHolder ��Name K� ZIndex �� Path �� RelativeSource �� Mode �� UpdateSourceTrigger
 � Tag �� Triggers �� Binding  �� Source%  System.Windows.Markup.Reference! �� Value  close_img_hover" �� CreateOptions# �� CacheOption$ �� 	UriSource  close_img_nonHover 	 duplicate_img_nonHover 
 duplicate_img_hover  create_img_hover  create_img_nonHover  save_img_nonHover  save_img_hover  export_img_hover  export_img_nonHover  clear_img_nonHover  clear_img_hover  search_img_hover  search_img_nonHover  cancel_img_nonHover  cancel_img_hover  edit_img_nonHover  delete_img_nonHover  delete_img_hover  sendEmail_img_hover  sendEmail_img_nonHover  resetPassword_img_nonHover  resetPassword_img_hover  btn_map_nonHover_img  btn_map_Hover_img*  $System.Windows.Controls.DataGridCell   TableDataCellStyle=  7System.Windows.Controls.Primitives.DataGridColumnHeader% � ColumnDefinitions& F�Name' �� Stretch( J� RenderTransformOrigin)  #System.Windows.Controls.DataGridRow) �� 	Resources* �� Color��%Z%  &	        'o� �     7   &	 
    '�� N    &	 �	    '�� D
    7  &	 f
    '�� �
    7  &	 �
    7��&	 e    &	 �    &		 .    &	
 �    &	 �    &	 c    &	 �    &	 3    &	 �    &	     &	 k    &	 �    &	 4    &	 �    &	 �    &	 j    &	 �    &	 4    &	 �    &	      &	 k    &	 �    &	 4    &	 �    &	     '  k    &	  c    '  f    '  '!    �� 5
   
   " ��6   .�5      ��  � ��$ Tahoma)�6+   �� 5       � ��$ 16(�6)   �� 5       � �� �#0000336+   �� 5       � ��$ Normal$�6*   �� 5       � ��
 �����6+   5      �� 5   
   " o�6   8   6V   �� 5   
   " n�6%   .�5      ��  � �� 5      �� 5      " n�6&   .R�5      � $
 Grid��6   .+�5      �� $��Stretch=�6(   $��Stretch=�6F   $
��Auto��6b   $
��Auto��6o   
������ 6}   �� 5      $ 
Rectangle1��6%   $ 10��69   $��Stretch=�6K   $��Stretch=�6i   $
��Auto��6�   $
��Auto��6�   #��z��6�   5      	 5      P� 5      
 �@�Tag$ 
Horizontal��65   . �5   "   �� $ 
Rectangle1��6)    � ��$
 Auto��6R   �� 5   "   $ 
Rectangle1��6)    � ��$ 7��6S   5       5"      5$      5%      �� 5(   
   " ��6+   .�5)      ��  �@��IsFlicksEnabled .  67   �� 5*       � �� �#c2c3c96+   �� 5+       � ��
 �����6+   �� 5,       � ��$ 10��6&   �� 5-       � �� 5.      �� 5/      " ��6&   .R�50      � $ GridRoot��6   $��10��61   #��z��6<    51      �� 52   "   $��0.00001* �60   .+�55      ]� $ 
PART_Track��6$   $��0��68   ��. |�.   56   "   n� 57   &   $ Thumb��6,   #��z��6;   #���  6e    59   "   �� 5:   &   $ PageUp��63   $��ScrollBar.PageDownCommand��6C   $ 0Q�6g   |�.  6s    5<   "   �� 5=   &   $ PageDown��63   $��ScrollBar.PageUpCommand��6E   $ 0Q�6g   |�.  6s   5?      5@      	 5B      P� 5C      $ Thumb��6&   
 �@J�IsMouseOver . . �5D   "   �� # �  6)   $ Thumb��6U    � ��6h   5E      P� 5F      $ Thumb��6&   
 �@n�
IsDragging . . �5G   "   �� # �  6)   $ Thumb��6M    � ��6`   5H      P� 5J      
 � {� .  . �5K   "   �� $ Thumb��6)    � y�$ 	Collapsed=�6R   5L      P� 5M      
 �@��Orientation$ 
Horizontal=�6=   . �5N   "   �� $ GridRoot��6)    �@�LayoutTransform 5O   &   �� 5P   *   $	 -90Q�6:   5R   #   �� 5S   "   $ 
PART_Track��6)    �@�LayoutTransform 5T   &   �� 5U   *   $	 -90Q�6:   5W   #   �� 5X   "    � ��$
 Auto��6:   �� 5Y   "    � ��$ 12��6;   �� 5Z   "   $ Thumb��6)    �@�Tag$ 
Horizontal��6K   �� 5[   "   $ PageDown��6)    � ��$ ScrollBar.PageLeftCommand��6R   �� 5\   "   $ PageUp��6)    � ��$  ScrollBar.PageRightCommand��6P   5]      5_      5a      5b      �� 5d   
   " ��6   .�5e      ��  � �� �#f2f2f26=   5f      �� 5g   
   " ��6   8   6Z   �� 5i   
   " ��6%   .�5j      ��  � �� �#a0a0a06,   �� 5k       � ��$ 1q�60   5l      �� 5n   
   " ��6   8   6.   �� 5p   
   " ��6$   8   .�5q      ��  � �� 5r      �� 5s      " ��6&   .R�5t      � .+�5u      �� $ 
textSource��5y   "   
������ $ 2��5{   "   ��5u   &   �� $
 Text� �� *TemplatedParent+$ TwoWay=�$ PropertyChanged=�5{   "   �� 5|      #��z 6&   #��z��6C   $ 1��6m   .��6~   ��5}   "   �� 5~   &   " ��6,   .�5   *   ��  � ��
 ���� 6G    5�   *   �� 5�   .    6:   �� $
 Text�    *
textSource+!  6y   .a�5�   2   ��  � ��
 �����6O   5�   /   5�   '   .��5�   1   5�      5�      5�      5�      5�      �� 5�   
   $" IgnoreImageCache=�6.   $# OnLoad=�5�      $!$ Resources/b_close_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�61   $# OnLoad=�5�      $$ /Resources/b_close.png?�6+   �� 5�   
   $" IgnoreImageCache=�65   $# OnLoad=�5�      $$ Resources/b_duplicate.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $%$ Resources/b_duplicate_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�6/   $# OnLoad=�5�      $$ Resources/b_new_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $ $ Resources/b_create_new.png?�6+   �� 5�   
   $" IgnoreImageCache=�60   $# OnLoad=�5�      $$$ /Resources/b_save_nonHover.png?�6+   �� 5�   
   $" IgnoreImageCache=�6-   $# OnLoad=�5�      $ $ Resources/b_save_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�6/   $# OnLoad=�5�      $&$  Resources/b_export_ico_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $ $ Resources/b_export_ico.png?�6+   �� 5�   
   $" IgnoreImageCache=�61   $# OnLoad=�5�      $$ /Resources/b_reset.png?�6+   �� 5�   
   $" IgnoreImageCache=�6.   $# OnLoad=�5�      $!$ Resources/b_reset_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�6/   $# OnLoad=�5�      $$ Resources/b_search.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $"$ Resources/b_search_leave.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $&$  /Resources/b_cancel_nonHover.png?�6+   �� 5�   
   $" IgnoreImageCache=�6/   $# OnLoad=�5�      $"$ Resources/b_cancel_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�60   $# OnLoad=�5�      $$ Resources/ico_edit.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $$ Resources/ico_delete.png?�6+   �� 5�   
   $" IgnoreImageCache=�6/   $# OnLoad=�5�      $"$ Resources/ico_delete_dis.png?�6+   �� 5�   
   $" IgnoreImageCache=�62   $# OnLoad=�5�      $%$ Resources/b_sendemail_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�65   $# OnLoad=�5�      $$ Resources/b_sendemail.png?�6+   �� 5�   
   $" IgnoreImageCache=�69   $# OnLoad=�5�      $$ Resources/b_resetpwd.png?�6+   �� 5�   
   $" IgnoreImageCache=�66   $# OnLoad=�5�      $$$ Resources/b_resetpwd_hover.png?�6+   �� 5�   
   $" IgnoreImageCache=�63   $# OnLoad=�5�      $"$ Resources/b_map_nonHover.png?�6+   �� 5�   
   $" IgnoreImageCache=�60   $# OnLoad=�5�      $$ Resources/b_map_Hover.png?�6+   �� 5�   
   "  6   .�5�      ��  � ��$ 0,0,0,0q�6'   69   �� 5�       �@��TextAlignment$ Center=�68   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      �� $��Center=�6+   5�      5�      5�      �� 5�   
   "  6+   .�5�      ��  � ��$ Arial)�6+   6;   �� 5�       � ��$
 12pt(�6)   68   �� 5�       � �� �#3d3d296=   �� 5�       � ��$ Center=�6;   6L   �� 5�       � �� 6+   Z� �� 5�       � �� 6,   Z� �� 5�       � ��$
 auto��6'   �� 5�       � �� 5�      �� 5�      .R�5�      �� 
������ $
��Wrap=�6=   $��CharacterEllipsis=�6Q   $
��auto��6r   $
��auto��6�   ��6�   �� *Text+5�      5�      5�      �� 5�   
   "  6   .�5�      ��  �@J�SnapsToDevicePixels . 64   �� 5�       � ��$ 0��6)   �� 5�       � ��$ 0��6*   �� 5�       � �� �#275e726+   �� 5�       � �� �#99d6ff6+   �� 5�       �@�Cursor$
 Hand��6'   �� 5�       � ��$ 30��6'   �� 5�       � �� �#cbcbb46,   �� 5�       � ��$ 0q�60   �� 5�       � �� 5�      �� 5�      "  6&   .R�5�      � % 5�      �� 5�   "   $��* �63   �� 5   "   $
��Auto �63   .+�5     �� $ BackgroundBorder��6%   $��0,0,0,0q�6?   ���#99d6ff���#99d6ff$��2��6�   �� 5     $��6,3,6,3q�6/   $��Center=�6@   $��Center=�6[   F� 5     $& 	SortArrow��6#   $y�	Collapsed=�66   "����        �@B     � � @B 	$
' Fill=�6h   $��1��6w   $��8��6�   $��6��6�   
���   �$��0,0,8,0q�6�   $��Center=�6�   $( 0.5, 0.4&�6�   �� 5     $��1��6(   ���#EEEEEE$��Right=�6A   $��2��6]   �� 5     $��1��6(   $��0,0,1,0q�62   ���#DDDDDD$��Right=�6R   $��2��6n   5     	 5
     P� 5     
 �@J�IsMouseOver . . �5  "   �� $ BackgroundBorder��6)    � �� �#32a3cf6]   �� 5  "   $ BackgroundBorder��6)    � �� �#32a3cf6^   �� 5  "    � ��
 �����6?   5     P� 5     
 �@ SortDirection$ 	AscendingX�6?   . �5  "   �� $ 	SortArrow��6)    � y�$ Visible=�6V   �� 5  "   $ 	SortArrow��6)    � z� 5  &   �� 5  *   $	 180Q�6:   5  #   5     P� 5     
 �@ SortDirection$ 
DescendingX�6?   . �5  "   �� $ 	SortArrow��6)    � y�$ Visible=�6V   5     5     5!     5#     �� 5$  
   "  6    5&     P� 5'     
 �@��AlternationIndex$ 0��6C   . �5(     ��  � �� �#f2f2f26E   �� 5)      � �� �#6666B   5*     P� 5+     
 �@��AlternationIndex$ 1��6C   . �5,     ��  � ��
 ���� 6I   �� 5-      � �� �#6666B   5.     P� 50     
 �@J�IsMouseOver . . �51     ��  � �� �#e6fff963   �� 52      � �� �#6666B   53     ) 56     ���� 57     $* Transparent��6T   (��       6"   * SystemColors.HighlightBrushKey+)6T   �� 58     $* #b30059��6X   (��       6"   *$"SystemColors.HighlightTextBrushKey+)6X   59     5;     5=     5>     