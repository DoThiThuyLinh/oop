using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    class HoaDonKhach
    {
        private string tenkhach; // Tên khách
        private int songay; // Số ngày ở
        private Phong loaiPhong; // Loại phòng khách chọn

        public void Nhap() // Nhập thông tin hóa đơn khách hàng
        {
            Console.WriteLine("Nhập thông tin hóa đơn khách hàng");
            Console.Write("Họ tên: ");
            tenkhach = Console.ReadLine(); // Nhập họ tên khách

            Console.Write("Số ngày ở: ");
            songay = int.Parse(Console.ReadLine()); // Nhập số ngày khách ở

            Console.WriteLine("Chọn loại phòng A, B, C?");
            char ch = char.Parse(Console.ReadLine()); // Nhập loại phòng

            switch (char.ToUpper(ch))
            {
                case 'A': loaiPhong = new PhongA(songay); break; // Chọn phòng loại A
                case 'B': loaiPhong = new PhongB(songay); break; // Chọn phòng loại B
                case 'C': loaiPhong = new PhongC(songay); break; // Chọn phòng loại C
            }
        }

        public void Hien() // Hiển thị thông tin hóa đơn khách
        {
            Console.WriteLine("Thông tin hóa đơn khách hàng");
            Console.WriteLine("Họ tên khách: " + tenkhach);
            Console.WriteLine("Số ngày ở: " + songay);
            loaiPhong.Hien(); // Hiển thị thông tin phòng khách đã chọn
        }
    }

}
