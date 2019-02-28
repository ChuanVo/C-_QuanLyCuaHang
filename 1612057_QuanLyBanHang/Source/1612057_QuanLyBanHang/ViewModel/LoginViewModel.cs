using _1612057_QuanLyBanHang.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace _1612057_QuanLyBanHang.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        public bool IsLogin { get; set; }

        // _ để chỉ thuộc tính private
        private string _UserName;
        public string UserName {
            get => _UserName;
            set {
                _UserName = value;
                OnPropertyChanged();
            }
        }

        private string _Password;
        public string Password {
            get => _Password;
            set {
                _Password = value;
                OnPropertyChanged();
            }
        }


        public ICommand LoginCommand { get; set; }
        public ICommand CloseCommand { get; set; }
        public ICommand PasswordChangeCommand { get; set; }

        // các thao tác xử lí
        public LoginViewModel()
        {
            IsLogin = false;
            LoginCommand = new RelayCommand<Window>((p_Window) => { return true; }, (p_Window) => { Login(p_Window);  });
            CloseCommand = new RelayCommand<Window>((p_Window) => { return true; }, (p_Window) => { Close(p_Window); });
            PasswordChangeCommand = new RelayCommand<PasswordBox>((p_Window) => { return true; }, (p_Window) => { Password = p_Window.Password; });
        }


        // hàm xử lí login
        void Login(Window wd)
        {
            if(wd == null)
            {
                return;
            }
            else
            {
                // dùng LINKQ để truy vấn
                var i = DataProvider.Intance.DataBase.QUANTRIVIENs.Where(qTriVien => UserName == qTriVien.TenDangNhap && Password == qTriVien.MatKhau).Count();

                if(i == 0)
                {
                    IsLogin = false;
                    MessageBox.Show("Tài Khoản hoặc mật khẩu không chính xác!","Thông báo");
                }
                else
                {
                    wd.Close();
                    IsLogin = true;
                }
               
            }
        }

        // hàm xử lí khi thoát
        void Close(Window wd)
        {
            if(wd == null)
            {
                return;
            }
            else
            {
                wd.Close();
            }
        }
    }
}
