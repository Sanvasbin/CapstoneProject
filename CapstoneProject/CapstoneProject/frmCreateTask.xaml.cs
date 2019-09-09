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
    /// Interaction logic for frmCreateTask.xaml
    /// </summary>
    public partial class frmCreateTask : Window
    {
        public frmCreateTask()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string taskName = tbxTaskName.Text;
                string taskDescription = tbxTaskDescription.Text;
                double minDays = double.Parse(tbxMinDuration.Text);
                double maxDays = double.Parse(tbxMaxDuration.Text);
                string priorityLevel = tbxPriorityLevel.Text;
                // employee class for owner??
            }
            catch(Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }

        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow();
            this.Close();
            window.ShowDialog();
        }
    }
}
