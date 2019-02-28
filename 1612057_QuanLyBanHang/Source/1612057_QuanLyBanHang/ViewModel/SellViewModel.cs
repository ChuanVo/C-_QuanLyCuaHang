using _1612057_QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace _1612057_QuanLyBanHang.ViewModel
{
    public class SellViewModel : BaseViewModel
    {

        private ObservableCollection<Model.DONHANG> _List;
        public ObservableCollection<Model.DONHANG> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }


        private ObservableCollection<Model.SANPHAM> _SANPHAM;
        public ObservableCollection<Model.SANPHAM> SANPHAM
        {
            get => _SANPHAM; set { _SANPHAM = value; OnPropertyChanged(); }

        }

        private ObservableCollection<Model.KHACHHANG> _KHACHHANG;
        public ObservableCollection<Model.KHACHHANG> KHACHHANG
        {
            get => _KHACHHANG; set { _KHACHHANG = value; OnPropertyChanged(); }

        }

        private ObservableCollection<Model.QUANTRIVIEN> _QUANTRIVIEN;
        public ObservableCollection<Model.QUANTRIVIEN> QUANTRIVIEN
        {
            get => _QUANTRIVIEN; set { _QUANTRIVIEN = value; OnPropertyChanged(); }

        }

        private ObservableCollection<Model.TINHTRANG> _TINHTRANG;
        public ObservableCollection<Model.TINHTRANG> TINHTRANG
        {
            get => _TINHTRANG; set { _TINHTRANG = value; OnPropertyChanged(); }

        }

        // tạo selected item
        private Model.DONHANG _SelectedItem;
        public Model.DONHANG SelectedItem {
            get => _SelectedItem;
            set {
                _SelectedItem = value;
                OnPropertyChanged();

                if (SelectedItem != null)
                {
                    SelectedSANPHAM = SelectedItem.SANPHAM;
                    SelectedKHACHHANG = SelectedItem.KHACHHANG;
                    SelectedQUANTRIVIEN = SelectedItem.QUANTRIVIEN;
                    SoLuong = SelectedItem.SoLuong;
                    TongTien = SelectedItem.TongTien;
                    SelectedTINHTRANG = SelectedItem.TINHTRANG;
                    NgayMua = SelectedItem.NgayMua;
                }

            }

        }

        // binding dữ liệu để show lên

        private int? _SoLuong;
        public int? SoLuong { get => _SoLuong; set { _SoLuong = value; OnPropertyChanged(); } }


        private int _DonGia;
        public int DonGia {
            get => _DonGia;
            set {
                _DonGia = value;
                OnPropertyChanged();
            }
        }

        private string _TenKhuyenMai;
        public string TenKhuyenMai
        {
            get => _TenKhuyenMai;
            set
            {
                _TenKhuyenMai = value;
                OnPropertyChanged();
            }
        }

        private int? _TongTien;
        public int? TongTien
        {
            get => _TongTien; set
            {
                //var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                //var KhuyenMai = DataProvider.Intance.DataBase.KHUYENMAIs.Where(p => p.ID_KHUYENMAI == SanPham.ID_KhuyenMai).First();
                //_TongTien = Convert.ToInt32((1.0 * SanPham.GiaTien * (1 - KhuyenMai.GiaTriKM) * 1.0 * SoLuong));
                _TongTien = value;
                OnPropertyChanged();
            }
        }


        private DateTime? _NgayMua;
        public DateTime? NgayMua { get => _NgayMua; set { _NgayMua = value; OnPropertyChanged(); } }

        private Model.SANPHAM _SelectedSANPHAM;
        public Model.SANPHAM SelectedSANPHAM
        {
            get => _SelectedSANPHAM;
            set
            {
                _SelectedSANPHAM = value;
                OnPropertyChanged();
            }
        }

        private Model.KHACHHANG _SelectedKHACHHANG;
        public Model.KHACHHANG SelectedKHACHHANG
        {
            get => _SelectedKHACHHANG;
            set
            {
                _SelectedKHACHHANG = value;
                OnPropertyChanged();
            }
        }

        private Model.QUANTRIVIEN _SelectedQUANTRIVIEN;
        public Model.QUANTRIVIEN SelectedQUANTRIVIEN
        {
            get => _SelectedQUANTRIVIEN;
            set
            {
                _SelectedQUANTRIVIEN = value;
                OnPropertyChanged();
            }
        }

        private Model.TINHTRANG _SelectedTINHTRANG;
        public Model.TINHTRANG SelectedTINHTRANG
        {
            get => _SelectedTINHTRANG;
            set
            {
                _SelectedTINHTRANG = value;
                OnPropertyChanged();
            }
        }


        // cac command

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand TextChangeCommand { get; set; }
        public ICommand InfoChangeCommand { get; set; }

        public SellViewModel()
        {
            // xử lí sự kiện textchanged ở soluong
            TextChangeCommand = new RelayCommand<TextBox>((p_Window) => { return true; }, (p_Window) => {
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                var KhuyenMai = DataProvider.Intance.DataBase.KHUYENMAIs.Where(p => p.ID_KHUYENMAI == SanPham.ID_KhuyenMai).First();
                TongTien = Convert.ToInt32((1.0 * SanPham.GiaTien * (1 - KhuyenMai.GiaTriKM) * 1.0 * SoLuong));
            });

            // xử lí sự kiện comboBox sản phẩm thay đổi
            InfoChangeCommand = new RelayCommand<ComboBox>((p_Window) => { return true; }, (p_Window) => {
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                 var KhuyenMai = DataProvider.Intance.DataBase.KHUYENMAIs.Where(p => p.ID_KHUYENMAI == SanPham.ID_KhuyenMai).First();

                var i = SanPham.GiaTien;
                DonGia = Convert.ToInt32(SanPham.GiaTien);
                TenKhuyenMai = KhuyenMai.TenKhuyenMai;
                
            });


            List = new ObservableCollection<Model.DONHANG>(DataProvider.Intance.DataBase.DONHANGs.Where(x=> x.IsDelete !=0)); // =0 là object được xóa
            SANPHAM = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs);
            KHACHHANG = new ObservableCollection<Model.KHACHHANG>(DataProvider.Intance.DataBase.KHACHHANGs);
            QUANTRIVIEN = new ObservableCollection<Model.QUANTRIVIEN>(DataProvider.Intance.DataBase.QUANTRIVIENs);
            TINHTRANG = new ObservableCollection<Model.TINHTRANG>(DataProvider.Intance.DataBase.TINHTRANGs);


            // xử lý các command thao tác thêm, xóa sửa
            AddCommand = new RelayCommand<DONHANG>((p_Window) =>
            {
                // kiem tra con hang hay không
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                if (SoLuong > SanPham.SoLuongCon)
                    return false;

                if (SelectedSANPHAM == null || SelectedTINHTRANG == null || NgayMua == null || SelectedKHACHHANG == null || SelectedQUANTRIVIEN == null||SoLuong<=0)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                SanPham.SoLuongCon = SanPham.SoLuongCon - SoLuong;
                SanPham.SoLuotMua = SanPham.SoLuotMua + SoLuong;

                var KhuyenMai = DataProvider.Intance.DataBase.KHUYENMAIs.Where(p => p.ID_KHUYENMAI == SanPham.ID_KhuyenMai).First();

             
                

                var DonHang = new Model.DONHANG()
                {
                    TongTien = Convert.ToInt32((1.0 * SanPham.GiaTien * (1 - KhuyenMai.GiaTriKM) * 1.0 * SoLuong)),
                    ID_SanPham = SelectedSANPHAM.ID_SANPHAM,
                    ID_KhachHang = SelectedKHACHHANG.ID_KHACHHANG,
                    ID_TinhTrang = SelectedTINHTRANG.ID_TINHTRANG,
                    ID_NguoiBan = SelectedQUANTRIVIEN.ID_QUANTRIVIEN,
                    SoLuong = SoLuong,
                   // TongTien = TongTien,
                    NgayMua = NgayMua
                };

                DataProvider.Intance.DataBase.DONHANGs.Add(DonHang);
                DataProvider.Intance.DataBase.SaveChanges();

                List.Add(DonHang);
            });

            // edit command
            EditCommand = new RelayCommand<DONHANG>((p_Window) =>
            {
                if (SelectedItem==null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedSANPHAM.ID_SANPHAM).First();
                var KhuyenMai = DataProvider.Intance.DataBase.KHUYENMAIs.Where(p => p.ID_KHUYENMAI == SanPham.ID_KhuyenMai).First();
                var DonHang = DataProvider.Intance.DataBase.DONHANGs.Where(x => x.ID_DONHANG == SelectedItem.ID_DONHANG).SingleOrDefault();

                DonHang.TongTien = Convert.ToInt32((1.0 * SanPham.GiaTien * (1 - KhuyenMai.GiaTriKM) * 1.0 * SoLuong));
                DonHang.ID_SanPham = SelectedSANPHAM.ID_SANPHAM;
                DonHang.ID_KhachHang = SelectedKHACHHANG.ID_KHACHHANG;
                DonHang.ID_TinhTrang = SelectedTINHTRANG.ID_TINHTRANG;
                DonHang.ID_NguoiBan = SelectedQUANTRIVIEN.ID_QUANTRIVIEN;
                DonHang.SoLuong = SoLuong;
                DonHang.NgayMua = NgayMua;

                DataProvider.Intance.DataBase.SaveChanges();

             //   SelectedItem = DonHang;
            });


            // Delete command
            DeleteCommand = new RelayCommand<DONHANG>((p_Window) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var DonHang = DataProvider.Intance.DataBase.DONHANGs.Where(x => x.ID_DONHANG == SelectedItem.ID_DONHANG).SingleOrDefault();
                DonHang.IsDelete = 0;

                DataProvider.Intance.DataBase.SaveChanges();

                // load lại list sau khi cập nhật giá trị IsDelete
                List = new ObservableCollection<Model.DONHANG>(DataProvider.Intance.DataBase.DONHANGs.Where(x => x.IsDelete != 0));
            });
        }
    }
}
