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
    class MealGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MessString"].ConnectionString;
        private string query;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public int SaveMeal(Meal meal)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = "insert into Meal (MemberId,Date,TotalMeal) values (@MemberId,@Date,@TotalMeal)";
                 command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("MemberId", meal.MemberId);
                command.Parameters.AddWithValue("Date", meal.Date);
                command.Parameters.AddWithValue("TotalMeal", meal.TotalMeal);
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


        public bool IsExistDailyMeal(Meal meal)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Meal WHERE MemberId=@MemberId AND Date=@Date";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("MemberId", meal.MemberId);
            command.Parameters.AddWithValue("Date", meal.Date);
            reader = command.ExecuteReader();

            bool rowAffected = reader.HasRows;

            reader.Close();
            connection.Close();
            return rowAffected;

        }



        public List<Meal> GetMealList()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "select * from Meal";
            command = new SqlCommand(query, connection);
            reader = command.ExecuteReader();

            List<Meal> meals = new List<Meal>();

            while (reader.Read())
            {
                Meal aMember = new Meal();
                aMember.MemberId = (int)reader["MemberId"];           
                aMember.TotalMeal = Convert.ToDouble(reader["TotalMeal"]);
                aMember.Date = (DateTime)reader["Date"];

                meals.Add(aMember);
            }

            reader.Close();
            connection.Close();
            return meals;

        }

        public List<MemberWithMeal> GetMeal(int memberId,string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "select Meal.Date,Meal.MemberId,Meal.TotalMeal,Members.Name from Meal join Members on Meal.MemberId=Members.MemberId AND Meal.MemberId='" + memberId + "' AND  MONTH(Meal.date)='" + date + "'";
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();

            List<MemberWithMeal> meals = new List<MemberWithMeal>();

            while (reader.Read())
            {
                MemberWithMeal aMember = new MemberWithMeal();
                aMember.MemberId = (int)reader["MemberId"];
                aMember.MemberName = reader["Name"].ToString();
                aMember.TotalMeal = Convert.ToDouble(reader["TotalMeal"]);
                aMember.Date = (DateTime) reader["Date"];

                meals.Add(aMember);
            }

            reader.Close();
            connection.Close();
            return meals;

        }


        public List<MemberWithMeal> GetMealThreeDays(int currentdate,int previousDate, string date)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "select Meal.Date,Meal.MemberId,Meal.TotalMeal,Members.Name from Meal join Members on Meal.MemberId=Members.MemberId WHERE DAY(Meal.date) between '"+previousDate+"' and '"+currentdate+"'  AND  MONTH(Meal.date)='"+date+"'";
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();

            List<MemberWithMeal> meals = new List<MemberWithMeal>();

            while (reader.Read())
            {
                MemberWithMeal aMember = new MemberWithMeal();
                aMember.MemberId = (int)reader["MemberId"];
                aMember.MemberName = reader["Name"].ToString();
                aMember.TotalMeal = Convert.ToDouble(reader["TotalMeal"]);
                aMember.Date = (DateTime)reader["Date"];

                meals.Add(aMember);
            }

            reader.Close();
            connection.Close();
            return meals;

        }

        public int Remove(int memberId,string date)
        {
            connection=new SqlConnection(connectionString);
            connection.Open();
            query = "DELETE  FROM Meal WHERE MemberId='" + memberId + "' AND Date='" + date + "' ";
            command=new SqlCommand(query,connection);
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;

        }

    }
}
