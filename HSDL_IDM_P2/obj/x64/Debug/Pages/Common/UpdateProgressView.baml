   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HSDL_IDM_P2.Pages.CommonHSDL_IDM_P2.Pages.Common  5   	   1    +HSDL_IDM_P2.Pages.Common.UpdateProgressView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HSDL_IDM_P2.Pages.Common     5   	     � Title$  IDM - Login��5      $	��150��6.   $	��450��6;    � WindowStartupLocation$ CenterScreen=�5   	    � 
ResizeMode$ NoResize=�6.   .��5	      �  � RowDefinitions 5
   
   �� 5      $��30 �6   �� 5      $��50 �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$ 
txtMessage��5      $��Downloading update...��6(   $��Center=�6E   $
��10,0q�6`   � 5   
   -   5         �Name$ progressBar��5       � IsIndeterminate . $��Center=�6B    � Minimum$ 0Q�6]    � Maximum$	 100Q�6i   $��1��5      $
��10,0q�6#   $��30��61   �� 5   
   -   5        	 ��Name$	 	btnCancel��5      $��2��6$   $��Cancel��61   $��Center=�6B   $��Right=�6]   $��0,0,10,2q�5      $
��10,0q�6#   $��23��62   6>   5      5      