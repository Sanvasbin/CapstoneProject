using CapstoneProject.Models;
using CapstoneProject.Pages;
using CapstoneProject.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CapstoneProject.DAL;

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            OProject oProject = new OProject();
            List<Project> projects = oProject.Select();
            foreach (Project pj in projects)
            {
                cbProject.Items.Add(pj.Name);
            }
        }

        // Sabin Shrestha
        private void BtnNewProject_Click(object sender, RoutedEventArgs e)
        {
            Window win = new frmProject("new");
            win.ShowDialog();
        }

        // Sabin Shrestha
        private void BtnOpenProject_Click(object sender, RoutedEventArgs e)
        {
            Window win = new frmProjectDashboard();
            win.ShowDialog();
            this.Close();
        }
    }
}
