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

namespace CapstoneProject.Windows
{
    /// <summary>
    /// Interaction logic for frmDescription.xaml
    /// Sabin Shrestha
    /// </summary>
    public partial class frmDescription : Window
    {
        // Sabin Shrestha
        public frmDescription()
        {
            InitializeComponent();
            Label lbl = new Label();
            lbl.Content = frmPERTChart.tsk.Name + "\r\n" 
                          + "Owner: " +frmPERTChart.tsk.Owner.FirstName + "\r\n"
                           + "Description: " + frmPERTChart.tsk.Description;
            grdMain.Children.Add(lbl);
        }
    }
}
