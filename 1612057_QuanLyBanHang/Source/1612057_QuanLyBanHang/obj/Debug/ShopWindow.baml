   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   '    !_1612057_QuanLyBanHang.ShopWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   
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
 None=�5   	    
 ShopVM � DataContext# [ 5   
    � Title$
 Shop��5   	   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5!   
   � $��0��6   .+�5"      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ window��6J   5#      � 5%   
   $��1��6    5&      �� 5'      $
��auto �6    60   �� 5(      $
��auto �6    60   �� 5)      6"   .+�5.      #  MaterialDesignThemes.Wpf.Card  $��1��6"   $��5q�6/   .��5/      � $��Center=�6   $��Center=�69   .+�50      �� $
��Tên��6>   $��5 5 70 5q�6L   $	��130��6^   ��6   �� *NameCommand+6m   �� 51      $
��Giá��6>   $��5 5 70 5q�6L   $	��130��6^   ��6   �� *PriceCommand+6l   �� 52      $��Loại sản phẩm��6A   $��5 5 70 5q�6Y   $	��130��6k   ��6   �� *CategoryCommand+6y   �� 53      $��Số lượng mua��6>   $��5 5 70 5q�6U   $	��130��6g   ��6   �� *SLMuaCommand+6v   �� 54      $��Số lượng còn��6>   $��5 5 70 5q�6U   $	��130��6g   ��6   �� *SLConCommand+6u   55      56        59      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5:      �� $
��Auto=�6   .��5;      �� ��6   �� *List+	 �� SelectedItem	 6<   �� *SelectedItem+
 �� Mode$
 OneWayToSource=� �� View 5<      �� 5=      .P�5>   "   ��  �� Width$ 50��61   $��ID��6<    �� DisplayMemberBinding 6H   �� *
ID_SANPHAM+6v   �� 5?   "   $	 100��61   $��	Loại SP��6=    6N   �� *LOAISANPHAM.TenLoaiSanPham+6�   �� 5@   "   $	 100��61   $��Khuyến mãi��6=    6Q   �� *KHUYENMAI.TenKhuyenMai+6�   �� 5A   "   $	 100��61   $��Tên sản phẩm��6=    6S   �� *
TenSanPham+6�   �� 5B   "   $	 100��61   $��Hãng sản xuất��6=    6T   �� *HangSanXuat+6�   �� 5C   "   $	 100��61   $��	Giá bán��6=    6N   �� *	GiaTien+6y   �� 5D   "   $	 100��61   $��Giá nhập��6=    6O   �� *	GiaNhap+6z   �� 5E   "   $	 100��61   $��SL mua��6=    6M   �� *	SoLuotMua+6z   �� 5F   "   $	 100��61   $��SL còn��6=    6M   �� *
SoLuongCon+6{   5G      5I      5J      5K      5L      5M      5N      