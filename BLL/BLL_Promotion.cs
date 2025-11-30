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

        public Promotion? GetPromotionById(string promotionId)
        {
            return _dALPromotion.GetPromotionById(promotionId);
        }

        public void Add(Promotion promotion)
        {
            _dALPromotion.Add(promotion);
        }

        public void Remove(string id)
        {
            _dALPromotion.Remove(id);
        }

        public void Update(Promotion promotion)
        {
            _dALPromotion.Update(promotion);
        }
    }
}
