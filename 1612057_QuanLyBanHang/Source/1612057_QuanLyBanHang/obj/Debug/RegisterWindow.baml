   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   +    %_1612057_QuanLyBanHang.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   
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
 None=�5   	     
RegisterVM � DataContext# [ 5   
    � Title$ 
Đăng kí��5   	   $	��450��6   $	��800��6&   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5      6   .+�5!   
   � $��0��6   .+�5"      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ window��6J   5#      � 5%   
   $��1��6    5&      �� 5'      $
��auto �6    60   �� 5(      $
��auto �6    60   �� 5)      6"   .+�5-      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5.      � $��0 0 0 10q�6   .+�5/      �� $��5 5 15 5q�6e   )  #MaterialDesignThemes.Wpf.HintAssist	   Hint$	 Số điện thoại��6w    % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6   �� *SDT+
 �� UpdateSourceTrigger$
 PropertyChanged=� �� Mode$ TwoWay=�6�   �� 50      $��5 5 15 5q�6n   $	 Tên khách hàng��6�   #��[ 6�   ��6   �� *TenKhachHang+$
 PropertyChanged=�$ TwoWay=�6�   �� 51      $��5 5 15 5q�6h   $	 Địa chỉ��6z   #��[ 6�   ��6   �� *DiaChi+$
 PropertyChanged=�$ TwoWay=�6�   52      53        56      $��1��6"   $��5q�6/   .��57      � $��Center=�6   $��Center=�69   .+�58      �� $��Thêm��6=   $��5 5 70 5q�6L   $	��100��6^   ��6   �� *
AddCommand+6l   �� 59      $��Xóa��6?   $��5 5 70 5q�6N   $	��100��6`   ��6   �� *DeleteCommand+6n   �� 5:      $��Sửa��6=   $��5 5 70 5q�6L   $	��100��6^   ��6   �� *EditCommand+6l   5;      5<        5?      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5@      �� $
��Auto=�6   .��5A      �� ��6   �� *List+ �� SelectedItem 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5B      �� 5C      .P�5D   "   ��  �� Width$ 50��61   $��ID��6<    �� DisplayMemberBinding 6H   �� *ID_KHACHHANG+6x   �� 5E   "   $	 150��61   $��Số điện thoại��6=    6T   �� *SDT+6{   �� 5F   "   $	 100��61   $��	Họ tên��6=    6M   �� *TenKhachHang+6}   �� 5G   "   $	 100��61   $��Địa chỉ��6=    6N   �� *DiaChi+6x   5H      5J      5K      5L      5M      5N      5O      