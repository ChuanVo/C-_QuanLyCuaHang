//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1612057_QuanLyBanHang.Model
{
    using _1612057_QuanLyBanHang.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class QUANTRIVIEN : BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QUANTRIVIEN()
        {
            this.DONHANGs = new HashSet<DONHANG>();
        }

        int _ID_QUANTRIVIEN;
        public int ID_QUANTRIVIEN { get => _ID_QUANTRIVIEN; set { _ID_QUANTRIVIEN = value; OnPropertyChanged(); } }

        string _TenDangNhap;
        public string TenDangNhap { get => _TenDangNhap; set { _TenDangNhap = value; OnPropertyChanged(); } }

        string _MatKhau;
        public string MatKhau { get => _MatKhau; set { _MatKhau = value; OnPropertyChanged(); } }

        string _TenQTV;
        public string TenQTV { get => _TenQTV; set { _TenQTV = value; OnPropertyChanged(); } }

        Nullable<int> _IsDelete;
        public Nullable<int> IsDelete { get => _IsDelete; set { _IsDelete = value; OnPropertyChanged(); } }

        Nullable<int> _Quyen;
        public Nullable<int> Quyen { get => _Quyen; set { _Quyen = value; OnPropertyChanged(); } }

        //public int ID_QUANTRIVIEN { get; set; }
        //public string TenDangNhap { get; set; }
        //public string MatKhau { get; set; }
        //public string TenQTV { get; set; }
        //public Nullable<int> IsDelete { get; set; }
        //public Nullable<int> Quyen { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<DONHANG> DONHANGs { get; set; }

         ICollection<DONHANG> _DONHANGs;
        public virtual ICollection<DONHANG> DONHANGs { get => _DONHANGs; set { _DONHANGs = value; OnPropertyChanged(); } }
    }
}
