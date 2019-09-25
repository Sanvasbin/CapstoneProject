/*
 * Created by Levi Delezene 
 */
 
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Project {
    private string description;
    private List<Task> tasks;

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime StartDate { get; set; }
    public float WorkingHours { get; set; }
    internal List<Task> Tasks { get; set; }
}
