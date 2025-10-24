using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BLL_PromotionVoucher
    {
        private readonly DAL_PromotionVoucher _dalPromotionVoucher = new();

        public List<Promotion> GetAllPromotionVouchers()
        {
            return _dalPromotionVoucher.GetAllPromotionVoucher();
        }
        public PromotionVoucher? GetPromotionVoucherById(string promotionId, string customerId)
        {
            return _dalPromotionVoucher.GetPromotionVoucherById(promotionId, customerId);
        }

        public void AddProVoucher(PromotionVoucher promotionVoucher)
        {
            _dalPromotionVoucher.Add(promotionVoucher);
        }

        public void UpdateProVoucher(PromotionVoucher promotionVoucher)
        {
            _dalPromotionVoucher.Update(promotionVoucher);
        }

        public void DeleteProVoucher(string id)
        {
            _dalPromotionVoucher.Delete(id);
        }

        //Tạo id tự động
        public string GenerateProVoucherId(string id)
        {
            string prefix = "PV";
            string daysTamp = DateTime.Now.ToString("yyMMdd");
            string shortType;

            switch (id)
            {
                case "Phần trăm":
                    shortType = "PT";
                    break;
                case "Tiền":
                    shortType = "TN";
                    break;
                case "Mua x tặng y":
                    shortType = "XY";
                    break;
                default:
                    shortType = "XX";
                        break;
            }
            string timesTamp = DateTime.Now.ToString("HHmmss");
            string ranDomString = Guid.NewGuid().ToString("N").Substring(0, 4).ToUpper();

            string proVoucherId = $"{prefix}{daysTamp}{shortType}{timesTamp}{ranDomString}";
            return proVoucherId.Length > 20 ? proVoucherId.Substring(0, 20) : proVoucherId;
        }
    }
}
