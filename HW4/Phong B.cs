using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    class PhongB : Phong
    {
        public PhongB(int songay) : base(songay) { }

        public override double TinhTien() // Tính tiền phòng loại B
        {
            if (songay < 5)
                return songay * 60; // Tính tiền cho phòng loại B nếu ở dưới 5 ngày
            else
                return 5 * 60 + (songay - 5) * 60 * 0.9; // Tính tiền cho phòng loại B nếu ở trên 5 ngày
        }

        public override void Hien() // Hiển thị thông tin phòng
        {
            Console.WriteLine("Dịch vụ phòng B");
            Console.WriteLine("Tiền phòng: " + TinhTien());
        }
    }
}
