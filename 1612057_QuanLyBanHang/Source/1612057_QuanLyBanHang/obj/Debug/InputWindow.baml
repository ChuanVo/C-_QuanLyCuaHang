   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   (    "_1612057_QuanLyBanHang.InputWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   
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
 None=�5   	     InputVM � DataContext# [ 5   
    � Title$ Nhập hàng��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5!   
   � $��0��6   .+�5"      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ window��6J   5#      � 5%   
   $��1��6    5&      �� 5'      $
��auto �6    60   �� 5(      $
��auto �6    60   �� 5)      6"   .+�5-      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5.      � $��0 0 0 10q�6   .+�50      �� $	��120��6   $��5 5 15 5q�6+   	 �� DisplayMemberPath$	 TenLoaiSanPham��6=   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Loại sản phẩm��6�    �� 
IsEditable .  & "MaterialDesignFloatingHintComboBox#��[ 6$  ��6`   �� *LOAISANPHAM+ �� SelectedItem 6�   �� *SelectedLOAISANPHAM+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6b  �� 51      $	��120��6   $��5 5 15 5q�6+   $	 TenKhuyenMai��6=   $
 Khuyến mãi��6�    . #��[ 6  ��6^   �� *	KHUYENMAI+ 6�   �� *SelectedKHUYENMAI+$ TwoWay=�$ PropertyChanged=�6Y  �� 52      $��5 5 15 5q�6m   $
 Tên sản phẩm��6    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *
TenSanPham+$ PropertyChanged=�$ TwoWay=�6�   �� 53      $��5 5 15 5q�6m   $
 
Tên Hãng��6   #��[ 6�   ��6   �� *HangSanXuat+$ PropertyChanged=�$ TwoWay=�6�   �� 54      $��5 5 15 5q�6i   $
 Giá nhập��6{   #��[ 6�   ��6   �� *	GiaNhap+$ PropertyChanged=�$ TwoWay=�6�   �� 55      $��5 5 15 5q�6i   $
 	Giá bán��6{   #��[ 6�   ��6   �� *	GiaTien+$ PropertyChanged=�$ TwoWay=�6�   �� 56      $��5 5 15 5q�6m   $
 Số lượng��6   #��[ 6�   ��6   �� *SoLuongNhap+$ PropertyChanged=�$ TwoWay=�6�   57      58        5;      $��1��6"   $��5q�6/   .��5<      � $��Center=�6   $��Center=�69   .+�5=      �� $��Nhập hàng��6=   $��5 5 70 5q�6Q   $	��130��6c   ��6   �� *
AddCommand+6r   �� 5>      $
��Xóa��6?   $��5 5 70 5q�6M   $	��130��6_   ��6   �� *DeleteCommand+6m   �� 5?      $��Sửa��6=   $��5 5 70 5q�6K   $	��130��6]   ��6   �� *EditCommand+6k   5@      5A        5D      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5E      �� $
��Auto=�6   .��5F      �� ��6   �� *List+ 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5G      �� 5H      .P�5I   "   ��  �� Width$ 50��61   $��ID��6<    �� DisplayMemberBinding 6H   �� *
ID_SANPHAM+6v   �� 5J   "   $	 100��61   $��	Loại SP��6=    6N   �� *LOAISANPHAM.TenLoaiSanPham+6�   �� 5K   "   $	 100��61   $��Khuyến mãi��6=    6Q   �� *KHUYENMAI.TenKhuyenMai+6�   �� 5L   "   $	 100��61   $��Tên sản phẩm��6=    6S   �� *
TenSanPham+6�   �� 5M   "   $	 100��61   $��Hãng sản xuất��6=    6T   �� *HangSanXuat+6�   �� 5N   "   $	 100��61   $��	Giá bán��6=    6N   �� *	GiaTien+6y   �� 5O   "   $	 100��61   $��Giá nhập��6=    6O   �� *	GiaNhap+6z   �� 5P   "   $	 120��61   $��Số lượng tồn��6=    6S   �� *
SoLuongCon+6�   5Q      5S      5T      5U      5V      5W      5X      