using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapstoneProject.Models;

namespace CapstoneProject.DAL
{
    public class ODependency
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\pertchart\CapstoneProject\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf;Integrated Security=True");

        public int Insert(Dependency newDependency)
        {
            conn.Open();
            string query = "insert into Dependency(TaskId) values('" + newDependency.Task.Id + "')'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;

        }
        public int Delete(int id)
        {
            conn.Open();
            string query = "Delete from Dependency Where DepOnTaskId= " + id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Update(Dependency updatedDependency)
        {
            conn.Open();
            string query = "update Dependency set TaskId='" + updatedDependency.Task.Id + "' Where Id=" + updatedDependency.DepOnTaskId;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;

        }
    }
}
