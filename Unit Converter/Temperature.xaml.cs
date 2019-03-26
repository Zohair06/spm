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

namespace Unit_Converter
{
    /// <summary>
    /// Interaction logic for Temperature.xaml
    /// </summary>
    public partial class Temperature : Window
    {
        public Temperature()
        {
            InitializeComponent();

        }

        private void quittem(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void calculateTemp(object sender, RoutedEventArgs e)
        {
            double result,value = double.Parse(valueTxbx.Text);
             if (combo1.Text == "Fahrenheit" && combo2.Text == "Fahrenheit")
            {
                resultTxbx.Text = valueBox.Text;
            }
             if (combo1.Text == "Celsius" && combo2.Text == "Celsius")
            {
                resultTxbx.Text = valueBox.Text;
            }
            
            // Fahrenheit to Celius
            if (cBox1.Text == "Fahrenheit" && cBox2.Text == "Celcius")
            {
                result =(value -32)/(1.8);
                resultTxbx.Text = result.ToString() + " °C";

            }
            else if (cBox1.Text == "Celcius" && cBox2.Text == "Fahrenheit")
            {
                result = value *(1.8)+32;
                resultTxbx.Text = result.ToString()+ " °F";

            }
            else
                calculateBtn.IsEnabled = false;
        }


    }
}
