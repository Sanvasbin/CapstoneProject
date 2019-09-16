using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum Status {
    notStarted, inProgress, completed
}

class Task {
    //These classes are using auto properties. I don't know how they'll work with the database stuff.
    //It's easy enough to change if they won't work

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public float MinDuration { get; set; }
    public float MaxDuration { get; set; }
    public float MostLikelyDuration { get; set; }
    public int Priority { get; set; }
    public DateTime CompletedDate { get; set; }
    public DateTime StartedDate { get; set; }
    public DateTime DeletedDate { get; set; }
    public Task Dependency { get; set; }
    public User Owner { get; set; }
    public Status Status { get; set; }
}

