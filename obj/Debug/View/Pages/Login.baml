   M S B A M L   `   `   `  ����G  CTradeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:TradeProject.View.PagesTradeProject.View.Pages  5      W0clr-namespace:TradeProject.ViewModel.PageControl"TradeProject.ViewModel.PageControl  5      #    TradeProject.View.Pages.Login   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:TradeProject.View.Pages     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      9pc0clr-namespace:TradeProject.ViewModel.PageControl  5        N� Title$  Login��5       � DataContext 5      9   3TradeProject.ViewModel.PageControl.LoginPageControl  5   
   .��5      (� .��5   
   � y�6   �� *LoginPageVisibility+.+�5      �  � ColumnDefinitions 5      �� 5      $	��15* �6'   �� 5      $	��17* �6'   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6*    �� EndPoint$ 0.9,1&�6=   .��5      �  � Color$ 	#ffe63070��6'    � Offset$ 1Q�69   � 5      $ 	#fffe8704��6'   $ 0Q�69   5      .+�5      �� $	��390��6   $	��Top=�6&    �� CornerRadius$ 	0 0 190 0��6>   ���#100e17$��2��6m   �� 5       �� Orientation$ 
Horizontal=�6   $��2��66   .+�5       �� $	��350��6!   .+�5!      �� $��/Resource/register.png��6    $	��300��6@   $	��300��6L   $��10q�6Y   5"      �� 5#      $	��350��6!   .+�5$      �� $��10 20q�6%   .+�5%      �� $��Login ��6)   $��20q�67   
�������	 �� TextAlignment$	 Center=�6V   $��25(�6m   $��Comic Sans MS)�6{   �� 5&      $ 
Horizontal=�6)   $��10q�6B   .+�5'   "   '  !MaterialDesignThemes.Wpf.PackIcon  
   Kind$

 User=�6:   $��25��6F   $��25��6Q   
�������6]   �� 5(   "   -   5         ��Name$ txt_Username��5(   *   $
��10 0q�6@   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Enter username��6N   
�������$	��250��6�   
������� �� 
CaretBrush �	#ffd94448 �� SelectionBrush �	#FFD94448��6�   �� *
Username+5)      �� 5*      $ 
Horizontal=�6)   $��10q�6B   .+�5+   "     $

 Lock=�6:   $��25��6F   $��25��6Q   
�������6]   �� 5,   "   -   5        $ txt_Password��5,   +   $
��10 0q�6A   $ Enter Password��6O   
�������$	��250��6�   
������� �	#ffd94448 �	#FFD94448��6�   �� *
Password+5-      �� 5.      $��10q�6)   $��Center=�65   .+�5/   "   �� -   5         ��Name$ 	btn_Login��5/     $	��100��6)   $��40��65      MaterialDesignRaisedButton#��[  6A   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6u   $��2q�6�   ���#D94448���#D94448
�������$��Login��6�    � ToolTip$ Login��6  ��6(  �� *LoginCommand+50      51      52      �� 53      $	��100��6!   .+�54      �� -   5        $ btn_Exit��54   �   $y�Hidden=�6!   $��10 20q�65    & "MaterialDesignFloatingActionButton#��[ 6D   $ Close��6�   ��6�   Z� .��55        $
 Close=�66   
�������$��30��6V   $��30��6b   56      57      58      59      5:      5;      5<      