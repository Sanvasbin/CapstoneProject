using CapstoneProject.Models;
using CapstoneProject.Pages;
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

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Project project;
        Chart chart;

        public MainWindow()
        {
            InitializeComponent();
            project = new Project();
            chart = new Chart(project);

            project.StartDate = new DateTime(2019, 1, 1);
            project.Id = 1;
            frameMain.Content = chart;
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
            frameMain.Content = new ProjectProperties();
        }

        //By Levi Delezene
        private void mi_openProject_Click(object sender, RoutedEventArgs e)
        {
            frameMain.Content = new Chart(project);
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
    }
}
