using System;
using System.Collections.Generic;
<<<<<<< HEAD

namespace DTO;

public partial class Financial
{
    public string ReportId { get; set; } = null!;

    public string? BranchId { get; set; }

    public int ReportMonth { get; set; }

    public int ReportYear { get; set; }

    public decimal? TotalRevenue { get; set; }

    public decimal? IngredientCost { get; set; }

    public decimal? SalaryCost { get; set; }

    public decimal? ElectricityCost { get; set; }

    public decimal? WaterCost { get; set; }

    public decimal? RentCost { get; set; }

    public decimal? OtherCost { get; set; }

    public virtual Branch? Branch { get; set; }
=======
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Financial
    {
        private string _id, _branchId;
        private int _reportMonth, _reportYear;
        private decimal _totalRevenue, _ingredientCost, _salaryCost, _electricityCost, _waterCost, _rentCost, _otherCost;

        public Financial(string id, string branchId, int reportMonth, int reportYear, decimal totalRevenue, decimal ingredientCost, decimal salaryCost, decimal electricityCost, decimal waterCost, decimal rentCost, decimal otherCost)
        {
            Id = id;
            BranchId = branchId;
            ReportMonth = reportMonth;
            ReportYear = reportYear;
            TotalRevenue = totalRevenue;
            IngredientCost = ingredientCost;
            SalaryCost = salaryCost;
            ElectricityCost = electricityCost;
            WaterCost = waterCost;
            RentCost = rentCost;
            OtherCost = otherCost;
        }

        public string Id { get => _id; set => _id = value; }
        public string BranchId { get => _branchId; set => _branchId = value; }
        public int ReportMonth { get => _reportMonth; set => _reportMonth = value; }
        public int ReportYear { get => _reportYear; set => _reportYear = value; }
        public decimal TotalRevenue { get => _totalRevenue; set => _totalRevenue = value; }
        public decimal IngredientCost { get => _ingredientCost; set => _ingredientCost = value; }
        public decimal SalaryCost { get => _salaryCost; set => _salaryCost = value; }
        public decimal ElectricityCost { get => _electricityCost; set => _electricityCost = value; }
        public decimal WaterCost { get => _waterCost; set => _waterCost = value; }
        public decimal RentCost { get => _rentCost; set => _rentCost = value; }
        public decimal OtherCost { get => _otherCost; set => _otherCost = value; }
    }
>>>>>>> 83123dc36fc68215d5c8afabd4a18c9e4fd75428
}
