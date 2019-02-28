using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1612057_QuanLyBanHang.Model
{
    public class DataProvider
    {

        // dùng mẫu thiết kế singleton để đảm bảo việc tạo Dataprovider chỉ diễn ra 1 lần trong chương trình
        private static DataProvider intance;
        public static DataProvider Intance
        {
            get
            {
                if (intance == null)
                    intance = new DataProvider();
                return intance;
            }
            set
            {
                intance = value;
            }
        }

        public QuanLyEntities1 DataBase { get; set; }

        private DataProvider()
        {
            DataBase = new QuanLyEntities1();
        }
    }
}
