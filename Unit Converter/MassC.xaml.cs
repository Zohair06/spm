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
    /// Interaction logic for MassC.xaml
    /// </summary>
    public partial class MassC : Window
    {
        public MassC()
        {
            InitializeComponent();
        }

        private void conver(object sender, RoutedEventArgs e)
        {
            double value = 0;
            bool isNumber = false;
            isNumber = double.TryParse(valueTxbx.Text, out value);
            if (!isNumber)
            {

                MessageBox.Show("Type numbers in the text boxes");

            }
            else
            { 
                if (cbox1.Text == "Kg" && cbox2.Text == "g")
                {
                   ToGrams(value);
                }
                else if (cbox1.Text == "g" && cbox2.Text == "Kg")
                {
                   ToKgrams(value);
                }
                else
                     MessageBox.Show("Invalid Selection");
            }
        }
                

                private void ToKgrams(double value)
                {
                //float value = float.Parse(valueTxbx.Text);
                    double result;
                result = value / 1000;
                resultTxbx.Text = result.ToString() + " Kg";
                }

                private void ToGrams(double value)
                {
               // float value = float.Parse(valueTxbx.Text);
                    double result;
                result = value * 1000;
                resultTxbx.Text = result.ToString() + " g";
        
               }
    }
    

}
