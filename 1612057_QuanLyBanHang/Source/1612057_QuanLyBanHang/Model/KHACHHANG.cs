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
    
    public partial class KHACHHANG: BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHACHHANG()
        {
            this.DONHANGs = new HashSet<DONHANG>();
        }

        int _ID_KHACHHANG;
        public int ID_KHACHHANG { get => _ID_KHACHHANG; set { _ID_KHACHHANG = value; OnPropertyChanged(); } }

        string _SDT;
        public string SDT { get => _SDT; set { _SDT = value; OnPropertyChanged(); } }

        string _TenKhachHang;
        public string TenKhachHang { get => _TenKhachHang; set { _TenKhachHang = value; OnPropertyChanged(); } }

        string _DiaChi;
        public string DiaChi { get => _DiaChi; set { _DiaChi = value; OnPropertyChanged(); } }

        Nullable<int> _IsDelete;
        public Nullable<int> IsDelete { get => _IsDelete; set { _IsDelete = value; OnPropertyChanged(); } }

        //public int ID_KHACHHANG { get; set; }
        //public string SDT { get; set; }
        //public string TenKhachHang { get; set; }
        //public string DiaChi { get; set; }
        //public Nullable<int> IsDelete { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        // public virtual ICollection<DONHANG> DONHANGs { get; set; }

        ICollection<DONHANG> _DONHANGs;
        public virtual ICollection<DONHANG> DONHANGs { get => _DONHANGs; set { _DONHANGs = value; OnPropertyChanged(); } }
    }
}
