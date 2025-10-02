using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    abstract class Phong
    {
        protected int songay; // Số ngày khách ở

        public Phong(int songay)
        {
            this.songay = songay; // Khởi tạo số ngày khách ở
        }

        public abstract double TinhTien(); // Phương thức tính tiền phòng
        public abstract void Hien(); // Phương thức hiển thị thông tin phòng
    }
}
