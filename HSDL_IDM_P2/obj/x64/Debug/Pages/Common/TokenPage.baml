   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HSDL_IDM_P2.Pages.CommonHSDL_IDM_P2.Pages.Common  5      [2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs$HSDL_IDM_P2.Pages.Common.MessageBoxs  5      (    "HSDL_IDM_P2.Pages.Common.TokenPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:HSDL_IDM_P2.Pages.Common     5      Gcontrols2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs     5      $��0,30,0,0q�5	   7   .��5
      � .+�5   
   ]� -   5        $��Login��5      .+�5      � $	��Top=�6     � ColumnDefinitions  5      �� 5       $��* �6'   �� 5!      $��* �6'   .+�5#      �� $��0��6    �� Orientation$ 
Horizontal=�6-   .+�5$      �� -   5        $��LblContainer��5$   !   $ Vertical=�65   .+�5%      �� -   5         ��Name$ LblUser��5%   1   $��5,0,5,5q�6    $��	User ID :��6B   $��Right=�6V   $	��Top=�6r   �� 5&      -   5        $ LblServerHost��5&   M   $��5,0,5,5q�6    $��Right=�61   $��Server :��6d   $	��Top=�6w   5'      �� 5(      $ Vertical=�6!   $��0,5,0,0q�68   $	��202��6I   .+�5)      �� -   5         ��Name$ 	TxtUserId��5)   Z   
�������$��1q�65   $��5,0,5,5q�6I   $��25��6m    �� 	MaxLength$ 45��6|   $
��Left=�6�   $	��Top=�6�   $	��160��6�   6�   �� 5*      -   5         ��Name$ 	CmbServer��5*   [   
�������$��1q�66   $��5,0,5,5q�6J   $
��Left=�6n   $	��160��6�    �� 
IsEditable . 6�   5+      5,      �� 5-      $��1��6   $ 
Horizontal=�6-   .+�5.      �� -   5        $��LblContainerRight��5.   !   $ Vertical=�6:   .+�5/      �� -   5        $ LblTargetClient��5/       $��Target Client :��69   $��Right=�6S   $	��Top=�6o   �� 50      -	   5        $ LblToken��50   +   $��5q�6    $��Token :��6=   $��Right=�6O   $	��Top=�6l   51      �� 52      $ Vertical=�6!   $��0,5,0,0q�68   $	��198��6I   .+�53      �� -
   5        $ TargetCombo��53   �   
�������$	��160��66   $
��Left=�6B   $��1q�6]   $��5,0,5,5q�6q   6�   �� 54      -   5        $ TxtToken��54   �   
�������$��1q�65   $��5q�6I   $	��160��6T   $
��Left=�6`    �� TextWrapping$
 Wrap=�6{   $��85��6�   $��Center=�6�   6�   55      56      57      �� 58      -   5        $��ButtonContainer��58      $��Center=�60   $��Center=�6K   $��Bottom=�6h   $ 
Horizontal=�6�   $��50��6�   .+�5=      �� -   5         ��Name$ BtnBack��5=      $��Center=�6*   $��70��6E   .��5>      �� $ 
Horizontal=�6!   .+�5@      �� 	 �� TextAlignment$	 Center=�6$   $
��Back��6;   $	��Top=�6G   $��50��6_   5A      5B      �� 5C      -   5        $ BtnLogin��5C      $��Center=�6+   $��
15, 0, 0,0q�6F   $��70��6Z   .��5D      �� $ 
Horizontal=�6!   .+�5F      �� $�� Submit��6$   $	��Top=�63   $��50��6K   5G      5H      5I      5J      5K      5L      