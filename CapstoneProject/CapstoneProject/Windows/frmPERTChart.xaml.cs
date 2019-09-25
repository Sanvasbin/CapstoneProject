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
            /// checkin from static point of view
            User user = new User();
            user.FirstName = "Sabin";
            user.LastName = "Shrestha";
            Task task = new Task();
            task.Name = "initial";
            task.Description = "first task";
            task.StartedDate = DateTime.Now;
            task.CompletedDate = task.StartedDate.AddDays(5.0);
            task.MostLikelyDuration = 5;
            task.Status = Status.inProgress;
            task.Owner = user;

            string[] taskNames = new string[] { task.Name };
            string[] taskDescription = new string[] { task.Description };
            DateTime[] taskStartDate = new DateTime[] { task.StartedDate };
            DateTime[] taskEndDate = new DateTime[] { task.CompletedDate };
            string[] priorityLevel = new string[] { task.Priority.ToString() };
            string[] mostLikely = new string[] { task.MostLikelyDuration.ToString() };
            DisplayChart(taskNames, taskDescription, taskStartDate, taskEndDate, priorityLevel, mostLikely);
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }

        // ways to load database and store the whole value in an array for each variable
        // ToDo: make priority level a enum
        private void DisplayChart(string[] taskNames, string[] taskDescriptions, DateTime[] taskStartDate,
            DateTime[] taskCompleteDate, string[] priorityLevel, string[] mostLikely)
        {
            Grid grdTasks = new Grid();

            grdTasks.Width = 450;
            grdTasks.Height = 150;
            grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
            grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
            grdTasks.ColumnDefinitions.Add(new ColumnDefinition());

            grdTasks.RowDefinitions.Add(new RowDefinition());
            grdTasks.RowDefinitions.Add(new RowDefinition());
            grdTasks.RowDefinitions.Add(new RowDefinition());

            for (int i = 0; i < taskNames.Length; i++)
            {
                TextBox tbxName = new TextBox
                {
                    Text = taskNames[i],
                    BorderThickness = new Thickness(5),
                    IsEnabled = false,
                    Height = 50,
                    Width = grdTasks.Width,
                    TextAlignment = TextAlignment.Center
                };

                TextBox tbxDescription = new TextBox
                {
                    Text = taskDescriptions[i],
                    BorderThickness = new Thickness(5.0),
                    IsEnabled = false,
                    Height = 50,
                    Width = grdTasks.Width,
                    TextAlignment = TextAlignment.Center
                };

                TextBox tbxStartDate = new TextBox
                {
                    Text = taskStartDate[i].ToString(),
                    BorderThickness = new Thickness(5),
                    IsEnabled = false,
                     Height = 50,
                    Width = 150,
                    TextAlignment = TextAlignment.Center
                };
               
                TextBox tbxCompleteDate = new TextBox
                {
                    Text = taskCompleteDate[i].ToString(),
                    BorderThickness = new Thickness(5.0),
                    IsEnabled = false,
                    Height = 50,
                    Width = 150,
                    TextAlignment = TextAlignment.Center
                };

                TextBox tbxEstimatedDate = new TextBox
                {
                    Text = mostLikely[i].ToString(),
                    BorderThickness = new Thickness(5.0),
                    IsEnabled = false,
                    Height = 50,
                    Width = 150,
                    TextAlignment = TextAlignment.Center
                };

                Grid.SetRow(tbxName, 0);
                tbxName.SetValue(Grid.ColumnSpanProperty, 3);
                grdTasks.Children.Add(tbxName);

                tbxDescription.SetValue(Grid.ColumnSpanProperty, 3);
                Grid.SetRow(tbxDescription, 1);
                grdTasks.Children.Add(tbxDescription);

                grdTasks.Children.Add(tbxStartDate);
                Grid.SetRow(tbxStartDate, 2);
                Grid.SetColumn(tbxStartDate, 0);

                grdTasks.Children.Add(tbxEstimatedDate);
                Grid.SetRow(tbxEstimatedDate, 2);
                Grid.SetColumn(tbxEstimatedDate, 1);

                Grid.SetRow(tbxCompleteDate, 2);
                Grid.SetColumn(tbxCompleteDate, 2);
                grdTasks.Children.Add(tbxCompleteDate);

                // make color enum based on priority enum.
                grdMain.Children.Add(grdTasks);
            }
        }
    }
}
