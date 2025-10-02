using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    class PhongA : Phong
    {
        protected int tiendv; // Tiền dịch vụ

        public PhongA(int songay) : base(songay)
        {
            Console.WriteLine("Nhập tiền dịch vụ:");
            tiendv = int.Parse(Console.ReadLine()); // Nhập tiền dịch vụ
        }

        public override double TinhTien() // Tính tiền phòng
        {
            if (songay < 5)
                return songay * 80 + tiendv; // Tính tiền cho phòng loại A nếu ở dưới 5 ngày
            else
                return 5 * 80 + (songay - 5) * 80 * 0.9 + tiendv; // Tính tiền cho phòng loại A nếu ở trên 5 ngày
        }

        public override void Hien() // Hiển thị thông tin phòng
        {
            Console.WriteLine("Dịch vụ phòng A");
            Console.WriteLine("Tiền dịch vụ: " + tiendv);
            Console.WriteLine("Tiền phòng: " + TinhTien());
        }
    }
}
