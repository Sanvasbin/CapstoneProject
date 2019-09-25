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
using System.Windows.Shapes;

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for frmCreateTask.xaml
    /// </summary>
    
    //By Levi Delezene
    public partial class frmCreateTask : Window
    {
        public frmCreateTask()
        {
            InitializeComponent();
            Owner = Application.Current.MainWindow;
        }

        //By Levi Delezene
        private Task createTask() {
            Task task = new Task {
                Name = tbxTaskName.Text,
                Description = tbxTaskDescription.Text,
                MinDuration = float.Parse(tbxMinDuration.Text),
                MaxDuration = float.Parse(tbxMaxDuration.Text),
                Priority = int.Parse(cmbPriority.Text),
                Owner = new User() { FirstName = "first", MiddleName = "middle", LastName = "last" } //TODO: implement users
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
            return task;
        }

        //By Levi Delezene
        private void btnSubmitAndClose_Click(object sender, RoutedEventArgs e) {
            try {
                createTask();
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
                new frmCreateTask().Show();
            }
        }

        //By Levi Delezene
        private void numberValidation(object sender, TextCompositionEventArgs e) {
            MainWindow.numberValidation(sender, e);
        }
    }
}
