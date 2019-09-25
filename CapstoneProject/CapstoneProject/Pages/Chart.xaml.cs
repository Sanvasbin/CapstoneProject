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

        private Point savedMousePosition;
        private TranslateTransform move;
        private ScaleTransform zoom;
        private bool translating = false;

        private double dayWidth = 75;

        public Chart() {
            InitializeComponent();

            this.MouseDown += SetMouseDrag;
            this.MouseMove += DragCanvas;
            this.MouseUp += ReleaseMouseDrag;
            this.MouseWheel += ZoomCanvas;
            SetupCanvas();

            DrawCalendar(30);

            mainCanvas.Width = 30 * dayWidth; //TO-DO: Necessary for MouseEvents to fire. Discuss. 
        }

        private void mi_addTask_Click(object sender, RoutedEventArgs e) {
            new frmCreateTask().Show();
        }

        // Created by Sandro Pawlidis (9/25/2019)
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

        // Created by Sandro Pawlidis (9/25/2019)
        private void SetupCanvas() {
            move = new TranslateTransform();
            zoom = new ScaleTransform();

            TransformGroup group = new TransformGroup();
            group.Children.Add(move);
            group.Children.Add(zoom);

            mainCanvas.RenderTransform = group;
            mainCanvas.RenderTransformOrigin = new Point(0.5, 0.5);
        }

        // Created by Sandro Pawlidis (9/25/2019)
        private void ZoomCanvas(object sender, MouseWheelEventArgs e) {
            double zoomSpeed = 0.05;

            if (e.Delta > 0) {
                zoom.ScaleX += zoomSpeed;
                zoom.ScaleY += zoomSpeed;
            } else if (e.Delta < 0) {
                zoom.ScaleX -= zoomSpeed;
                zoom.ScaleY -= zoomSpeed;
            }
        }

        // Created by Sandro Pawlidis (9/25/2019)
        private void DragCanvas(object sender, RoutedEventArgs e) {
            if (!translating) return;

            Point currentMousePos = Mouse.GetPosition(mainCanvas);
            move.X += currentMousePos.X - savedMousePosition.X;
            move.Y += currentMousePos.Y - savedMousePosition.Y;
        }

        // Created by Sandro Pawlidis (9/25/2019)
        private void SetMouseDrag(object sender, RoutedEventArgs e) {
            translating = true;
            savedMousePosition = Mouse.GetPosition(mainCanvas);
        }

        // Created by Sandro Pawlidis (9/25/2019)
        private void ReleaseMouseDrag(object sender, RoutedEventArgs e) {
            translating = false;
        }
    }
}
