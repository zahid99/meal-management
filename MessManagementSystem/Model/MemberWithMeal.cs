using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem.Model
{
    class MemberWithMeal
    {
        public int MealId { get; set; }
        public int MemberId { get; set; }
        public DateTime Date { get; set; }
        public double TotalMeal { get; set; }
        public string MemberName { get; set; }
    }
}
