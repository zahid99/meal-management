using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem.Model
{
    class DepositAmount
    {
        public int DepositId { get; set; }
        public int MemberId { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
    }
}
