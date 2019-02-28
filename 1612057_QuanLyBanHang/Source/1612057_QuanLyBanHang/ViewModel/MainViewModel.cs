using _1612057_QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace _1612057_QuanLyBanHang.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public bool Isloaded = false;
        public ICommand LoadedWindowCommand { get; set; }
        public ICommand SellCommand { get; set; }
        public ICommand BillCommand { get; set; }
        public ICommand StatisticCommand { get; set; }
        public ICommand RegisterCommand { get; set; }

        public ICommand ShopCommand { get; set; }

        public ICommand InputCommand { get; set; }

        public ICommand QTVCommand { get; set; }

        // các xử lí của mainviewmodel
        public MainViewModel()
        {
            // ẩn mainWindow trước khi thực hiện đăng nhập - sử dụng truyền parameter p_Window
            LoadedWindowCommand = new RelayCommand<Window>((p_Window) => { return true; }, (p_Window) => {

                if (p_Window == null)
                {
                    return;
                }
                else
                {

                    p_Window.Hide();
                    Isloaded = true;
                    LoginWindow loginWindow = new LoginWindow();
                    loginWindow.ShowDialog();
                  
                    // dùng datacontext để lấy biến islogin bên LoginViewModel
                    if (loginWindow.DataContext == null)
                        return;

                    var login = loginWindow.DataContext as LoginViewModel;

                    if (login.IsLogin == true)
                        p_Window.Show();
                    else
                        p_Window.Close();

                }
            });

            // các comment
            SellCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { SellWindow wd = new SellWindow(); wd.ShowDialog(); });
            BillCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { BillWindow wd = new BillWindow(); wd.ShowDialog(); });
            RegisterCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { RegisterWindow wd = new RegisterWindow(); wd.ShowDialog(); });

            // những chức năng chỉ người chủ mới được thực hiện
            StatisticCommand = new RelayCommand<object>((p_Window) => {return true;}, (p_Window) => { StatisticWindow wd = new StatisticWindow(); wd.ShowDialog(); });
            InputCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { InputWindow wd = new InputWindow(); wd.ShowDialog(); });

            ShopCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { ShopWindow wd = new ShopWindow(); wd.ShowDialog(); });
            QTVCommand = new RelayCommand<object>((p_Window) => { return true; }, (p_Window) => { QTVWindow wd = new QTVWindow(); wd.ShowDialog(); });


        }
    }
}
