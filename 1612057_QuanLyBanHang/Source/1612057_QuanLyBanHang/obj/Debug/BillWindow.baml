   M S B A M L   `   `   `  ����P  L1612057_QuanLyBanHang, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:_1612057_QuanLyBanHang_1612057_QuanLyBanHang  5   	   c6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan(_1612057_QuanLyBanHang.UserControl_Chuan  5   
   '    !_1612057_QuanLyBanHang.BillWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:_1612057_QuanLyBanHang     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5	   
   ?uc6clr-namespace:_1612057_QuanLyBanHang.UserControl_Chuan  5   
   V RMaterialDesignThemes.Wpf, Version=2.5.0.1205, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5        $��window��5   	      MaterialDesignBody#���   5   	   $��Regular"�5   
   $��13(�5   
   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   
      TextRenderingMode$
 Auto=�5   
     MaterialDesignPaper#���  5   
     MaterialDesignFont#���  5   
    � 
ResizeMode$ NoResize=�5   	    � WindowStyle$
 None=�5   	    
 BillVM � DataContext# [ 5       � Title$ 
Hóa đơn��5   	   $	��450��6   $	��800��6&   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   6,   �� 5       6   .+�5"   
   � $��0��6   .+�5#      ;   5_1612057_QuanLyBanHang.UserControl_Chuan.ControlBarUC  
 � Tag 6   �� *Title+ �� ElementName$ window��6J   5$      � 5&   
   $��1��6    5'      �� 5(      $
��auto �6    60   �� 5)      $
��auto �6    60   �� 5*      6"   .+�5.      #  MaterialDesignThemes.Wpf.Card  $��0��6"   $��5q�6/   .��5/      � $��0 0 0 10q�6   .+�51      �� $	��120��6   $��5 5 15 5q�6+   	 �� DisplayMemberPath$	 TenKhachHang��6=   )  #MaterialDesignThemes.Wpf.HintAssist
   Hint$
 Khách hàng��6�   {�.   & "MaterialDesignFloatingHintComboBox#��[ 6  ��6^   �� *	KHACHHANG+ �� SelectedItem 6�   �� *SelectedKHACHHANG+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6Y  �� 53      -   5         ��Name$ sanphamChanged��53      $	��200��67   $��5 5 15 5q�6C   $	 
TenSanPham��6U   $
 Tên sản phẩm��6�   {�.  #��[ 6/  ��6t   �� *	SANPHAM+ 6�   �� *SelectedSANPHAM+$ TwoWay=�$ PropertyChanged=�.  (System.Windows.Interactivity.Interaction   Triggers 54      /  )System.Windows.Interactivity.EventTrigger  55         	EventName$ SelectionChanged��6-   .  (System.Windows.Interactivity.TriggerBase   Actions. 56   "   6  0System.Windows.Interactivity.InvokeCommandAction     Command 68   �� *InfoChangeCommand+   CommandParameter 6^   �� $ sanphamChanged��57      59      �� 5;      $	��120��6   $��5 5 15 5q�6+   $
 
Đơn giá��6�   {�.   % !MaterialDesignFloatingHintTextBox#��[ 6�   ��6=   �� *DonGia+$ TwoWay=�$ PropertyChanged=�6�   �� 5<      $	��120��6   $��5 5 15 5q�6*   $
 Khuyến Mãi��6�   {�.  #��[ 6�   ��6<   �� *TenKhuyenMai+$ TwoWay=�$ PropertyChanged=�6�   �� 5?      -   5         ��Name$ soluong��5?      $��70��6/   $��5 5 15 5q�6:   $
 Số lượng��6�   {�.  #��[ 6�   ��6L   �� *	SoLuong+$ TwoWay=�$ PropertyChanged=�.��6   5@        5A      $ TextChanged��6-   . 5B   "      68   �� *TextChangeCommand+ 6^   �� $ soluong��5C      .��5D   2   5E      �� 5G      -   5        $ tongtien��5G      $	��150��60   $��5 5 15 5q�6<   $
 Tổng tiền��6�   {�.  #��[ 6�   ��6N   �� *
TongTien+$ TwoWay=�$ PropertyChanged=�6�   �� 5H      $	��250��6   $��5 5 15 5q�6+   $
	 MoTa��6>   $
 Tình trạng��6�    �� 
IsEditable . #��[ 6  ��6W   �� *	TINHTRANG+ 6y   �� *SelectedTINHTRANG+$ TwoWay=�$ PropertyChanged=�6R  (	  "System.Windows.Controls.DatePicker	  5I      $	��150��6!   $��Center=�6-   $��5 5 15 5q�6�   $
 
Ngày bán��6�   {�.   ( $MaterialDesignFloatingHintDatePicker#��[ 6�    	  SelectedDate 6H   �� *	NgayMua+$ TwoWay=�$ PropertyChanged=�6�   �� 5J      $	��150��6   $��5 5 15 5q�6+   $	 TenQTV��6=   $
 Người bán��6�   {�.  #��[ 6  ��6X   �� *QUANTRIVIEN+ 6|   �� *SelectedQUANTRIVIEN+$ TwoWay=�$ PropertyChanged=�6V  5M      5N        5Q      $��1��6"   $��5q�6/   .��5R      � $��Center=�6   $��Center=�69   .+�5T      �� $��Sắp xếp��6>   $��5 5 70 5q�6P   $	��100��6b   ��6   �� *SortCommand+6p   �� 5U      $��Xóa��6?   $��5 5 70 5q�6N   $	��100��6`   ��6   �� *DeleteCommand+6n   �� 5V      $��Sửa��6=   $��5 5 70 5q�6L   $	��100��6^   ��6   �� *EditCommand+6l   �� 5W      $��Chưa thanh toán��6?   $��5 5 70 5q�6Y   $	��150��6k   ��6   �� *NotPayCommand+6y   5X      5Y        5\      $��2��6"   $��5q�6/   $��Stretch=�6:   .��5]      �� $
��Auto=�6   .��5^      �� ��6   �� *List+ 6<   �� *SelectedItem+$ OneWayToSource=� �� View 5_      �� 5`      .P�5b   "   ��  �� Width$ 50��61   $��ID��6<    �� DisplayMemberBinding 6H   �� *
ID_DONHANG+6v   �� 5c   "   $	 100��61   $��Khách hàng��6=    6Q   �� *KHACHHANG.TenKhachHang+6�   �� 5d   "   $	 100��61   $��Sản phẩm��6=    6O   �� *SANPHAM.TenSanPham+6�   �� 5e   "   $	 100��61   $��SoLuong��6=    6N   �� *	SoLuong+6y   �� 5f   "   $	 100��61   $��Tổng tiền��6=    6P   �� *
TongTien+6|   �� 5g   "   $	 100��61   $��Tình trạng��6=    6Q   �� *TINHTRANG.MoTa+6�   �� 5h   "   $	 100��61   $��
Ngày mua��6=    6P   �� *	NgayMua+6{   �� 5i   "   $	 100��61   $��Người bán��6=    6P   �� *QUANTRIVIEN.TenQTV+6�   5k      5m      5n      5o      5p      5q      5r      