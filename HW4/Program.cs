using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quản_lý_khách_sạn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            HoaDonKhach t = new HoaDonKhach(); // Tạo đối tượng HoaDonKhach
            t.Nhap(); // Nhập thông tin khách
            Console.Clear(); // Làm sạch màn hình
            t.Hien(); // Hiển thị hóa đơn
            Console.ReadLine(); // Dừng màn hình để xem kết quả

            Console.ReadKey();
        }
    }
}
