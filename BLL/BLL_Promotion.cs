using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BLL_Promotion
    {
        private readonly DAL_Promotion _dALPromotion = new();

        public List<Promotion> GetAllPromotions()
        {
            return _dALPromotion.GetAllPromotions();
        }

        public Promotion? GetPromotionById(string id)
        {
            return _dALPromotion.GetPromotionById(id);
        }

        public void Add(Promotion promotion)
        {
            _dALPromotion.Add(promotion);
        }

        public void Remove(Promotion promotion)
        {
            _dALPromotion.Remove(promotion);
        }
    }
}
