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
    public class OProject
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\pertchart\CapstoneProject\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf;Integrated Security=True");

        public int Insert(Project newProject)
        {
            conn.Open();
            string query = "insert into User(Name, StartDate, WorkingHours, ProjectOwner) values('" + newProject.Name + "', '" + newProject.StartDate + "', '" + newProject.WorkingHours + "', '" + newProject.ProjectOwner + "')'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Delete(int projectId)
        {
            conn.Open();
            string query = "Delete from User Where ProjectId= " + projectId;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Update(Project updatedProject)
        {
            conn.Open();
            string query = "update Project set Name = '" + updatedProject.Name + "', WorkingHours='" + updatedProject.WorkingHours + "', ProjectOwner='" + updatedProject.ProjectOwner + "' Where ProjectId=" + updatedProject.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;

        }
        public SqlDataReader Select()
        {
            conn.Open();
            string query = "Select * from Project";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    
}
}
