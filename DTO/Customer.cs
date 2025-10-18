using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Customer
{
    public string Id { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public decimal? Point { get; set; }

    public int? Drips { get; set; }

    public string? Tier { get; set; }

    public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();

    public virtual ICollection<PromotionVoucher> PromotionVouchers { get; set; } = new List<PromotionVoucher>();
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Customer
    {
        private string _id, _name, _email, _phone, _tier;
        private decimal _point;
        private int _drips;

        public Customer(string id, string name, string email, string phone, string tier, decimal point, int drips)
        {
            Id = id;
            Name = name;
            Email = email;
            Phone = phone;
            Tier = tier;
            Point = point;
            Drips = drips;
        }

        public string Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string Email { get => _email; set => _email = value; }
        public string Phone { get => _phone; set => _phone = value; }
        public string Tier { get => _tier; set => _tier = value; }
        public decimal Point { get => _point; set => _point = value; }
        public int Drips { get => _drips; set => _drips = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
