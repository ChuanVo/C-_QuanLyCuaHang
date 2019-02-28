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
    public class ShopViewModel : BaseViewModel
    {

        private ObservableCollection<Model.SANPHAM> _List;
        public ObservableCollection<Model.SANPHAM> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }

        // các command xử lý
        public ICommand NameCommand { get; set; }
        public ICommand PriceCommand { get; set; }
        public ICommand CategoryCommand { get; set; }
        public ICommand SLMuaCommand { get; set; }
        public ICommand SLConCommand { get; set; }


        public ShopViewModel()
        {

            List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0)); // =0 là object được xóa


            NameCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderBy(x => x.TenSanPham));
            });

            PriceCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderByDescending(x => x.GiaTien));
            });

            CategoryCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderBy(x => x.ID_LoaiSanPham));
            });

            SLMuaCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderByDescending(x => x.SoLuotMua));
            });

            SLConCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderByDescending(x => x.SoLuongCon));
            });
        }
    }
}
