using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillInfo
    {
        private int _id, _quantity;
        private string _productId, _billId;

        public BillInfo(int id, int quantity, string productId, string billId)
        {
            Id = id;
            Quantity = quantity;
            ProductId = productId;
            BillId = billId;
        }

        public int Id { get => _id; set => _id = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string ProductId { get => _productId; set => _productId = value; }
        public string BillId { get => _billId; set => _billId = value; }
    }
}
