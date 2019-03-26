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

namespace Unit_Converter
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

        private void tConversions(object sender, RoutedEventArgs e)
        {
            Temperature temp = new Temperature();
            temp.ShowDialog();
        }


        private void toQuit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void volume(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry In Progress");
        }

        private void speed(object sender, RoutedEventArgs e)
        {
            Speed OSpeed = new Speed();
            OSpeed.ShowDialog();
        }

        private void digitalBtn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry In Progress");
        }

        private void fuelButten(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry In Progress");
        }

        private void lengthButten(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry In Progress");
        }

        private void clockButten(object sender, RoutedEventArgs e)
        {
            Timer ntime = new Timer();
            ntime.ShowDialog();
        }

        private void areaButten(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Sorry In Progress");
        }

        private void massC(object sender, RoutedEventArgs e)
        {
            MassC mcalc = new MassC();
            mcalc.ShowDialog();
        }


    }
}
