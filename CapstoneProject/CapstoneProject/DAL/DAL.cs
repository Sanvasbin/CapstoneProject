using newPertChart.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newPertChart {
    public static class DAL {

        private static string GetDatabasePath() {
            string filePathLocalDB = System.Reflection.Assembly.GetEntryAssembly().Location;
            string path = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=";
            path += System.IO.Path.GetDirectoryName(filePathLocalDB);
            path += "\\Database\\db.mdf";
            path += ";Integrated Security=True";
            return path;
        }


        public static List<Project> GetProjects() {
            List<Project> projectList = new List<Project>();

            // Create Connection
            SqlConnection connection = new SqlConnection();

            try {
                // Setting connection string               
                connection.ConnectionString = GetDatabasePath();

                // Creating sql commnad to run on the database
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT * FROM Project";
                comm.Connection = connection; // Sets the connection to the command

                // open connection
                connection.Open();

                // Retrieve data
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read()) {
                    // for each row in the result
                    Project newProject = new Project();
                    newProject.Id = (int)dr["ProjectId"];
                    newProject.Name = dr["Name"].ToString(); ;
                    newProject.Description = dr["Description"].ToString();
                    newProject.WorkingHours = (double)dr["WorkingHours"];
                    newProject.StartDate = (DateTime)dr["StartDate"];

                    projectList.Add(newProject);
                }

            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            } finally {
                // close the connection
                connection.Close();
            }
            return projectList;
        }

        public static Project GetProject(int idToCheck) {
            Project returnProject = null;
            SqlConnection conn = new SqlConnection();

            try {
                conn.ConnectionString = GetDatabasePath();
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT * FROM Project WHERE ProjectID = " + idToCheck;
                comm.Connection = conn;

                conn.Open();
                SqlDataReader dr = comm.ExecuteReader();

                while (dr.Read()) {
                    // for each row in the result
                    Project newProject = new Project();
                    newProject.Id = (int)dr["ProjectId"];
                    newProject.Name = dr["Name"].ToString(); ;
                    newProject.Description = dr["Description"].ToString();
                    newProject.WorkingHours = (double)dr["WorkingHours"];
                    newProject.StartDate = (DateTime)dr["StartDate"];

                    returnProject = newProject;
                }

            } catch (Exception ex) {

            } finally {

                conn.Close();
            }



            return returnProject;

        }

        public static void Insert(Project newProject) {

            SqlConnection conn = new SqlConnection();
            try {
                // Setting connection string               
                conn.ConnectionString = GetDatabasePath();

                // Creating sql commnad to run on the database
                SqlCommand comm = new SqlCommand();

                newProject.StartDate = DateTime.Now;
                comm.CommandText = $"Insert INTO Project VALUES ('{newProject.Name}', {newProject.StartDate}, {newProject.WorkingHours}, {1}, '{newProject.Description}')";

                //--INSERT INTO Project([Name], [Description], StartDate, WorkingHours, ProjectOwner )
                //--VALUES('Pert Chart', 'Testing is for testing Description', 2019 - 10 - 10, 100, 1);
                comm.Connection = conn; // Sets the connection to the command
                // open connection
                conn.Open();

                comm.ExecuteNonQuery();
            } catch (Exception ex) {
                System.Diagnostics.Debug.WriteLine(ex.Message);

            } finally {
                // close the connection
                conn.Close();
            }

        }
        }
}
