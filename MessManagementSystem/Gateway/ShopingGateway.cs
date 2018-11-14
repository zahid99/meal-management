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
    class ShopingGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MessString"].ConnectionString;
        private string query;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public int SaveShopingCost(ShopingModel shoping)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = "insert into Shoping (MemberId,Date,Cost) values (@MemberId,@Date,@Cost)";
                //query = "insert into Members (Name,Email,Phone) values ('"+member.MemberName+"','"+member.Email+"','"+member.Phone+"')";
                command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("MemberId", shoping.MemberId);
                command.Parameters.AddWithValue("Date", shoping.Date);
                command.Parameters.AddWithValue("Cost", shoping.Cost);
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

        public bool IsExistShoping(ShopingModel shoping)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Shoping WHERE MemberId=@MemberId AND Date=@Date";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("MemberId", shoping.MemberId);
            command.Parameters.AddWithValue("Date", shoping.Date);
            reader = command.ExecuteReader();

            bool rowAffected = reader.HasRows;

            reader.Close();
            connection.Close();
            return rowAffected;

        }



        public int RemoveShopingCost(int memberId,string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "DELETE FROM Shoping WHERE MemberId=@MemberId AND Date=@Date";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("MemberId", memberId);
            command.Parameters.AddWithValue("Date", date);
            
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }

        public List<MemberWithShoping> GetShopingList(string date)
        {
            connection=new SqlConnection(connectionString);
            connection.Open();
            query =
                "SELECT Shoping.ShopingId,Shoping.Cost, CONVERT(date, Shoping.Date) as Date , Shoping.MemberId,Members.Name FROM Shoping join Members on Members.MemberId=Shoping.MemberId where MONTH(date)='" + date+"' order by Shoping.Date";
            command=new SqlCommand(query,connection);
            reader = command.ExecuteReader();
            List<MemberWithShoping> shopingList=new List<MemberWithShoping>();

            while (reader.Read())
            {
                MemberWithShoping memberWithShoping=new MemberWithShoping();
                memberWithShoping.ShopingId = (int) reader["ShopingId"];
                memberWithShoping.Cost = (int) reader["Cost"];
                memberWithShoping.Date = (DateTime) reader["Date"];
                memberWithShoping.MemberId = (int) reader["MemberId"];
                memberWithShoping.MemberName = (string) reader["Name"];

                shopingList.Add(memberWithShoping);
            }

            reader.Close();
            connection.Close();
            return shopingList;

        } 
    }
}
