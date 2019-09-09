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
using System.Windows.Shapes;

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for frmPERTChart.xaml
    /// </summary>
    public partial class frmPERTChart : Window
    {
        public frmPERTChart()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }

        // ways to load database and store the whole value in an array for each variable
        // ToDo: make priority level a enum
        private void DisplayChart(string[] taskNames, string[] taskDescriptions, double[] minDays,
            double[] maxDays, string[] priorityLevel)
        {
            for (int i = 0; i < taskNames.Length; i++)
            {
                Label Name = new Label
                {
                    Content = taskNames[i]
                };
                Label taskDescription = new Label
                {
                    Content = taskDescriptions[i]
                };
                Label minimumDays = new Label
                {
                    Content = minDays[i]
                };
                Label maximumDays = new Label
                {
                    Content = maxDays[i]
                };
                Label priority = new Label
                {
                    Content = priorityLevel[i]
                };
            }
        }

    }
}
