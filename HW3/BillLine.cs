using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class BillLine
    {
        private Item item;  // Mặt hàng
        private int quantity;  // Số lượng mặt hàng

        // Constructor
        public BillLine(Item item)
        {
            this.item = item;
            this.quantity = 1; // Mặc định số lượng là 1
        }

        // Phương thức để đặt số lượng mặt hàng
        public void SetQuantity(int quantity)
        {
            this.quantity = quantity;
        }

        // Phương thức để lấy số lượng mặt hàng
        public int GetQuantity()
        {
            return quantity;
        }

        // Phương thức để đặt mặt hàng cho BillLine
        public void SetItem(Item item)
        {
            this.item = item;
        }

        // Phương thức để lấy mặt hàng của BillLine
        public Item GetItem()
        {
            return item;
        }
    }
}
