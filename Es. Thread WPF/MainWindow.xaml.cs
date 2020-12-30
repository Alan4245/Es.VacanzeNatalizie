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
using System.Threading;

namespace Es.Thread_WPF
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        readonly Uri uriAuto = new Uri("car.png", UriKind.Relative);
       // int posInitAuto = 100;
        public MainWindow()
        {
            InitializeComponent();
            ImageSource img = new BitmapImage(uriAuto);
            imgCar.Source = img;
        }



    }
}
