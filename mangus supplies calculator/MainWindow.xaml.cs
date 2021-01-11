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

namespace mangus_supplies_calculator
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

        private void btncalc_Click(object sender, RoutedEventArgs e)
        {

            double dtxtprof = Convert.ToDouble(txtprof.Text);
            double dtxtstu = Convert.ToDouble(txtstu.Text);
            double dtxtstaff = Convert.ToDouble(txtstaff.Text);

            double dmasksquant = Math.Ceiling((dtxtprof * 5.5) + (dtxtstaff * 3.5) + (dtxtstu * 4.5));

            double dsaniquant = Math.Ceiling((dtxtprof * 1.2) + (dtxtstaff * .8) + (dtxtstu * 2.1));

            double dglovequant = Math.Ceiling((dtxtprof * 3.5) + (dtxtstaff * 2.8) + (dtxtstu * 2.5));


            double dmatexpense = (dmasksquant * 8.5) + (dsaniquant * 15.5) + (dglovequant * 6.5);

            double dpotexpense = (dtxtprof * 100) + (dtxtstaff * 80) + (dtxtstu * 150);

            double dtotal = Math.Round(dpotexpense - (dmatexpense + 250), 1);

            txtmask.Text = Convert.ToString(dmasksquant);
            txtsani.Text = Convert.ToString(dsaniquant);
            txtglove.Text = Convert.ToString(dglovequant);
            txttotal.Text = Convert.ToString(dtotal);



        }

        private void btnclear_Click(object sender, RoutedEventArgs e)
        {
            txtprof.Clear();
            txtstaff.Clear();
            txtstu.Clear();
            txtglove.Clear();
            txtmask.Clear();
            txtsani.Clear();
            txttotal.Clear();
        }

        private void txtstu_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
