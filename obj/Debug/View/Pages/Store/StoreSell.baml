   M S B A M L   `   `   `  ����G  CTradeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TradeProject.View.Pages.StoreTradeProject.View.Pages.Store  5      W0clr-namespace:TradeProject.ViewModel.PageControl"TradeProject.ViewModel.PageControl  5      -    'TradeProject.View.Pages.Store.StoreSell   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:TradeProject.View.Pages.Store     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      9pc0clr-namespace:TradeProject.ViewModel.PageControl  5        N� Title$  	StoreSell��5      .��5      (� .��5   
   � y�6   �� *LoginPageVisibility+ � ColumnDefinitions 5      �� 5      $	��15* �6#   �� 5      $	��17* �6#   ��5      �� 5       �� 
StartPoint$ 0.1,0&�6&    �� EndPoint$ 0.9,1&�69   .��5      �  � Color$ 	#ffe63070��6#    � Offset$ 1Q�65   � 5      $ 	#fffe8704��6#   $ 0Q�65   5      .+�5      �� $	��390��6   $	��Top=�6"    �� CornerRadius$ 	0 0 190 0��6:   ���#100e17$��2��6i   �� 5       �� Orientation$ 
Horizontal=�6   $��2��62   .+�5      �� $	��350��6   $
��0 60q�6)   .+�5      �� $��10 20q�6!   .+�5      �� $ 
Horizontal=�6%   $��10q�6>   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ Cobweb=�66   $��25��6D   $��25��6O   
�������6[   �� 5      $
��10 0q�6'   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Kodu daxil edin��65   
�������$	��250��6y   
�������
 �� 
CaretBrush
 �	#ffd94448 �� SelectionBrush �	#FFD94448��6�   �� *
Username+5       �� 5!      $ 
Horizontal=�6%   $��10q�6>   .+�5"        $ Discount=�66   $��25��6F   $��25��6Q   
�������6]   �� 5#      $
��10 0q�6(   $	 Sayını daxil edin��66   
�������$	��250��6|   
�������
 �	#ffd94448 �	#FFD94448��6�   �� *
Password+5$      �� 5%      $��10q�6%   $��Center=�61   .+�5&      �� $	��100��6%   $��40��61      MaterialDesignRaisedButton#��[  6=   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6q   $��2q�6�   ���#D94448���#D94448
�������$��Davam et��6�    � ToolTip$ Login��6  ��6  �� *LoginCommand+5'      5(      5)      �� 5*      $	��100��6   .+�5+      �� $��Satış ��6!   $��20q�6/   
������� �� TextAlignment$ Center=�6N   $��25(�6e   $��Comic Sans MS)�6s   5,      �� 5-      $	��350��6   $
��0 60q�6)   .+�5.      �� $��10 20q�6!   .+�5/      �� $ 
Horizontal=�6%   $��10q�6>   .+�50        $ Cobweb=�66   $��25��6D   $��25��6O   
�������6[   �� 51      $
��10 0q�6'   
�������$	��250��6I   
�������
 �	#ffd94448 �	#FFD94448��6�   �� *
Username+52      �� 53      $ 
Horizontal=�6%   $��10q�6>   .+�54        $ Discount=�66   $��25��6F   $��25��6Q   
�������6]   �� 55      $
��10 0q�6(   
�������$	��250��6J   
�������
 �	#ffd94448 �	#FFD94448��6�   �� *
Password+56      �� 57      $��10q�6%   $��Center=�61   .+�58      �� $	��100��6%   $��40��61   #��[  6=   $ 20��6q   $��2q�6�   ���#D94448���#D94448
�������$	��Sat��6�   $ Login��6�   ��6  �� *LoginCommand+59      5:      5;      5<      5=      5>      5?      