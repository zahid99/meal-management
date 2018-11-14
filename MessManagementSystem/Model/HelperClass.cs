using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem.Model
{
    class HelperClass
    {
        public string  GetCurrentMonthAsNumber()
        {
            return DateTime.Now.Month.ToString();;
        }

        public string CurrentMonthAsString()
        {
            return String.Format("{0:MMMM}", DateTime.Now).ToString();
        }

        public int GetCurrentDate()
        {
            return DateTime.Now.Day;
        }
    }
}
