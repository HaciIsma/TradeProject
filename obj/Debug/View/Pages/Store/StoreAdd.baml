   M S B A M L   `   `   `  ����G  CTradeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TradeProject.View.Pages.StoreTradeProject.View.Pages.Store  5      W0clr-namespace:TradeProject.ViewModel.PageControl"TradeProject.ViewModel.PageControl  5      ,    &TradeProject.View.Pages.Store.StoreAdd   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      7local+clr-namespace:TradeProject.View.Pages.Store  5      9pc0clr-namespace:TradeProject.ViewModel.PageControl  5        N� Title$  StoreAdd��5       � DataContext 5      <   6TradeProject.ViewModel.PageControl.StoreAddPageControl  5   
   .��5      � ��5   
   �� 5       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5      �  � Color$ #031927��6    � Offset$ 1Q�6/   � 5      $ #9DD1F1��6   $ 0Q�6/   5      .+�5   
   �� $	��390��6   $	��top=�6    �� CornerRadius$ 	0 0 190 0��66   ���#100e176O   (� 5   
   $��0,1,0,-1q�6   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $	��350��6   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ClipboardList=�6.   $	��300��6C   $	��300��6O   
�������6\   5      �� 5      $	��350��6   .+�5      �� $��20 40q�6!   .+�5      �� $��
Əlavə et��6%   $��10q�65   
�������	 �� TextAlignment$	 Center=�6T   $��38(�6k   $��Comic Sans Ms)�6y   5       �� 5!      $ 
Horizontal=�6!   $��10q�6:   .+�5"        $	 Cod=�62   $��25��6=   $��25��6H   
�������6T   �� 5#      -   5        
 ��Name$
 txt_additem��5#   "   $
��10 0q�67   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Kodu daxil edin��6E   
�������$	��250��6�   
������� �� 
CaretBrush �	#ffd94448 �� SelectionBrush �	#FFD94448��6�   �� *Code+5$      �� 5%      $ 
Horizontal=�6!   $��10q�6:   .+�5&        $ Dollar=�62   $��25��6@   $��25��6K   
�������6W   �� 5'      $
��10 0q�6#   $" Alış qiymətini daxil edin��61   
�������$	��250��6   
������� �	#ffd94448 �	#FFD94448��6�   �� *PurchasePrice+5(      �� 5)      $ 
Horizontal=�6!   $��10q�6:   .+�5*        $ Dollar=�62   $��25��6@   $��25��6K   
�������6W   �� 5+      $
��10 0q�6#   $# Satış qiymətini daxil edin��61   
�������$	��250��6�   
������� �	#ffd94448 �	#FFD94448��6�   �� *	SalePrice+5,      �� 5-      $ 
Horizontal=�6!   $��10q�6:   .+�5.        $ Counter=�62   $��25��6A   $��25��6L   
�������6X   �� 5/      $
��10 0q�6#   $ Sayını daxil edin��61   
�������$	��250��6w   
������� �	#ffd94448 �	#FFD94448��6�   �� *Count+50      �� 51      $��10q�6!   $��Center=�6-   .+�52      �� $	��120��6!   $��40��6-      MaterialDesignRaisedButton#��[  69   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6m   $��2q�6�   ���#D94448���#D94448
�������$��Yadda saxla��6�    � ToolTip$ Login��6  ��6  �� *
AddCommand+53      54      55      56      57      58      