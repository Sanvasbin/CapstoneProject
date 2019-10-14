/*
 * Created by Levi Delezene 
 */
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//added namespace-alankar
namespace CapstoneProject.Models
{
    public enum Status
    {
        notStarted, inProgress, completed
    }

    public class Task
    {
        //These classes are using auto properties. I don't know how they'll work with the database stuff.
        //It's easy enough to change if they won't work

        public Task()
        {
            CompletedDate = null;
            StartedDate = null;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float MinDuration { get; set; }
        public float MaxDuration { get; set; }
        public float MostLikelyDuration { get; set; }
        public int Priority { get; set; }
        public Nullable<DateTime> CompletedDate { get; set; }
        public Nullable<DateTime> StartedDate { get; set; }
        public DateTime DeletedDate { get; set; }

        //modified date created by alankar pokhrel
        public DateTime ModifiedDate { get; set; }

        public Task Dependency { get; set; }
        public User Owner { get; set; }
        public Status Status { get; set; }
        public Project Project { get; set; }
    }
}

