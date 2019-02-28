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
    public class StatisticViewModel : BaseViewModel
    {

        private ObservableCollection<Model.SANPHAM> _List;
        public ObservableCollection<Model.SANPHAM> List
        {
            get => _List; set { _List = value; OnPropertyChanged(); }

        }

        // binding

        private string _DoanhThu;
        public string DoanhThu {
            get {
                var doanhThu = DataProvider.Intance.DataBase.DONHANGs.Sum(x => x.TongTien);
                return doanhThu.ToString() + " đồng";
            }
            set { _DoanhThu = value; OnPropertyChanged(); } }


        private string _LoiNhuan;
        public string LoiNhuan
        {
            get
            {
                var von = DataProvider.Intance.DataBase.SANPHAMs.Sum(x=>x.SoLuotMua*x.GiaNhap);
                var doanhThu = DataProvider.Intance.DataBase.DONHANGs.Sum(x => x.TongTien);
                return (doanhThu - von).ToString() + " đồng";
            }
            set { _LoiNhuan = value; OnPropertyChanged(); }
        }

        private string _SPBanChay;
        public string SPBanChay
        {
            get
            {
                var spBanChay = DataProvider.Intance.DataBase.SANPHAMs.OrderByDescending(x => x.SoLuotMua).First();
                return spBanChay.TenSanPham + " - " + spBanChay.SoLuotMua.ToString() +" cái." ;
            }
            set { _SPBanChay = value; OnPropertyChanged(); }
        }

        private string _SPBanIt;
        public string SPBanIt
        {
            get
            {
                var spBanIt = DataProvider.Intance.DataBase.SANPHAMs.OrderBy(x => x.SoLuotMua).First();
                return spBanIt.TenSanPham +" - " + spBanIt.SoLuotMua.ToString() + " cái.";
            }
            set { _SPBanIt = value; OnPropertyChanged(); }
        }

        // các command xử lý
        public ICommand DoanhThuCommand { get; set; }
        public ICommand LoiNhuanCommand { get; set; }
        public ICommand BanChayNhatCommand { get; set; }
        public ICommand BanItNHatCommand { get; set; }



        public StatisticViewModel()
        {

            List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0)); // =0 là object được xóa

            
            DoanhThuCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderBy(x => x.TenSanPham));
            });

            BanChayNhatCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderByDescending(x => x.GiaTien));
            });

            BanItNHatCommand = new RelayCommand<SANPHAM>((p_Window) => { return true; }, (p_Window) => {
                List = new ObservableCollection<Model.SANPHAM>(DataProvider.Intance.DataBase.SANPHAMs.Where(x => x.IsDelete != 0).OrderBy(x => x.ID_LoaiSanPham));
            });

          
        }
    }
}
