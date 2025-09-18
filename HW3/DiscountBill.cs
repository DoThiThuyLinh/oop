using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class DiscountBill : GroceryBill
    {
        private bool isPriorityCustomer;

        // Constructor
        public DiscountBill(Employee clerk, bool isPriorityCustomer) : base(clerk)
        {
            this.isPriorityCustomer = isPriorityCustomer;
        }

        // Override phương thức GetTotal để tính toán giảm giá cho khách hàng ưu tiên
        public override double GetTotal()
        {
            double total = 0;
            double totalDiscount = 0;
            int discountedItemCount = 0;

            foreach (var billLine in billLines)  // Duyệt qua các BillLine trong danh sách billLines
            {
                var item = billLine.GetItem();
                double price = item.GetPrice();
                double discount = item.GetDiscount();

                if (isPriorityCustomer && discount > 0)
                {
                    totalDiscount += discount * billLine.GetQuantity();
                    discountedItemCount++;
                    price -= discount;  // Áp dụng mức giảm giá cho mặt hàng
                }

                total += price * billLine.GetQuantity();  // Cộng dồn giá sau giảm giá
            }

            // In thông tin giảm giá
            Console.WriteLine($"Số mặt hàng được giảm giá: {discountedItemCount}");
            Console.WriteLine($"Tổng số tiền giảm giá: ${totalDiscount}");
            Console.WriteLine($"Phần trăm giảm giá: {CalculateDiscountPercent(totalDiscount)}%");

            return total;
        }

        // Phương thức tính toán phần trăm giảm giá so với tổng số tiền nếu không có giảm giá
        public double CalculateDiscountPercent(double totalDiscount)
        {
            double originalTotal = 0;

            foreach (var billLine in billLines)
            {
                var item = billLine.GetItem();
                originalTotal += item.GetPrice() * billLine.GetQuantity();
            }

            return (totalDiscount / originalTotal) * 100;
        }

        // Các phương thức trả về số lượng mặt hàng giảm giá và tổng số tiền giảm giá
        public int GetDiscountCount()
        {
            int count = 0;
            foreach (var billLine in billLines)  // Duyệt qua billLines
            {
                if (billLine.GetItem().GetDiscount() > 0)
                {
                    count++;
                }
            }
            return count;
        }

        public double GetDiscountAmount()
        {
            double totalDiscount = 0;
            foreach (var billLine in billLines)  // Duyệt qua billLines
            {
                var item = billLine.GetItem();
                if (item.GetDiscount() > 0)
                {
                    totalDiscount += item.GetDiscount() * billLine.GetQuantity();
                }
            }
            return totalDiscount;
        }
    }
}
