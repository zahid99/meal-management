using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessManagementSystem.Gateway;
using MessManagementSystem.Model;

namespace MessManagementSystem.Manager
{
    class ShopingManager
    {
        private ShopingGateway aShopingGateway=new ShopingGateway();
        public string SaveShopingCost(ShopingModel shoping)
        {
            bool isExist = aShopingGateway.IsExistShoping(shoping);

            if (isExist)
            {
                return "Already Cost Added";
            }

            int rowAffected = aShopingGateway.SaveShopingCost(shoping);
            if (rowAffected > 0)
            {
                return "Save Shoping Cost";
            }
            return "Failed to Add";
        }

        public List<MemberWithShoping> GetShopingList(string date)
        {
            return aShopingGateway.GetShopingList(date);
        }


        public string RemoveShiopingCost(int memberId, string date)
        {

            int rowAffected = aShopingGateway.RemoveShopingCost(memberId, date);

            if (rowAffected>0)
            {
                return "Remove Shoping Cost";
            }

            return "failed";
        }
    }
}
