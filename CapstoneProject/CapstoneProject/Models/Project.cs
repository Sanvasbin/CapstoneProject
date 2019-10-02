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
    public class Project
    {
        private string description;
        private List<Task> tasks;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public float WorkingHours { get; set; }


        //Project owner created by alankar Pokhrel
        public User ProjectOwner { get; set; }

        internal List<Task> Tasks { get; set; }
    }
}