   M S B A M L   `   `   `  ����G  CTradeProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:TradeProject.ViewModel.WindowTradeProject.ViewModel.Window  5   	   "    TradeProject.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :vm+clr-namespace:TradeProject.ViewModel.Window     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.2.1465, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � Title$  
MainWindow��5	   	   $	��550��6   $	��800��6)    � DataContext 5      1   +TradeProject.ViewModel.Window.MainViewModel  5   
    � 	Resources 5         	CloseMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value  OpenMenu��%\  &	        &	 �    �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $	 250Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 1Q�63     5      $ 0:0:0.5��6'   $ 0Q�69   5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $ GridMenu��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.5��6'   $	 250Q�69   5      U� 5      $ (UIElement.Opacity)�6,   $ GridBackground��6\   .\�5        $ 0��6'   $ 0Q�63     5       $ 0:0:0.5��6'   $ 1Q�69   5!      5"      5#       � Triggers 5$      :� 5%   
    :� RoutedEvent$ ButtonBase.Click��6   	 :� 
SourceName$	 ButtonClose��66   .[�5&      �� -   5        
 ��Name$
 CloseMenu_BeginStoryboard��5&      #��[  6A   5'      :� 5(   
   $ ButtonBase.Click��6   $	 
ButtonOpen��66   .[�5)      �� #��[ 6   5*      .��5,      � ��5-   
   �� 5.       �� 
StartPoint$ 0.1,0&�6"    �� EndPoint$ 0.9,1&�65   .��5/      �  � Color$ 	#ffe63070��6    � Offset$ 1Q�61   � 50      $ 	#fffe8704��6   $ 0Q�61   51      .+�54   
   ��  �� CornerRadius$ 	0 0 190 0��6   ���#100e17$��0,0,0,60q�6@   � 55   
   -   5         �Name$ GridBackground��55      ���	#55313131 J� Opacity$ 0Q�6>    K� ZIndex$ 0��6J   �� 56   
   -   5         ��Name$ 
ButtonOpen��56      $
��Left=�6%   $	��Top=�6@   
�������$��30��6�   $��30��6�   $��0q�6�   $ 2��6�   ��6k   Z� .��57      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�6&   ���	#FF31313162   58      � 59   
   -   5        $ GridMenu��59      $	��250��6!   $
��Left=�6-   $��
-250 0 0 0q�6H   ���#031927 J� RenderTransformOrigin$ 0.5,0.5&�6q   $ 2��6�   z�5:      V� 5;      .~�5<      �� �� 5=      �� 5>      T� 5?      5@      .+�5B      �� .+�5C      �� $	��200��6   $��/Resource/sell.png��6%   $
��Fill=�6A   �� 5D      ���	#FF313131$��Champagne & Limousines)�62   $��18(�6Z   .@�5E      �� $��50��6#   $��0q�6/   .��5F      ��  �� Orientation$ 
Horizontal=�6%   $��10 0 q�6>   .+�5G        $ AddBox =�66   $��20��6E   $��20��6P   $��1q�6\   $��Center=�6g   
����  �6�   �� 5H      $��Add Item��6%   $��5q�68   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 20��6C   ���#031927$��1q�6�   
����  ���6�   �� *
AddCommand+5I      5J      �� 5K      $��50��6#   $��0q�6/   .��5L      �� $ 
Horizontal=�6%   $��10 0 q�6>   .+�5M        $ Remove=�66   $��20��6D   $��20��6O   $��1q�6[   $��Center=�6f   
���  ��6�   �� 5N      $��Remove��6%   $��5q�66   $ 20��6A   ���#031927��6�   �� *RemoveCommand+5O      5P      �� 5Q      $��50��6#   $��0q�6/   .��5R      �� $ 
Horizontal=�6%   $��10 0 q�6>   .+�5S        $ Update=�66   $��20��6D   $��20��6O   $��1q�6[   $��Center=�6f   
������6�   �� 5T      $��Update��6%   $��5q�66   $ 20��6A   ���#031927
����� ���6�   �� *UpdateCommand+5U      5V      �� 5W      $��50��6#   $��0q�6/   .��5X      �� $ 
Horizontal=�6%   $��10 0 q�6>   .+�5Y        $ History=�66   $��20��6E   $��20��6P   $��1q�6\   $��Center=�6g   
�������6�   �� 5Z      $��History��6%   $��5q�67   $ 20��6B   ���#031927
���������6�   �� *HistoryCommand+5[      5\      �� 5]      $��50��6#   $��0q�6/   .��5^      �� $ 
Horizontal=�6%   $��10 0 q�6>   .+�5_        $
 Show=�66   $��20��6B   $��20��6M   $��1q�6Y   $��Center=�6d   
��� � �6   �� 5`      $
��Sell��6%   $��5q�64   $ 20��6?   ���#031927$��1q�6�   
��� � ���6�   �� *SellCommand+5a      5b      �� 5c      $��50��6#   $��0q�6/   .��5d      �� $ 
Horizontal=�6%   $��10 0 q�6>   .+�5e        $
 Home=�66   $��20��6B   $��20��6M   $��1q�6Y   $��Center=�6d   
����=H�6   �� 5f      $
��Home��6%   $��5q�64   $ 20��6?   ���#031927$��1q�6�   
����=H�6�   5g      5h      5i      5j      �� 5k      -   5        $ ButtonClose��5k      $��Right=�6*   $	��Top=�6F   
���   �$��30��6�   $��30��6�   $��0q�6�   
���������6q   Z� .��5l        $ Close=�6*   5m      5n       � 5o   
     � NavigationUIVisibility$ Hidden=�6,   $ 1��6L     � Source 6   �� *
PagePath+6L   5p      5q      