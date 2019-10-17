using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
namespace CapstoneProject.Pages {
    /// <summary>
    /// Interaction logic for ProjectProperties.xaml
    /// </summary>
    
    //By Levi Delezene

    
    public partial class ProjectProperties : Page {

        bool isNew = true;
        public ProjectProperties(bool isCreating) {
            InitializeComponent();
            if (isCreating)
            {
                btnSubmit.Content = "Create New!";
                isNew = true;

                // Do not allow user creating a new project to create in the past. -JK-
                dpStartDate.BlackoutDates.AddDatesInPast(); 
            }
            else
            {
                isNew = false;
                btnSubmit.Content = "Update";
            }
            
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OProject projectObj = new OProject();
           
            
            SqlConnection conn = new SqlConnection();
            try
            {
                //Create a connection to database

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lds21\Desktop\CapstoneProject-master\CapstoneProject-master\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf; Integrated Security = True";

                // Issue a command
                SqlCommand comm = new SqlCommand();
                //comm.CommandText = "SELECT * FROM Projects";
                comm.CommandText = "sprocProjectGetAll";
                comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Connection = conn;

                // Open the connection
                conn.Open();

                // Execute command 
                SqlDataReader dr = comm.ExecuteReader();

                // Read Result
                Project newProject = new Project();
                while (dr.Read())
                {
                    int id = (int)dr["ProjectId"];
                    string name = dr["Name"].ToString();
                    string description = dr["Description"].ToString();
                    double workingHours = (double)dr["WorkingHours"];
                    newProject.Id = id;
                    newProject.Name = name;
                    newProject.Description = description;
                    newProject.WorkingHours = workingHours;
                    ProjectDropDownMenu.Items.Add(newProject);
                }


                //tbxName.Text = newProject.Name;
                //tbxDescription.Text = newProject.Description;
                //tbxWorkingHours.Text = newProject.WorkingHours.ToString();

                btnConnect.Content = "Connected!";
                btnConnect.Visibility = Visibility.Hidden;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur in database");
            }
            finally
            {
                // Close connection
                conn.Close();
            }
            // Read Results


 
        }

        private void ProjectDropDownMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Project selectedProject = (Project)ProjectDropDownMenu.SelectedItem;
            OProject dal = new OProject();
            Project displayProject = dal.getProject(selectedProject.Id);
            tbxName.Text = displayProject.Name;
            tbxDescription.Text = displayProject.Description;
            tbxWorkingHours.Text = displayProject.WorkingHours.ToString();
            //dpStartDate.SelectedDate = displayProject.StartDate;
        }
    }
}
