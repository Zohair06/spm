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
    /// Interaction logic for Timer.xaml
    /// </summary>
    public partial class Timer : Window
    {
        public Timer()
        {
            InitializeComponent();
        }

        private void nowStart(object sender, EventArgs e)
        {
            mntTb.Text = DateTime.Now.ToString("HH:mm");
            secTb.Text = DateTime.Now.ToString("ss");
            dateTb.Text = DateTime.Now.ToString("MMM dd yyyy");
            dayTb.Text = DateTime.Now.ToString("dddd");
        }

    }
}
