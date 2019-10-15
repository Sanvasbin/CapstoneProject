using System;
using CapstoneProject.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CapstoneProject.Models;

namespace CapstoneProject
{
    /// <summary>
    /// Interaction logic for frmPERTChart.xaml
    /// Sabin Shrestha
    /// </summary>
    public partial class frmPERTChart : Window
    {

        public static Task tsk;  

        Task[] tasks;
        string[] taskNames;
        string[] taskDescription;
        Nullable<DateTime>[] taskStartDate;
        Nullable<DateTime>[] taskEndDate;
        string[] priorityLevel;
        string[] mostLikely;
        
       
        public frmPERTChart()
        {
            InitializeComponent();
            /// checkin from static point of view
            addData();
            DisplayChart(taskNames, taskDescription, taskStartDate, taskEndDate, priorityLevel, mostLikely);
        }

        // By sabin
        private void addData()
        {
            taskNames = new string[10];
            taskDescription = new string[10];
            taskStartDate = new Nullable<DateTime>[10];
            taskEndDate = new Nullable<DateTime>[10];
            priorityLevel = new string[10];
            mostLikely = new string[10];
            tasks = new Task[10];

            for (int i = 0; i < 10; i++)
            {
                User user = new User
                {
                    FirstName = "Sabin" + i,
                    LastName = "Shrestha" + i,
                };
                Task task = new Task
                {
                    Name = "initial" + i,
                    Description = "first task" + 1,
                    StartedDate = DateTime.Now
                };
                tasks[i] = task;
                task.Owner = user;
                taskNames[i] = task.Name;
                taskDescription[i] = task.Description;
                taskStartDate[i] = task.StartedDate;
                taskEndDate[i] = task.CompletedDate;
                priorityLevel[i] = task.Priority.ToString();
                mostLikely[i] = task.MostLikelyDuration.ToString();
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }

        // ways to load database and store the whole value in an array for each variable
        // ToDo: make priority level a enum
        // By sabin
        private void DisplayChart(string[] taskNames, string[] taskDescriptions, Nullable<DateTime>[] taskStartDate,
            Nullable<DateTime>[] taskCompleteDate, string[] priorityLevel, string[] mostLikely)
        {
            grdTasks.Height = 100;
            grdTasks.RowDefinitions.Add(new RowDefinition());
            grdTasks.RowDefinitions.Add(new RowDefinition());
            for (int i = 0; i < taskNames.Length; i++)
            {
                grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
                grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
                grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
                grdTasks.ColumnDefinitions.Add(new ColumnDefinition());
            }

            for (int i = 0; i < 10; i++)
            {
                Button btnName = new Button
                {
                    Content = taskNames[i],
                    BorderThickness = new Thickness(5),
                    Height = 50,
                    Width = grdTasks.Width,
                };
                Button btnDescription = new Button
                {
                    Content = taskDescriptions[i],
                    BorderThickness = new Thickness(5.0),
                    Height = 50,
                    Width = grdTasks.Width,
                    IsEnabled = false
                };

                Button btnStartDate = new Button
                {
                    Content = taskStartDate[i].ToString(),
                    BorderThickness = new Thickness(5),
                    Height = 50,
                    Width = 150,
                    IsEnabled = false
                };

                Button btnCompleteDate = new Button
                {
                    Content = taskCompleteDate[i].ToString(),
                    BorderThickness = new Thickness(5.0),
                    Height = 50,
                    Width = 150,
                    IsEnabled = false
                };

                Button btnEstimatedDate = new Button
                {
                    Content = mostLikely[i].ToString(),
                    BorderThickness = new Thickness(5.0),
                    Height = 50,
                    Width = 150,
                    IsEnabled = false
                };

                Image img = new Image();
                img.Source = new BitmapImage(new Uri(@"..\Images\arrow.jpg", UriKind.Relative));
                StackPanel stackPnl = new StackPanel();
                stackPnl.Orientation = Orientation.Horizontal;
                stackPnl.Children.Add(img);


                Button btnArrow = new Button
                {
                    BorderThickness = new Thickness(5.0),
                    IsEnabled = false,
                    Height = 50,
                    Width = 150,
                };
                btnArrow.Content = stackPnl;

                btnName.SetValue(Grid.RowProperty, 0);
                btnName.SetValue(Grid.ColumnProperty, i * 4);
                btnName.SetValue(Grid.ColumnSpanProperty, 3);
                int currentIndex = i;
                btnName.Click += (sender, EventArgs) => { btnDescription_Click(sender, EventArgs, tasks[currentIndex]); };

                btnStartDate.SetValue(Grid.RowProperty, 1);
                btnStartDate.SetValue(Grid.ColumnProperty, i * 4);

                btnEstimatedDate.SetValue(Grid.RowProperty, 1);
                btnEstimatedDate.SetValue(Grid.ColumnProperty, i * 4 + 1);

                btnCompleteDate.SetValue(Grid.RowProperty, 1);
                btnCompleteDate.SetValue(Grid.ColumnProperty, i * 4 + 2);
               

                btnArrow.SetValue(Grid.RowProperty, 0);
                btnArrow.SetValue(Grid.ColumnProperty, i * 4 + 3);
                btnArrow.SetValue(Grid.RowSpanProperty, 2);
               

                // make color enum based on priority enum.

                grdTasks.Children.Add(btnName);
                grdTasks.Children.Add(btnStartDate);
                grdTasks.Children.Add(btnEstimatedDate);
                grdTasks.Children.Add(btnCompleteDate);
                grdTasks.Children.Add(btnArrow);
            }
        }

        // Sabin Shrestha
        private void btnDescription_Click(object sender, RoutedEventArgs e, Task task)
        {
            tsk = task;
            Window window = new frmDescription();
            window.ShowDialog();
        }

    }
}
