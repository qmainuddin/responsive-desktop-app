   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HSDL_IDM_P2.Pages.CommonHSDL_IDM_P2.Pages.Common  5      (    "HSDL_IDM_P2.Pages.Common.LoginPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HSDL_IDM_P2.Pages.Common     5      .��5	      ]� -   5        $��Login��5	      .+�5
   
   � $	��Top=�6   $��Center=�6$     � ColumnDefinitions  5      �� 5      $��* �6#   �� 5      $��* �6#   .+�5      �� -   5        $��LblContainer��5      $��0��6-    �� Orientation$ Vertical=�6=   .+�5      �� -   5         ��Name$ LblUser��5   #   $��5q�6   $��	User ID :��64   $��Right=�6H   $	��Top=�6d   �� 5      -   5        $ LblPassword��5   #   $��5q�6   $��
Password :��68   $��Right=�6M   $	��Top=�6j   �� 5      -   5        $ LblServerHost��5   ?   $��5q�6   $��Right=�6#   $��Server :��6V   $	��Top=�6i   5      �� 5      $��1��6   $ Vertical=�6)   $��10,5,0,0q�6@   .+�5      �� -   5         ��Name$ 	TxtUserId��5   L   
�������$��1q�6-   $��5q�6A   $
��Left=�6_   $��23��6z    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��141��6�    �� 	MaxLength$ 45��6  G� 5      -   5         G�Name$ PasswordLoginPassword��5   P   
�������$��1q�61   $��5q�6E   $
��Left=�6o   $��23��6�   $��Center=�6�   $	��141��6�    G� 	MaxLength$ 18��6  �� 5      -   5         ��Name$ 	CmbServer��5   M   
�������$��1q�6.   $��5q�6B   	 �� 
IsEditable	 . 6r   5      5      �� 5   
   $��Bottom=�6   $��Center=�60   $��Bottom=�6M   $ 
Horizontal=�6e   $��50��6~   .+�5      �� -	   5        
 ��Name$
 BtnForgorPassword��5   0   $��Center=�6   .��5       �� $ 
Horizontal=�6   .+�5!      �� $��Forgot Password ?��6    $	��Top=�69   5"      5#      �� 5$      -
   5        $
 BtnLogin��5$   ;   $��Center=�6   $��70��60   $��15,0,0,0q�6h   .��5%      �� $ 
Horizontal=�6   .+�5&      �� -   5         ��Name$ close_image��5&      $
��Left=�61   $	��Top=�6L   $��/Resources/b_login.png��6d   $��18��6�   $��18��6�    J� OpacityMask# � ��6�   $��UniformToFill=�6�   �� 5'      $�� Login��6    $	��Top=�6.   5(      5)      �� 5*      -   5        $
 
BtnNewUser��5*   ;   $��Center=�6   $��70��60   $��15,0,0,0q�6l   .��5+      �� $ 
Horizontal=�6   .+�5,      �� $��
New User ?��6    5-      5.      �� 5/      -   5        $��UpdateContent��5/      $y�Hidden=�6-   50      51      52      