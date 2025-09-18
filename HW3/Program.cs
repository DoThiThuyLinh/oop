using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập tên nhân viên thu ngân
            Console.Write("Nhập tên nhân viên thu ngân: ");
            string clerkName = Console.ReadLine();
            Employee clerk = new Employee(clerkName);

            // Nhập thông tin khách hàng ưu tiên
            Console.Write("Khách hàng có ưu tiên không (y/n)? ");
            bool isPriorityCustomer = Console.ReadLine().ToLower() == "y";

            // Tạo hóa đơn giảm giá
            DiscountBill discountBill = new DiscountBill(clerk, isPriorityCustomer);

            // Nhập số lượng mặt hàng và giảm giá
            while (true)
            {
                Console.WriteLine("Nhập thông tin mặt hàng:");
                Console.Write("Giá mặt hàng: ");
                double price = double.Parse(Console.ReadLine());

                Console.Write("Giảm giá mặt hàng: ");
                double discount = double.Parse(Console.ReadLine());

                Item item = new Item(price, discount);

                BillLine billLine = new BillLine(item);

                Console.Write("Số lượng: ");
                int quantity = int.Parse(Console.ReadLine());
                billLine.SetQuantity(quantity);

                // Thêm BillLine vào DiscountBill
                discountBill.Add(billLine);

                Console.Write("Tiếp tục nhập (y/n)? ");
                if (Console.ReadLine().ToLower() != "y") break;
            }

            // In chi tiết hóa đơn
            discountBill.PrintReceipt();
            Console.WriteLine($"Tổng cộng với giảm giá: ${discountBill.GetTotal()}");
            Console.WriteLine($"Số lượng mặt hàng giảm giá: {discountBill.GetDiscountCount()}");
            Console.WriteLine($"Tổng số tiền giảm giá: ${discountBill.GetDiscountAmount()}");
            Console.WriteLine($"Phần trăm giảm giá: {discountBill.CalculateDiscountPercent(discountBill.GetDiscountAmount())}%");

            Console.ReadLine();
        }
    }
}

