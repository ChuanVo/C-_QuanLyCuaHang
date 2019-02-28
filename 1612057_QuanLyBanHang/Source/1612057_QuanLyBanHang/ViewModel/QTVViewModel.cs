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
    public class QTVViewModel : BaseViewModel
    {

        private ObservableCollection<Model.QUANTRIVIEN> _List;
        public ObservableCollection<Model.QUANTRIVIEN> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }



        // tạo selected item
        private Model.QUANTRIVIEN _SelectedItem;
        public Model.QUANTRIVIEN SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value;
                OnPropertyChanged();

                if (SelectedItem != null)
                {
                    TenDangNhap =SelectedItem.TenDangNhap;
                    TenQTV = SelectedItem.TenQTV;
                    MatKhau = SelectedItem.MatKhau;
     
                }

            }

        }

        // binding dữ liệu để show lên

        private int _ID_QUANTRIVIEN;
        public int ID_QUANTRIVIEN { get => _ID_QUANTRIVIEN; set { _ID_QUANTRIVIEN = value; OnPropertyChanged(); } }

        private string _TenDangNhap;
        public string TenDangNhap { get => _TenDangNhap; set { _TenDangNhap = value; OnPropertyChanged(); } }


        private string _MatKhau;
        public string MatKhau { get => _MatKhau; set { _MatKhau = value; OnPropertyChanged(); } }

        private string _TenQTV;
        public string TenQTV { get => _TenQTV; set { _TenQTV = value; OnPropertyChanged(); } }

        // cac command

        public ICommand AddCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }

        public QTVViewModel()
        {

            List = new ObservableCollection<Model.QUANTRIVIEN>(DataProvider.Intance.DataBase.QUANTRIVIENs.Where(x => x.IsDelete != 0)); // =0 là object được xóa

            // xử lý các command thao tác thêm, xóa sửa
            AddCommand = new RelayCommand<QUANTRIVIEN>((p_Window) =>
            {
                if (string.IsNullOrEmpty(TenDangNhap) == true || string.IsNullOrEmpty(MatKhau) == true || string.IsNullOrEmpty(TenQTV) == true)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var QTV = new Model.QUANTRIVIEN()
                {
                    TenDangNhap = TenDangNhap,
                    MatKhau = MatKhau,
                    TenQTV = TenQTV
                };

                DataProvider.Intance.DataBase.QUANTRIVIENs.Add(QTV);
                DataProvider.Intance.DataBase.SaveChanges();

                List.Add(QTV);
            });

            // edit command
            EditCommand = new RelayCommand<QUANTRIVIEN>((p_Window) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var QTV = DataProvider.Intance.DataBase.QUANTRIVIENs.Where(x => x.ID_QUANTRIVIEN == SelectedItem.ID_QUANTRIVIEN).SingleOrDefault();

                QTV.TenDangNhap = TenDangNhap;
                QTV.MatKhau = MatKhau;
                QTV.TenQTV = TenQTV;

                DataProvider.Intance.DataBase.SaveChanges();

            });

            // Delete command
            DeleteCommand = new RelayCommand<QUANTRIVIEN>((p_Window) =>
            {
                if (SelectedItem == null)
                    return false;
                return true;
            }, (p_Window) =>
            {
                var QTV = DataProvider.Intance.DataBase.QUANTRIVIENs.Where(x => x.ID_QUANTRIVIEN == SelectedItem.ID_QUANTRIVIEN).SingleOrDefault();
                QTV.IsDelete = 0;

                DataProvider.Intance.DataBase.SaveChanges();

                // load lại list sau khi cập nhật giá trị IsDelete
                List = new ObservableCollection<Model.QUANTRIVIEN>(DataProvider.Intance.DataBase.QUANTRIVIENs.Where(x => x.IsDelete != 0));
            });


        }
    }
}
