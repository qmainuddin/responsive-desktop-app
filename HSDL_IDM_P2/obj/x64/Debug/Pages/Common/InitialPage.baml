   M S B A M L   `   `   `  ����M  IHSDL_IDM_P2, Version=1.0.6900.31216, Culture=neutral, PublicKeyToken=nullC&clr-namespace:HSDL_IDM_P2.Pages.CommonHSDL_IDM_P2.Pages.Common  5   	   M IWpfPageTransitions, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitionsWpfPageTransitions 5   	   [2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs$HSDL_IDM_P2.Pages.Common.MessageBoxs  5	   	   C&clr-namespace:HSDL_IDM_P2.Pages.CommonHSDL_IDM_P2.Pages.Common  5
   	   *    $HSDL_IDM_P2.Pages.Common.InitialPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   8local&clr-namespace:HSDL_IDM_P2.Pages.Common     5   	   2gif"http://wpfanimatedgif.codeplex.com     5   	   XpageTransitions<clr-namespace:WpfPageTransitions;assembly=WpfPageTransitions     5   	   Gcontrols2clr-namespace:HSDL_IDM_P2.Pages.Common.MessageBoxs     5	   	   AcommonControls&clr-namespace:HSDL_IDM_P2.Pages.Common     5
   	     � Title$  IDM - Login��5      $	��341��6.   $	��535��6;    � 
ResizeMode$ NoResize=�6G    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5      ��%    5      .��5      � -   5        $��	container��5      .+�5   
   � -   5        $��initialPage_header��5      $	��Top=�6)   $
��Left=�6B   ���#99d6ff$��86��6r   $	��544��6~   $��0,0,0,0q�6�   .+�5      � $
��Left=�6   ���#32a3cf$��41��6C   $��0,23,0,0q�6O   $	��Top=�6a   $	��534��6y    � ColumnDefinitions 5      �� 5      $
��184* �6'   �� 5      $
��355* �6'   .+�5      �� $ ��/Resources/brta_logo_2.png��6   $��UniformToFill=�6<    J� Opacity$ 1Q�6T   $��15,-23,83,-20q�6`    J� RenderTransformOrigin$ 	6.23,0.58&�6w   �� 5      -   5         ��Name$ LblApplicationName��5      $)��#Bangladesh Road Transport Authority��64   
�������$��20(�6u   
������ $
��Left=�6�   $��	124,0,0,0q�6�   $	��Top=�6�   $��2��6�   $	��358��6�   5      5      '  !WpfPageTransitions.PageTransition  5   
   -   5        $��initialPage_body��5   )   $	��183��6A   $��Center=�6N      TransitionType$
 None=�6i   $��
0,103,0,27q�6   � 5   
   -   5        $��initialPage_Footer��5      $��Bottom=�6)   .+�5      �� $��Right=�6   $��Version��64   5      � 5   
   -   5        $��loadingCanvas��5      $ .7Q�5      $y�Hidden=�6   	 K� ZIndex$	 1��60   
�������
 � Cursor$

 Wait��5   &   .+�5       �� -   5        $��
waitingTxt��5       $ ��Processing your request...��6*   $��Arial)�6L   $��16(�6_   
���   �$
��Bold"�5!   +   $��Center=�5"      $��Center=�65   5#      -   'HSDL_IDM_P2.Pages.Common.ModalContainer  5$   
   -   5          Name$ PopupContainer��5$   <   $y�Hidden=�6(   6<   5%      5&      