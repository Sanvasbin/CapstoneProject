using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using CapstoneProject.Models;

namespace CapstoneProject.Pages
{
    /// <summary>
    /// Interaction logic for CreateProject.xaml
    /// </summary>
    public partial class CreateProject : Page
    {
        OUser OUser = new OUser();
        List<User> usr = new List<User>();
        OProject oProject = new OProject();
        int userIndex = 0;
        public CreateProject()
        {
            InitializeComponent();
            usr = OUser.Select();
            foreach(User user in usr)
            {
                cbUser.Items.Add(user.FirstName);
            } 
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            string name = tbxName.Text;
            string description = tbxDescription.Text;
            DateTime startDate = (DateTime) dpStartDate.SelectedDate;
            float hours = float.Parse(tbxWorkingHours.Text);
            string ownerName = cbUser.Text;
            User owner = usr[userIndex];

            
            Project pj = new Project();
            pj.Name = name;
            pj.StartDate = startDate;
            pj.WorkingHours = hours;
            pj.Description = description;
            pj.ProjectOwner = owner;
            oProject.Insert(pj);
            Window win = new frmPERTChart();
            win.ShowDialog();
        }

        private void CbUser_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            userIndex = cbUser.SelectedIndex;
        }
    }
}
