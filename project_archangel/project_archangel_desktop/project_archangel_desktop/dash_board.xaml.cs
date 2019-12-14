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
    /// Interaction logic for dash_board.xaml
    /// </summary>
    /// 

    public partial class dash_board : Window
    {

        public dash_board()
        {
            InitializeComponent();


        }


        private void setTitleBarBackground()
        {
        }

        private void TB_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        void OnImageButtonClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }




}
