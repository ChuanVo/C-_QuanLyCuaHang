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
    public class RegisterViewModel : BaseViewModel
    {

        private ObservableCollection<Model.KHACHHANG> _List;
        public ObservableCollection<Model.KHACHHANG> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }



        // tạo selected item
        private Model.KHACHHANG _SelectedItem;
        public Model.KHACHHANG SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();

                if (SelectedItem != null)
                {
                    SDT = SelectedItem.SDT;
                    TenKhachHang = SelectedItem.TenKhachHang;
                    DiaChi = SelectedItem.DiaChi;
                }

            }

        }

        // binding dữ liệu để show lên

        private int? _ID_KHACHHANG;
        public int? ID_KHACHHANG { get => _ID_KHACHHANG; set { _ID_KHACHHANG = value; OnPropertyChanged(); } }


        private string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }

        private string _TenKhachHang;
        public string TenKhachHang { get => _TenKhachHang; set { _TenKhachHang = value; OnPropertyChanged(); } }

        private string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }

        // cac command

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public RegisterViewModel()
        {

            List = new ObservableCollection<Model.KHACHHANG>(DataProvider.Intance.DataBase.KHACHHANGs.Where(x => x.IsDelete != 0)); // =0 là object được xóa


            // xử lý các command thao tác thêm, xóa sửa
            AddCommand = new RelayCommand<KHACHHANG>((p_Window) =>
            {
                if (string.IsNullOrEmpty(SDT)==true || string.IsNullOrEmpty(TenKhachHang)==true || string.IsNullOrEmpty(DiaChi) == true)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var KhachHang = new Model.KHACHHANG()
                {
                    SDT = SDT,
                    TenKhachHang = TenKhachHang,
                    DiaChi=DiaChi
                };

                DataProvider.Intance.DataBase.KHACHHANGs.Add(KhachHang);
                DataProvider.Intance.DataBase.SaveChanges();

                List.Add(KhachHang);
            });

            // edit command
            EditCommand = new RelayCommand<DONHANG>((p_Window) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var KhachHang = DataProvider.Intance.DataBase.KHACHHANGs.Where(x => x.ID_KHACHHANG== SelectedItem.ID_KHACHHANG).SingleOrDefault();

                KhachHang.SDT = SDT;
                KhachHang.TenKhachHang = TenKhachHang;
                KhachHang.DiaChi = DiaChi;

                DataProvider.Intance.DataBase.SaveChanges();

            });


            // Delete command
            DeleteCommand = new RelayCommand<DONHANG>((p_Window) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var KhachHang = DataProvider.Intance.DataBase.KHACHHANGs.Where(x => x.ID_KHACHHANG == SelectedItem.ID_KHACHHANG).SingleOrDefault();
                KhachHang.IsDelete = 0;

                DataProvider.Intance.DataBase.SaveChanges();

                // load lại list sau khi cập nhật giá trị IsDelete
                List = new ObservableCollection<Model.KHACHHANG>(DataProvider.Intance.DataBase.KHACHHANGs.Where(x => x.IsDelete != 0));
            });
        }
    }
}
