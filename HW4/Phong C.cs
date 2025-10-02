using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    class PhongC : Phong
    {
        public PhongC(int songay) : base(songay) { }

        public override double TinhTien() // Tính tiền phòng loại C
        {
            return songay * 40; // Tính tiền cho phòng loại C
        }

        public override void Hien() // Hiển thị thông tin phòng
        {
            Console.WriteLine("Dịch vụ phòng C");
            Console.WriteLine("Tiền phòng: " + TinhTien());
        }
    }
}
