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

        private double dayWidth = 75;

        public MainWindow()
        {
            InitializeComponent();
            frameMain.Content = new Chart();

            DrawCalendar(30);
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
            frameMain.Content = new Chart();
        }

        //By Levi Delezene
        public static void numberValidation(object sender, TextCompositionEventArgs e)
        {
            //This allows for multiple '.' in the input. Could probably find something nicer
            e.Handled = new Regex("[^0-9.]+").IsMatch(e.Text);
        }

        // Created by Sandro Pawlidis
        private void DrawCalendar(int days) {
            for (int i = 0; i < days; i++) {
                Line line = new Line();
                line.Stroke = System.Windows.Media.Brushes.Cyan;
                line.StrokeThickness = 2;

                line.X1 = i * dayWidth;
                line.X2 = line.X1;

                line.Y1 = 0;
                line.Y2 = mainCanvas.Height;

                mainCanvas.Children.Add(line);

                Label lbDay = new Label();
                lbDay.Content = i + 1;

                Canvas.SetLeft(lbDay, line.X1);
                mainCanvas.Children.Add(lbDay);
            }

        }
    }
}
