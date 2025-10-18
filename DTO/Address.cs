using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Address
{
    public string Id { get; set; } = null!;

    public string? Address1 { get; set; }

    public string? WardId { get; set; }

    public virtual ICollection<Branch> Branches { get; set; } = new List<Branch>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();

    public virtual ICollection<Supplier> Suppliers { get; set; } = new List<Supplier>();

    public virtual Ward? Ward { get; set; }
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Address
    {
        private int _id, _idWard;
        private string _addressName;

        public Address(int id, string address, int idWard)
        {
            Id = id;
            WardId = idWard;
            AddressName = address;
        }

        public int Id { get => _id; set => _id = value; }
        public int WardId { get => _idWard; set => _idWard = value; }
        public string AddressName { get => _addressName; set => _addressName = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
