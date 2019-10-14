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
        public SqlDataReader Select()
        {
            conn.Open();
            string query = "Select UserId, FirstName, LastName, EmailAddress from \"User\"";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
