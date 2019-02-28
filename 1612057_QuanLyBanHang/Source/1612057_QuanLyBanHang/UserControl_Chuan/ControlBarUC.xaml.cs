using _1612057_QuanLyBanHang.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _1612057_QuanLyBanHang.UserControl_Chuan
{
    /// <summary>
    /// Interaction logic for ControlBarUC.xaml
    /// </summary>
     public partial class ControlBarUC : UserControl
    {
        public ControlBarViewModel Viewmodel { get; set; }

        public ControlBarUC()
        {
            InitializeComponent();
            this.DataContext = Viewmodel = new ControlBarViewModel();
        }
    }
}
