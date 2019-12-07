/*
 * Created by Alankar Pokhrel 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapstoneProject.Models;
    
    
namespace CapstoneProject.DAL
{
    public class OUser
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\SmartPertDB.mdf;Integrated Security=True");

        public int Insert(User newUser)
        {
            conn.Open();
            string query = "insert into User(FirstName, MiddleName, LastName) values('" + newUser.FirstName + "', '" + newUser.MiddleName + "', '" + newUser.LastName + "')'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
            //if (effectedIds >= 0)
            //{
            //    MessageBox.Show("Inserted");
            //}
            //else
            //{
            //    MessageBox.Show("Not Inserted");
            //}
            
        }
        public int Delete(int id)
        {
            conn.Open();
            string query = "Delete from User Where Id= "+id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Update(User updatedUser)
        {
            conn.Open();
            string query = "update User set FirstName = '"+updatedUser.FirstName+"', MiddleName='"+updatedUser.MiddleName+"', LastName='"+updatedUser.LastName+"' Where Id=" +updatedUser.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;

        }

        public List<User> Select()
        {
            conn.Open();
            string query = "Select UserId, FirstName, LastName, EmailAddress from \"User\"";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> userList = new List<User>();
            while (reader.Read())
            {
                User user = new User();
                user.Id = (int)reader["UserId"];
                user.FirstName = (string)reader["FirstName"];
                user.LastName = (string)reader["LastName"];
                userList.Add(user);
            }
            conn.Close();
            return userList;
        }

        public User getByID(int userId)
        {
            conn.Open();
            string query = "Select UserId, FirstName, LastName, EmailAddress from \"User\" where userid=@userid";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@userid", userId);
            SqlDataReader reader = cmd.ExecuteReader();
            User user = new User();
            while (reader.Read())
            {
                user = new User((int)reader["UserId"], (string)reader["FirstName"], (string)reader["LastName"]);
            }
            conn.Close();
            return user;
        }


    }
}
