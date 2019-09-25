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
    /// Interaction logic for Chart.xaml
    /// </summary>
    
    //By Levi Delezene
    public partial class Chart : Page {
        public Chart() {
            InitializeComponent();
        }

        private void mi_addTask_Click(object sender, RoutedEventArgs e) {
            new frmCreateTask().Show();
        }


    }
}
