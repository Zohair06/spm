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
    /// Interaction logic for Speed.xaml
    /// </summary>
    public partial class Speed : Window
    {
        public Speed()
        {
            InitializeComponent();
        }

        private void quitBtn(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void equalTo(object sender, RoutedEventArgs e)
        {
                          double speed, time, distance;
            speed = double.Parse(speedTxbx.Text);
            time = double.Parse(timeTxbx.Text);
            distance = double.Parse(distanceTxbx.Text);

            if(speedBox.Text=="Speed")
            {
                speedCalculate(time, distance);
            }
            else if (speedBox.Text=="Time")
            {
                timeCalculate(speed, distance);
            }
            else if (speedBox.Text=="Distance")
            {
                distanceCalculate(speed, time);
            }
        }

        private void speedCalculate(double time, double distance)
        {
            speedTxbx.Text = "solution";
            answerTxbx.Text = (distance/time).ToString();
        }

        private void distanceCalculate(double speed, double time)
        {
            distanceTxbx.Text = "solution";
            answerTxbx.Text = (speed*time).ToString();
        }

        private void timeCalculate(double speed, double distance)
        {
            timeTxbx.Text = "solution";
            answerTxbx.Text = (distance/speed).ToString();
        }

        
        



    }
}

