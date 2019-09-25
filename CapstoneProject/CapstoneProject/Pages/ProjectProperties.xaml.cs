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

namespace CapstoneProject.Pages {
    /// <summary>
    /// Interaction logic for ProjectProperties.xaml
    /// </summary>
    
    //By Levi Delezene
    public partial class ProjectProperties : Page {
        public ProjectProperties() {
            InitializeComponent();
            dpStartDate.BlackoutDates.AddDatesInPast();
        }

        public void numberValidation(object sender, TextCompositionEventArgs e) {
            MainWindow.numberValidation(sender, e);
        }

        private void btnSubmit_Click(object sender, RoutedEventArgs e) {
            try {
                createProject();
            } catch (Exception excep) {
                MessageBox.Show(excep.ToString());
            } finally {
                NavigationService.Navigate(new Chart());
            }
        }

        private Project createProject() {
            Project project = new Project() {
                Name = tbxName.Text,
                Description = tbxDescription.Text,
                WorkingHours = int.Parse(tbxWorkingHours.Text),
                StartDate = (DateTime)dpStartDate.SelectedDate
            };
            return project;
        }
    }
}
