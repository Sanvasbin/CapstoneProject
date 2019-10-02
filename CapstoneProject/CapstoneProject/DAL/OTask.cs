using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CapstoneProject.Models;
using Task = CapstoneProject.Models.Task;

namespace CapstoneProject.DAL
{
    public class OTask
    {
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\pertchart\CapstoneProject\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf;Integrated Security=True");

        public int Insert(Task newTask)
        {
            conn.Open();
            string query = "insert into Task(Name, Description, MinEstDuration, MaxEstDuration, MostLikelyeEstDuration, StartDate, EndDate, ModifiedDate, StatusId, UserId, ProjectId) values('" + newTask.Name + "', '" + newTask.Description + "', '" + newTask.MinDuration+ "', '" + newTask.MaxDuration + "', '" + newTask.MostLikelyDuration + "', '" + newTask.StartedDate + "', '" + newTask.CompletedDate + "', '" + newTask.ModifiedDate + "', '" + newTask.Status + "', '" + newTask.Owner.Id + "', '" + newTask.Project.Id + "')'";
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Delete(int taskId)
        {
            conn.Open();
            string query = "Delete from Task Where TaskId= " + taskId;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;
        }
        public int Update(Task updatedTask)
        {
            conn.Open();
            string query = "update Task set Name = '" + updatedTask.Name + "', Description='" + updatedTask.Description + "', MinEstDuration='" + updatedTask.MinDuration + "', MaxEstDuration='" + updatedTask.MaxDuration + "', MostLikelyeEstDuration='" + updatedTask.MostLikelyDuration + "', EndDate='" + updatedTask.CompletedDate + "', ModifiedDate='" + updatedTask.ModifiedDate + "', StatusId='" + updatedTask.Status + "', UserId='" + updatedTask.Owner.Id + "', ProjectId='" + updatedTask.Project.Id + "' Where TaskId=" + updatedTask.Id;
            SqlCommand cmd = new SqlCommand(query, conn);
            int effectedIds = cmd.ExecuteNonQuery();
            conn.Close();
            return effectedIds;

        }
        public SqlDataReader Select()
        {
            conn.Open();
            string query = "Select * from Task";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
