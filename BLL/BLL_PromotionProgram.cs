using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_PromotionProgram
    {
        public readonly DAL_PromotionProgram dAL_PromotionProgram = new();
        
        public List<Promotion> GetAllPromotionPrograms()
        {
            return dAL_PromotionProgram.GetAllPromotionPrograms();
        }

        public Promotion? GetPromotionProgramById(string id)
        {
            var promotions = dAL_PromotionProgram.GetAllPromotionPrograms();
            return promotions.FirstOrDefault(p => p.Id == id);
        }

        // Tạo iDPromotionProgram tự động
        public string GeneratePromotionProgramId()
        {
            string prefix = "PR";
            string timeStamp1 = DateTime.Now.ToString("yyMMdd");
            string timeStamp2 = DateTime.Now.ToString("HHmmss");
            string randomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();
            string promotionProgramId = $"{prefix}{timeStamp1}PP{timeStamp2}{randomString}";
            return promotionProgramId.Length > 20 ? promotionProgramId.Substring(0, 20) : promotionProgramId;
        }

        public void Add(PromotionProgram promotionProgram)
        {
            if (string.IsNullOrEmpty(promotionProgram.Promotion.PromotionName))
                throw new ArgumentException("Tên chương trình khuyến mãi không được để trống!");
            if (promotionProgram.StartDate == null)
                throw new ArgumentException("Ngày bắt đầu không được để trống!");
            if (promotionProgram.Category == null || string.IsNullOrEmpty(promotionProgram.Category.Name))
                throw new ArgumentException("Danh mục không được để trống!");
            dAL_PromotionProgram.Add(promotionProgram);
        }

        public void Update(PromotionProgram promotionProgram)
        {
            dAL_PromotionProgram.Update(promotionProgram);
        }

        public void Delete(string id)
        {
            dAL_PromotionProgram.Delete(id);
        }
    }
}
