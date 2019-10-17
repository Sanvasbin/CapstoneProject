using CapstoneProject.Pages;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
            frameMain.Content = new Chart();
           
        }

        //By Levi Delezene
        private void mi_exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void BtnChart_Click(object sender, RoutedEventArgs e)
        {
            Window window = new frmPERTChart();
            this.Close();
            window.ShowDialog();
        }

        //By Levi Delezene
        private void mi_projectProperties_Click(object sender, RoutedEventArgs e)
        {
            // isCreating is false means it is update
            frameMain.Content = new ProjectProperties(false);
            SqlConnection conn = new SqlConnection();
            try
            {
                //Create a connection to database
               
                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lds21\Desktop\CapstoneProject-master\CapstoneProject-master\CapstoneProject\CapstoneProject\database\SmartPertDB.mdf;Integrated Security=True";

                // Issue a command
                SqlCommand comm = new SqlCommand();
                comm.CommandText = "SELECT * FROM Projects";
                //comm.CommandText = "sprocUserGetAll";
                //comm.CommandType = System.Data.CommandType.StoredProcedure;
                comm.Connection = conn;

                // Open the connection
                conn.Open();

                // Execute command 
                SqlDataReader dr = comm.ExecuteReader();

                // Read Result

                while (dr.Read())
                {
                    // for each row in the result
                    int id = (int)dr["ProjectId"];
                    string name = dr["Name"].ToString();
                }

               
            }catch(Exception ex){

            }finally {
                // Close connection
                conn.Close();
            }

            
        }

        //By Levi Delezene
        private void mi_openProject_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Chart();
        }

        //By Levi Delezene
        public static void numberValidation(object sender, TextCompositionEventArgs e)
        {
            //This allows for multiple '.' in the input. Could probably find something nicer
            e.Handled = new Regex("[^0-9.]+").IsMatch(e.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window window = new frmPERTChart();
            this.Close();
            window.ShowDialog();
        }

        private void Mi_newProject_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new ProjectProperties(true);
        }
    }
}
