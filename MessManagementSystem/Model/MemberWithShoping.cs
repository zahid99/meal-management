using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessManagementSystem.Model
{
    class MemberWithShoping
    {
        public int ShopingId { get; set; }
        public int MemberId { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public string MemberName { get; set; }
    }
}
