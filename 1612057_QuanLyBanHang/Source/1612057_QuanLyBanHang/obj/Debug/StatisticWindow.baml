   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   ,    &_1612057_QuanLyBanHang.StatisticWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   
   ?uc6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan  5   
   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	     StatisticVM � DataContext# [ 5   
    � Title$ Thống kê��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5!   
   � $��0��6   .+�5"      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ window��6J   5#      � 5%   
   $��1��6   	 � ColumnDefinitions	 5&      �� 5'      6&   �� 5(      6%   .+�5+      � $��0��6   	 5,      �� 5-      6)   �� 5.      6)   .+�51      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��1q�62   $��Stretch=�6=   .��52      �  53      �� 54      6*   �� 55      6*   �� 56      6*   �� 57      6*   �� 58      6*   .+�5:      � $��0��6   $��Center=�6+   $��Center=�6H   .+�5;      �� $��	Doanh thu��6B   $	��160��6W   ��6   �� *DoanhThuCommand+6f   5<      � 5=      $��1��6    $��Center=�6-   $��Center=�6J   .+�5>      �� $��Lợi nhuận��6F   $	��160��6Z   ��6"   �� *LoiNhuanCommand+6h   5?      � 5@      $��2��6    $��Center=�6-   $��Center=�6J   .+�5A      �� $��SP bán chạy nhất��6I   $	��160��6e   ��6"   �� *BanChayNhatCommand+6s   5B      � 5C      $��3��6    $��Center=�6-   $��Center=�6J   .+�5D      �� $��SP bán ít nhất��6G   $	��160��6a   ��6"   �� *BanItNHatCommand+6p   5E      5F      5G        5I      $��1��6"   $��1q�62   $��Stretch=�6=   .��5J      �  5K      �� 5L      6*   �� 5M      6*   �� 5N      6*   �� 5O      6*   �� 5P      6*   .+�5R      � $��0��6    $��Center=�6-   $��Center=�6J   .+�5S      �� $	��200��6"   ��6.   �� *
DoanhThu+6J   5T      � 5U      $��1��6    $��Center=�6-   $��Center=�6J   .+�5V      �� $	��200��6"   ��6.   �� *
LoiNhuan+6J   5W      � 5X      $��2��6    $��Center=�6-   $��Center=�6J   .+�5Y      �� $	��200��6"   ��6.   �� *	SPBanChay+6K   5Z      � 5[      $��3��6    $��Center=�6-   $��Center=�6J   .+�5\      �� $	��200��6"   ��6.   �� *	SPBanIt+6I   5]      5^      5_      5`      5b      5c      5d      