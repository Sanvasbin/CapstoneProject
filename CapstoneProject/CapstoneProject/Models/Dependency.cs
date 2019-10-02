/*
 * Created by Alankar Pokhrel 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject.Models
{
    public class Dependency
    {
        public int DepOnTaskId { get; set; }
        public Task Task { get; set; }
    }
}
