   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=null[2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs$HSDL_IDM_P2.Pages.Common.MessageBoxs  5      7    1HSDL_IDM_P2.Pages.Common.MessageBoxs.ErrorMessage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Dlocal2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs     5      -   5          >�Name$
  root��5       � 	Resources 5	         btn_ConfirmBoxOK �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius ��Name	 �� Orientation
 ��Name �� Triggers P� Property P� Value �� 
TargetName  btn_ConfirmBoxCancel��%|  &	        &	 �    �� 5
   
   " ��6)   .�5      ��  � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��1q�5      $	 4,2q�5      ���#b6b6b6$ 3��5      ���#e6e6e6._�5      �� $ ConfirmBoxOK_stackPanel��6)   $��Center=�5   )   $	 
Horizontal=�6F   .+�5   "   �� $
 ConfirmBoxOK_lbl��6,   $��Ok��6F   $��Right=�5   ,   $��Center=�6H   $��Tahoma)�5   ,   ��5   P   Z� 5   ,   5      5       5      P� 5       �@J�IsMouseOver . . �5   "   �� $ border��6)    � �� �#559bb46S   �� 5   "   $ ConfirmBoxOK_lbl��6)    � ��
 �����6]   5      5!      5#      5$      �� 5&   
   " ��6-   .�5'      ��  � �� 5(      �� 5)      " ��6&   .R�5*      �� $��border��6!   $��1q�5+      $	 4,2q�5,      ���#b6b6b6$ 3��5.      ���#e6e6e6._�50      �� $! ConfirmBoxCancel_stackPanel��6)   $��Center=�51   )   $	 
Horizontal=�6F   .+�52   "   �� $
 ConfirmBoxCancel_lbl��6,   $��Cancel��6J   $��Right=�53   ,   $��Center=�6H   $��Tahoma)�54   ,   ��52   X   Z� 54   ,   55      56       57      P� 58       �@J�IsMouseOver . . �59   "   �� $ border��6)    � �� �#559bb46S   �� 5:   "   $ ConfirmBoxCancel_lbl��6)    � ��
 �����6a   5;      5=      5?      5@      5B      .��5C      �  � RowDefinitions 5D   
   �� 5E      $	��26* �6   �� 5F      $	��31* �6   �� 5G      $	��32* �6   .+�5I   
   �� $��0��6   $��Stretch=�6   $��26��6<   ���	#FFCCCCCC$ 	10,10,0,0��5J   4    � DataContext 5K      ��  �� ElementName$ RoundBorder��._�5L      �� -   5         ��Name$ LblHeaderText��5L   L   $��Center=�6   $��Center=�61   $��Center=�5M       $��14(�6D   $
��Bold"�6R   $��Center=�5N       $��Error!��6B   
���  �����	#FFCCCCCC5O   1   5P      �� 5Q   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   .��5R      �� -   5        $
 LblMessageContent��5R      $$��Error Content should put here.��63   $��Center=�5S      $��Tahoma)�6-   $��12(�6A    �� TextAlignment$ Center=�5T      ���	#FF333333$	��Top=�6>   5U      �� 5V   
   -   5         ��Name$ btn_confirmBoxFirst��5V      $��Center=�6.   #���   5W      $��2��5X      $��Center=�6   $��39��69   $��18��6D   $��224,14,81,12q�6P   5Y      �� 5Z   
   -   5        $ btn_confirmBoxSecond��5Z      $
��Left=�6/   #���  5[      $��
275,14,0,0q�5\      $��2��6%   $	��Top=�62   $��50��6J   $��18��6U   6a   5]      5^      