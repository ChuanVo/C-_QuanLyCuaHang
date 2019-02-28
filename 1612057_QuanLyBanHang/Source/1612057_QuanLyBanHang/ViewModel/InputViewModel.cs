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
    public class InputViewModel : BaseViewModel
    {

        private ObservableCollection<Model.SANPHAM> _List;
        public ObservableCollection<Model.SANPHAM> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }

        private ObservableCollection<Model.LOAISANPHAM> _LOAISANPHAM;
        public ObservableCollection<Model.LOAISANPHAM> LOAISANPHAM
        {
            get => _LOAISANPHAM; set { _LOAISANPHAM = value; OnPropertyChanged(); }

        }

        private ObservableCollection<Model.KHUYENMAI> _KHUYENMAI;
        public ObservableCollection<Model.KHUYENMAI> KHUYENMAI
        {
            get => _KHUYENMAI; set { _KHUYENMAI = value; OnPropertyChanged(); }

        }

        // tạo selected item
        private Model.SANPHAM _SelectedItem;
        public Model.SANPHAM SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();

                if (SelectedItem != null)
                {
                    SelectedLOAISANPHAM = SelectedItem.LOAISANPHAM;
                    SelectedKHUYENMAI = SelectedItem.KHUYENMAI;
                    TenSanPham = SelectedItem.TenSanPham;
                    HangSanXuat = SelectedItem.HangSanXuat;
                    GiaNhap = SelectedItem.GiaNhap;
                    GiaTien = SelectedItem.GiaTien;

                }

            }

        }

        // binding dữ liệu để show lên
        private Model.LOAISANPHAM _SelectedLOAISANPHAM;
        public Model.LOAISANPHAM SelectedLOAISANPHAM
        {
            get => _SelectedLOAISANPHAM;
            set
            {
                _SelectedLOAISANPHAM = value;
                OnPropertyChanged();
            }
        }

        private Model.KHUYENMAI _SelectedKHUYENMAI;
        public Model.KHUYENMAI SelectedKHUYENMAI
        {
            get => _SelectedKHUYENMAI;
            set
            {
                _SelectedKHUYENMAI = value;
                OnPropertyChanged();
            }
        }

        private string _TenSanPham;
        public string TenSanPham { get => _TenSanPham; set { _TenSanPham = value; OnPropertyChanged(); } }

        private string _HangSanXuat;
        public string HangSanXuat { get => _HangSanXuat; set { _HangSanXuat = value; OnPropertyChanged(); } }

        private int? _GiaNhap;
        public int? GiaNhap { get => _GiaNhap; set { _GiaNhap = value; OnPropertyChanged(); } }

        private int? _GiaTien;
        public int? GiaTien { get => _GiaTien; set { _GiaTien = value; OnPropertyChanged(); } }

        private int _SoLuongNhap;
        public int SoLuongNhap { get => _SoLuongNhap; set { _SoLuongNhap = value; OnPropertyChanged(); } }

        // cac command

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public InputViewModel()
        {
 
            List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderBy(x=>x.SoLuongCon)); // =0 là object được xóa
            LOAISANPHAM = new ObservableCollection<Model.LOAISANPHAM>(DataProvider.Intance.DataBase.LOAISANPHAMs);
            KHUYENMAI = new ObservableCollection<Model.KHUYENMAI>(DataProvider.Intance.DataBase.KHUYENMAIs);

            // add command
            AddCommand = new RelayCommand<SANPHAM>((p_Window) =>
            {
                // kiem tra điều kiện để add
                if (SelectedLOAISANPHAM == null || SelectedKHUYENMAI == null || SoLuongNhap <= 0)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var sanpham = new Model.SANPHAM()
                {
                    ID_LoaiSanPham = SelectedLOAISANPHAM.ID_LOAISANPHAM,
                    ID_KhuyenMai = SelectedKHUYENMAI.ID_KHUYENMAI,
                    TenSanPham = TenSanPham,
                    HangSanXuat = HangSanXuat,
                    GiaNhap = GiaNhap,
                    GiaTien = GiaTien,
                    SoLuongCon = SoLuongNhap,
                    SoLuotMua = 0
                };

                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.TenSanPham == sanpham.TenSanPham && p.HangSanXuat == sanpham.HangSanXuat);
                if(SanPham.Count() > 0)
                {
                    SanPham.First().ID_KhuyenMai = SelectedKHUYENMAI.ID_KHUYENMAI;
                    SanPham.First().SoLuongCon = SanPham.First().SoLuongCon + SoLuongNhap;
                }
                else
                {
                    DataProvider.Intance.DataBase.SANPHAMs.Add(sanpham);
                    List.Add(sanpham);
                }
  
                DataProvider.Intance.DataBase.SaveChanges();
            });

            // Delete command
            DeleteCommand = new RelayCommand<SANPHAM>((p_Window) =>
            {
                // kiem tra điều kiện để xóa
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {


                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedItem.ID_SANPHAM).SingleOrDefault();
               SanPham.IsDelete = 0;
             
                DataProvider.Intance.DataBase.SaveChanges();

                // load lại list sau khi cập nhật giá trị IsDelete
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0));
            });

            // Edit command
            EditCommand = new RelayCommand<SANPHAM>((p_Window) =>
            {
                // kiem tra điều kiện để sửa
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                // chỉ cho phép sửa thông tin về khuyến mãi và giá bán
                var SanPham = DataProvider.Intance.DataBase.SANPHAMs.Where(p => p.ID_SANPHAM == SelectedItem.ID_SANPHAM).SingleOrDefault();
                SanPham.ID_KhuyenMai = SelectedKHUYENMAI.ID_KHUYENMAI;
                SanPham.GiaTien = GiaTien;

                DataProvider.Intance.DataBase.SaveChanges();
            });
        }
    }
}
