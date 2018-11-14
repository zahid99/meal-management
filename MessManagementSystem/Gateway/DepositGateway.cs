using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessManagementSystem.Model;

namespace MessManagementSystem.Gateway
{
    class DepositGateway{

        private string connectionString = ConfigurationManager.ConnectionStrings["MessString"].ConnectionString;
        private string query;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public int SaveDepositAmount(DepositAmount deposit)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = "insert into Deposit (MemberId,Date,Amount) values (@MemberId,@Date,@Amount)";
                command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("MemberId", deposit.MemberId);
                command.Parameters.AddWithValue("Date", deposit.Date);
                command.Parameters.AddWithValue("Amount", deposit.Amount);
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }

        public bool IsExistDeposit(DepositAmount deposit)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Deposit WHERE MemberId=@MemberId AND Date=@Date";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("MemberId", deposit.MemberId);
            command.Parameters.AddWithValue("Date", deposit.Date);
            reader = command.ExecuteReader();

            bool rowAffected = reader.HasRows;

            reader.Close();
            connection.Close();
            return rowAffected;
        }

        public List<MemberWithDeposit> GetDepositAmountList(string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query =
                "select * from deposit join Members on Deposit.MemberId=Members.MemberId where MONTH(date)='"+date+"' order by Members.Name";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            List<MemberWithDeposit> depositList = new List<MemberWithDeposit>();

            while (reader.Read())
            {
                MemberWithDeposit memberWithDeposit = new MemberWithDeposit();
                memberWithDeposit.DepositId = (int)reader["DepositId"];
                memberWithDeposit.Amount = (int)reader["Amount"];
                memberWithDeposit.Date = (DateTime)reader["Date"];
                memberWithDeposit.MemberId = (int)reader["MemberId"];
                memberWithDeposit.MemberName = (string)reader["Name"];

                depositList.Add(memberWithDeposit);
            }

            reader.Close();
            connection.Close();
            return depositList;

        }



        public List<MemberWithDeposit> GetDepositAmountGroupByName(string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query =
                "select Members.Name,sum(Deposit.Amount)  from Members left join Deposit on Members.MemberId=Deposit.MemberId where MONTH(Deposit.date)='"+date+"' group by Members.Name";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            List<MemberWithDeposit> depositList = new List<MemberWithDeposit>();

            while (reader.Read())
            {
                MemberWithDeposit memberWithDeposit = new MemberWithDeposit();
                
                memberWithDeposit.Amount = (int)reader["Amount"];              
                memberWithDeposit.MemberName = (string)reader["Name"];
                depositList.Add(memberWithDeposit);
            }

            reader.Close();
            connection.Close();
            return depositList;

        }

        public int UpdateDepositAmount(DepositAmount deposit)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = "UPDATE Deposit SET Amount=@Amount WHERE MemberId=@MemberId AND Date=@Date";
                command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("MemberId", deposit.MemberId);
                command.Parameters.AddWithValue("Date", deposit.Date);
                command.Parameters.AddWithValue("Amount", deposit.Amount);
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                throw;
            }

            finally
            {
                connection.Close();
            }
        }


        public List<MemberWithDeposit> GetDepositAmountById(int memberId,string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query =
                "select * from deposit WHERE MemberId='" + memberId + "' AND MONTH(Deposit.date)='" + date + "' ORDER BY Date";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();
            List<MemberWithDeposit> depositList = new List<MemberWithDeposit>();

            while (reader.Read())
            {
                MemberWithDeposit memberWithDeposit = new MemberWithDeposit();
                memberWithDeposit.DepositId = (int)reader["DepositId"];
                memberWithDeposit.Amount = (int)reader["Amount"];
                memberWithDeposit.Date = (DateTime)reader["Date"];
                memberWithDeposit.MemberId = (int)reader["MemberId"];
                

                depositList.Add(memberWithDeposit);
            }

            reader.Close();
            connection.Close();
            return depositList;

        }
    }
}
