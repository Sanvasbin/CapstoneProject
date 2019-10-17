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

        public Project getProject(int idToCheck)
        {
            Project returnProject = null;
            SqlConnection conn = new SqlConnection();

            try
            {
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lds21\Desktop\CapstoneProject-master\CapstoneProject-master\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf; Integrated Security = True";
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT * FROM Project WHERE ProjectID = " + idToCheck;
                comm.Connection = conn;

                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read())
                {
                    // for each row in the result
                    Project newProject = new Project();
                    newProject.Id = (int)dr["ProjectId"];
                    newProject.Name = dr["Name"].ToString(); ;
                    newProject.Description = dr["Description"].ToString();
                    newProject.WorkingHours = (double)dr["WorkingHours"];
                    newProject.StartDate = (DateTime)dr["StartDate"];

                    returnProject = newProject;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {

                conn.Close();
            }



            return returnProject;

        }

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
