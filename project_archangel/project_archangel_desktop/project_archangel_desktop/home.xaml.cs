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

namespace project_archangel_desktop
{
    /// <summary>
    /// Interaction logic for home.xaml
    /// </summary>
    public partial class home : Window
    {
        public home()
        {
            InitializeComponent();
        }

        private void TB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void max_Click(object sender, RoutedEventArgs e)
        {

            if (WindowState == WindowState.Maximized)
            {
                WindowState = WindowState.Normal;
            }
            else if (WindowState == WindowState.Normal)
            {
                WindowState = WindowState.Maximized;
            }

        }

        private void min_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }



    }
}
