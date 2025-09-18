using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Item
    {
        private double price;  // Giá
        private double discount;  // Giảm giá

        // Constructor
        public Item(double price, double discount)
        {
            this.price = price;
            this.discount = discount;
        }

        // Phương thức trả về giá của mặt hàng
        public double GetPrice()
        {
            return price;
        }

        // Phương thức trả về mức giảm giá của mặt hàng
        public double GetDiscount()
        {
            return discount;
        }
    }
}
