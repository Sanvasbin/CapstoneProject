using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CapstoneProject.Pages;
using CapstoneProject.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CapstoneProject.Windows
{
    /// <summary>
    /// Interaction logic for frmProject.xaml
    /// </summary>
    public partial class frmProject : Window
    {
        // Sabin Shrestha
        // We can have new, update, delete, edit as enum and we 
        // can pass that on to the constructor to show different pages in one window 
        public frmProject(string type)
        {
            InitializeComponent();
            if(type == "new")
            {
                CreateProject cpj = new CreateProject();
                this.Content = cpj;
                this.Title = "Create Project"; 
                
            }
        }
    }
}
