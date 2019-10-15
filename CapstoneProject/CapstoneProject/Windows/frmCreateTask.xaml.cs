using CapstoneProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CapstoneProject.DAL;
using CapstoneProject.Pages;
using System.Globalization;
using System.Data.SqlClient;

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for frmCreateTask.xaml
    /// </summary>
    
    //By Levi Delezene
    public partial class frmCreateTask : Window
    {
        private Chart _chart;
        public frmCreateTask(Chart chart)
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
            _chart = chart;
        }

        //By Levi Delezene
        private Task createTask() {
            Task task = new Task {
                Name = tbxTaskName.Text,
                Project = _chart.Project,
                Description = tbxTaskDescription.Text,
                MinDuration = float.Parse(tbxMinDuration.Text),
                MaxDuration = float.Parse(tbxMaxDuration.Text),
                Priority = int.Parse(cmbPriority.Text),
                StartedDate = DateTime.Parse("1/5/2019"),
                Owner = (User)cmbOwner.Items[cmbOwner.SelectedIndex]
            };

            //Maybe find a better way to do this
            switch (cmbStatus.Text) {
                case "Not Started":
                    task.Status = Status.notStarted;
                    break;
                case "In Progress":
                    task.Status = Status.inProgress;
                    break;
                case "Completed":
                    task.Status = Status.completed;
                    break;
            }

            new OTask().Insert(task);
            
            return task;
        }

        //By Levi Delezene
        private void btnSubmitAndClose_Click(object sender, RoutedEventArgs e) {
            try {
                Task task = createTask();
                _chart.Newtask = task;
                
            } catch (Exception excep) {
                MessageBox.Show(excep.ToString());
            } finally {
                Close();
            }
        }

        //By Levi Delezene
        private void btnSubmitAndContinue_Click(object sender, RoutedEventArgs e) {
            try {
                createTask();
            } catch (Exception excep) {
                MessageBox.Show(excep.ToString());
            } finally {
                //There's probably a better way to do this
                Close();
                new frmCreateTask(_chart).Show();
            }
        }

        //By Levi Delezene
        private void numberValidation(object sender, TextCompositionEventArgs e) {
            MainWindow.numberValidation(sender, e);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            tbxTaskName.Focus();
            OUser user = new OUser();
            SqlDataReader sdr = user.Select();
            while(sdr.Read())
            {
                User userValue = new User(sdr.GetInt32(0), sdr.GetString(1), sdr.GetString(2));
                cmbOwner.Items.Add(userValue);
            }
        }
    }
}
