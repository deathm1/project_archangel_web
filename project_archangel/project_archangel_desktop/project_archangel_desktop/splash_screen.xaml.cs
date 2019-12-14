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
using System.Windows.Threading;
namespace project_archangel_desktop
{
    /// <summary>
    /// Interaction logic for splash_screen.xaml
    /// </summary>
    public partial class splash_screen : Window
    {

        DispatcherTimer dT = new DispatcherTimer();
        public splash_screen()
        {
            InitializeComponent();
            dT.Tick += new EventHandler(dT_Tick);
            dT.Interval = new TimeSpan(0, 0, 2);
            dT.Start();

        }


        private void dT_Tick(object sender, EventArgs e)
        {
            newhome home = new newhome();
            home.Show();
            dT.Stop();
            this.Close();
        }
    }
}
