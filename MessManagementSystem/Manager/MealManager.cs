using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessManagementSystem.Gateway;
using MessManagementSystem.Model;

namespace MessManagementSystem.Manager
{
    class MealManager
    {
        private MealGateway aMealGateway=new MealGateway();


        public string SaveMeal(Meal meal)
        {
            bool isExist = aMealGateway.IsExistDailyMeal(meal);

            if (isExist)
            {
                return "Already Added Meal";
            }

            int rowAffected = aMealGateway.SaveMeal(meal);
            if (rowAffected > 0)
            {
                return "Save Meal Successfully";
            }
            return "Failed";
        }

        public List<MemberWithMeal> GetMeals(int memberId,string date)
        {
            return aMealGateway.GetMeal(memberId,date);
        }


        public List<Meal> GetMealList()
        {
            return aMealGateway.GetMealList();
        }


        public List<MemberWithMeal> GetMealListThreeDay(int currentDate,int previousdate,string date)
        {
            return aMealGateway.GetMealThreeDays(currentDate,previousdate,date);
        }


        public string RemoveMeal(int memberId,string date)
        {
            int rowAffected = aMealGateway.Remove(memberId, date);

            if (rowAffected > 0)
            {
                return "Delete Successfully";
            }
            return "Failed to delete";
        }

    }
}
