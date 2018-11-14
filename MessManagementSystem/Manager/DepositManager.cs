using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessManagementSystem.Gateway;
using MessManagementSystem.Model;

namespace MessManagementSystem.Manager
{
    class DepositManager
    {
        private DepositGateway aDepositGateway=new DepositGateway();
        public string SaveDeposit(DepositAmount deposit)
        {
            bool isExist = aDepositGateway.IsExistDeposit(deposit);
            if (isExist)
            {
                return "Alreasdy Added";
            }

            int rowAffected = aDepositGateway.SaveDepositAmount(deposit);

            if (rowAffected > 0)
            {
                return "Save Deposit Amount";
            }
            return "Failed to Save";
        }

        public List<MemberWithDeposit> GetMemberWithDepositList(string date)
        {
            

            return aDepositGateway.GetDepositAmountList(date);
        }

        public List<MemberWithDeposit> GetMemberWithDepositAmountGroupByName(string date)
        {


            return aDepositGateway.GetDepositAmountList(date);
        }

        public string UpdateDepositAmount(DepositAmount deposit)
        {
            int rowAffected = aDepositGateway.UpdateDepositAmount(deposit);
            if (rowAffected > 0)
            {
                return "Update Deposit Amount";
            }
            return "Failed";
        }

        public List<MemberWithDeposit> MemberdDeposits(int memberId,string date)
        {
            return aDepositGateway.GetDepositAmountById(memberId,date);
        } 
    }
}
