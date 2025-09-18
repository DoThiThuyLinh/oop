using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class GroceryBill
    {
        protected Employee clerk;  // Nhân viên thu ngân
        protected List<BillLine> billLines;  // Danh sách các BillLine

        // Constructor
        public GroceryBill(Employee clerk)
        {
            this.clerk = clerk;
            this.billLines = new List<BillLine>();  // Khởi tạo danh sách BillLine
        }

        // Phương thức để thêm BillLine vào danh sách hóa đơn
        public void Add(BillLine billLine)
        {
            billLines.Add(billLine);
        }

        // Phương thức tính toán tổng hóa đơn
        public virtual double GetTotal()
        {
            double total = 0;
            foreach (var billLine in billLines)
            {
                total += billLine.GetItem().GetPrice() * billLine.GetQuantity();
            }
            return total;
        }

        // Phương thức in danh sách các BillLine
        public void PrintReceipt()
        {
            Console.WriteLine("Danh sách các mặt hàng trong hóa đơn:");
            foreach (var billLine in billLines)
            {
                var item = billLine.GetItem();
                Console.WriteLine($"Mặt hàng: {item.GetPrice()} x {billLine.GetQuantity()}");
            }
        }
    }
}
