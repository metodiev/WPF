using System;
using System.Collections;
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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for Calculator.xaml
    /// </summary>
    /// 


    public partial class Calculator : Window
    {

        public static ArrayList numbers = new ArrayList();
        public static long sum;

        public Calculator()
        {
            InitializeComponent();
        }

        private void Button_1(object sender, RoutedEventArgs e)
        {
            numbers.Add(1);
        }

        private void Button_2(object sender, RoutedEventArgs e)
        {
            numbers.Add(2);
        }

        private void Button_Plus(object sender, RoutedEventArgs e)
        {
            foreach (int item in numbers)
            {
                sum += item;
            }
        }

        private void Button_Minus(object sender, RoutedEventArgs e)
        {
            foreach (int item in numbers)
            {
                sum -= item;
            }
        }

        private void Button_Equal(object sender, RoutedEventArgs e)
        {
            tbSettingText.Text = sum.ToString();




        }
    }
}
