   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   '    !_1612057_QuanLyBanHang.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   	   ?uc6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan  5   
   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5        $��
mainWindow��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    
 MainVM � DataContext# [ 5   	    � Title$+ %Phần mềm quản lý bán hàng��5   	   $	��450��6/   $	��800��6<   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 6$   �� *LoadedWindowCommand+
   CommandParameter
 6L   ��  �� ElementName$ 
mainWindow��5      .��5!      �  � RowDefinitions 5#   
   �� 5$      $
��auto �6   6,   �� 5%      6   .+�5'   
   � $��0��6   .+�5(      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+$ 
mainWindow��6N   5)      � 5+   
   $��1��6    5,      �� 5-      $
��auto �6    60   �� 5.      6"   .+�52      � $��0��6   .+�53      � $��Stretch=�6   $��Stretch=�65   
������  � 	Resources 54       �� 
TargetType �� Property �� Value��%�   '��       �� 55      " ��6    .�56      ��  � ��$ 2 4 2 4q�67   6I   �� 57       � ��
 �����6O   58      59       � ColumnDefinitions 5:      �� 5;      6-   �� 5<      6-   �� 5=      6-   �� 5>      6-   �� 5?      6-   �� 5@      6-   �� 5A      6-   .+�5C      �� $��0��6    � ToolTip$ 
Bán hàng��6M   ��6-   �� *SellCommand+.��5D      �  5E      �� 5F   "   62   �� 5G   "   62   .+�5I      � $��0��6#   .+�5J   "   �� $��
Bán hàng��6,   $��Center=�6<   6[   5K      � 5L      $��1��6#   .+�5M   "   '  !MaterialDesignThemes.Wpf.PackIcon  $��Center=�6:   $��30��6W   $��30��6b   �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=null]]   Kind$ Shopify=�6o   5N      5O      5P      �� 5Q      $��1��6   $ Đơn hàng��6M   ��6-   �� *BillCommand+.��5R      �  5S      �� 5T   "   62   �� 5U   "   62   .+�5W      � $��0��6#   .+�5X   "   �� $��Đơn hàng��6,   $��Center=�6<   6[   5Y      � 5Z      $��1��6#   .+�5[   "     $��30��6:   $��30��6E   $��Center=�6R   $ Receipt=�6p   5\      5]      5^      �� 5`      $��2��6   $ Đăng kí KH��6Q   ��6-   �� *RegisterCommand+.��5a      �  5b      �� 5c   "   62   �� 5d   "   62   .+�5f      � $��0��6#   .+�5g   "   �� $��Đăng kí KH��6,   $��Center=�6>   6]   5h      � 5i      $��1��6#   .+�5j   "     $��30��6:   $��30��6E   $��Center=�6R   $ Register=�6p   5k      5l      5m      �� 5n      $��3��6   $ Thống kê��6R   ��6-   �� *StatisticCommand+.��5o      �  5p      �� 5q   "   62   �� 5r   "   62   .+�5t      � $��0��6#   .+�5u   "   �� $��Thống kê��6,   $��Center=�6<   6[   5v      � 5w      $��1��6#   .+�5x   "     $��30��6:   $��30��6E   $��Center=�6R   $	 Dns=�6p   5y      5z      5{      �� 5|      $��4��6   $ Nhập hàng��6N   ��6-   �� *InputCommand+.��5}      �  5~      �� 5   "   62   �� 5�   "   62   .+�5�      � $��0��6#   .+�5�   "   �� $��Quản lý hàng��6,   $��Center=�6@   6_   5�      � 5�      $��1��6#   .+�5�   "     $��30��6:   $��30��6E   $��Center=�6R   $ Buffer=�6p   5�      5�      5�      �� 5�      $��5��6   $ Cửa hàng��6M   ��6-   �� *ShopCommand+.��5�      �  5�      �� 5�   "   62   �� 5�   "   62   .+�5�      � $��0��6#   .+�5�   "   �� $��Phân tích��6,   $��Center=�6=   6\   5�      � 5�      $��1��6#   .+�5�   "     $��30��6:   $��30��6E   $��Center=�6R   $
 Shop=�6p   5�      5�      5�      �� 5�      $��6��6   $ Đăng kí KH��6L   ��6-   �� *
QTVCommand+.��5�      �  5�      �� 5�   "   62   �� 5�   "   62   .+�5�      � $��0��6#   .+�5�   "   �� $��Đăng kí QTV��6,   $��Center=�6?   6^   5�      � 5�      $��1��6#   .+�5�   "     $��30��6:   $��30��6E   $��Center=�6R   $ Register=�6p   5�      5�      5�      5�      5�      � 5�      $��1��6    5�      �� 5�      $
��279* �6'   �� 5�      $
��116* �6'   �� 5�      $��5* �6'   5�      5�      5�      5�      