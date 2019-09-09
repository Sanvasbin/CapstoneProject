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
        }

        private void BtnCreateTask_Click(object sender, RoutedEventArgs e)
        {
            Window window = new frmCreateTask();
            this.Close();
            window.ShowDialog();
        }

        private void BtnDisplayPERTChart_Click(object sender, RoutedEventArgs e)
        {
            Window window = new frmPERTChart();
            this.Close();
            window.ShowDialog();
        }
    }
}
