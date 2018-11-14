using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Data.SqlClient;
using MessManagementSystem.Model;

namespace MessManagementSystem.Gateway
{
    internal class MemberGateway
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["MessString"].ConnectionString;
        private string query;
        private SqlCommand command;
        private SqlConnection connection;
        private SqlDataReader reader;

        public int SaveMember(Member member)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();
                query = "insert into Members (Name,Email,Phone) values (@Name,@Email,@Phone)";
                //query = "insert into Members (Name,Email,Phone) values ('"+member.MemberName+"','"+member.Email+"','"+member.Phone+"')";
                command = new SqlCommand(query, connection);
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Name", member.MemberName);
                command.Parameters.AddWithValue("Email", member.Email);
                command.Parameters.AddWithValue("Phone", member.Phone);
                return command.ExecuteNonQuery();
            }
            catch (Exception exception)
            {

                throw;
            }          
         
                //int rowAffected = 
               
                //return rowAffected;

            finally
            {
                connection.Close();
            }
        }


        public List<Member> GetMembers()
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Members";
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();

            List<Member> Members = new List<Member>();

            while (reader.Read())
            {
                Member aMember = new Member();
                aMember.MemeberId = (int) reader["MemberId"];
                aMember.MemberName = reader["Name"].ToString();
                aMember.Email = reader["Email"].ToString();
                aMember.Phone = reader["phone"].ToString();

                Members.Add(aMember);
            }

            reader.Close();
            connection.Close();
            return Members;

        }



        public Member GetMemberById(int memberId)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Members WHERE MemberId='"+memberId+"'";
            command = new SqlCommand(query, connection);

            reader = command.ExecuteReader();

            //List<Member> Members = new List<Member>();

            while (reader.Read())
            {
                Member aMember = new Member();
                aMember.MemeberId = (int)reader["MemberId"];
                aMember.MemberName = reader["Name"].ToString();
                aMember.Email = reader["Email"].ToString();
                aMember.Phone = reader["phone"].ToString();

                //Members.Add(aMember);
                reader.Close();
                connection.Close();
                return aMember;
            }

            return null;

        }


        public bool IsExistMembers(Member member)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "SELECT * FROM Members WHERE Email=@Email OR Phone=@Phone";
            command = new SqlCommand(query, connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("Email", member.Email);
            command.Parameters.AddWithValue("Phone", member.Phone);
            reader = command.ExecuteReader();

            bool rowAffected = reader.HasRows;

            reader.Close();
            connection.Close();
            return rowAffected;

        }


        public int UpdateMember(Member aMember)
        {
            connection = new SqlConnection(connectionString);
            connection.Open();
            query = "UPDATE Members SET Name=@Name, Email=@Email, Phone=@Phone WHERE MemberId=@MemberId";

            command = new SqlCommand(query, connection);

            command.Parameters.Clear();
            command.Parameters.AddWithValue("Email", aMember.Email);
            command.Parameters.AddWithValue("Phone", aMember.Phone);
            command.Parameters.AddWithValue("MemberId", aMember.MemeberId);
            command.Parameters.AddWithValue("Name", aMember.MemberName);

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }


        public int RemoveMember(int memberId)
        {
            connection=new SqlConnection(connectionString);
            connection.Open();
            query = "DELETE FROM Members WHERE MemberId=@MemberId";
            command=new SqlCommand(query,connection);
            command.Parameters.Clear();
            command.Parameters.AddWithValue("MemberId", memberId);

            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;


        }

    }
}
