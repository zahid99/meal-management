using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessManagementSystem.Gateway;
using MessManagementSystem.Model;

namespace MessManagementSystem.Manager
{
    class MemberManager
    {
        private MemberGateway aMemberGateway=new MemberGateway();
        public string SaveMember(Member member)
        {
            bool isExist = aMemberGateway.IsExistMembers(member);
            if (isExist)
            {
                return "Email OR Phone Already Exists";
            }
            
                int rowAffected=aMemberGateway.SaveMember(member);

            if (rowAffected > 0)
            {
                return "Save Member";
            }

            return "Failed to Save Member Date";
        }

        public List<Member> GetMembers()
        {
            return aMemberGateway.GetMembers();
        }

        public string UpdateMember(Member member)
        {
            //bool isExist = aMemberGateway.IsExistMembers(member);
            //if (isExist)
            //{
            //    return "Email OR Phone Already Exists";
            //}

            int rowAffected = aMemberGateway.UpdateMember(member);
            if (rowAffected > 0)
            {
                return "Update Member Information";
            }
            return "Failed to Update";
        }

        public string RemoveMember(int memberId)
        {
            int rowaffected=aMemberGateway.RemoveMember(memberId);
            if (rowaffected > 0)
            {
                return "Remove Successfully";
            }
            return "Failed to remove";
        }
    }
}
