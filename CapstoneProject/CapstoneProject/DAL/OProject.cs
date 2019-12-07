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
using System.Data;

namespace CapstoneProject.DAL
{
    public class OProject
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\database\SmartPertDB.mdf;Integrated Security=True");

        // Edited by Sabin Shrestha
        public int Insert(Project newProject)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(
                    "INSERT INTO Project (Name, StartDate, WorkingHours, ProjectOwner, Description)" +
                    " VALUES(@Name, @StartDate, @WorkingHours, @ProjectOwner, @Description)", conn);

                // Goal: Make all DAL similar to this. and converting to store procedure.
                //       Doing so, will secure the database.

                cmd.Parameters.AddWithValue("@Name", newProject.Name);
                cmd.Parameters.AddWithValue("@StartDate", newProject.StartDate);
                cmd.Parameters.AddWithValue("@WorkingHours", newProject.WorkingHours);
                cmd.Parameters.AddWithValue("@ProjectOwner", newProject.ProjectOwner.Id);
                cmd.Parameters.AddWithValue("@Description", newProject.Description);
                int effectedIds = cmd.ExecuteNonQuery();
                conn.Close();
                return effectedIds;
            }
            catch
            {
                return -1;
            }
            
        }

        public int Delete(int projectId)
        {
            try
            {
                conn.Open();
                string query = "Delete from Project Where ProjectId= " + projectId;
                SqlCommand cmd = new SqlCommand(query, conn);
                int effectedIds = cmd.ExecuteNonQuery();
                conn.Close();
                return effectedIds;
            }
            catch
            {
                return -1;
            }
        }
        public int Update(Project updatedProject)
        {
            try
            {
                conn.Open();
                string query = "update Project set Name = '" + updatedProject.Name + "', WorkingHours='" + updatedProject.WorkingHours + "', ProjectOwner='" + updatedProject.ProjectOwner + "' Where ProjectId=" + updatedProject.Id;
                SqlCommand cmd = new SqlCommand(query, conn);
                int effectedIds = cmd.ExecuteNonQuery();
                conn.Close();
                return effectedIds;
            }
            catch{
                return -1;
            }

        }

        // alankar 
        public List<Project> Select()
        {
            try
            {
                conn.Open();
                string query = "Select * from Project";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Project> projectList = new List<Project>();
                while (reader.Read())
                {
                    Project project = new Project();
                    project.Id = (int)reader["ProjectId"];
                    project.Name = (string)reader["Name"];
                    OUser oUser = new OUser();
                    project.ProjectOwner = oUser.getByID((int)reader["ProjectOwner"]);
                    project.StartDate = (DateTime)reader["StartDate"];
                    project.WorkingHours = (double)reader["WorkingHours"];
                    if ((reader["Description"]) != DBNull.Value)
                        project.Description = (string)reader["Description"];
                    projectList.Add(project);
                }
                return projectList;
            }
            catch
            {
                return null;
            }
            
        }

    }
}
