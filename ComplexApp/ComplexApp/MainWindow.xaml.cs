using System;
using System.Windows;
using ComplexLib;

namespace ComplexApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Add_button_Click(object sender, RoutedEventArgs e)
        {
            Complex z1 = new Complex(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text));
            Complex z2 = new Complex(Convert.ToDouble(c.Text), Convert.ToDouble(d.Text));
            Complex res = z1 + z2;

            result.Content = res.ToString();
        }

        private void Subtract_button_Click(object sender, RoutedEventArgs e)
        {
            Complex z1 = new Complex(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text));
            Complex z2 = new Complex(Convert.ToDouble(c.Text), Convert.ToDouble(d.Text));
            Complex res = z1 - z2;

            result.Content = res.ToString();
        }

        private void Multiply_button_Click(object sender, RoutedEventArgs e)
        {
            Complex z1 = new Complex(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text));
            Complex z2 = new Complex(Convert.ToDouble(c.Text), Convert.ToDouble(d.Text));
            Complex res = z1 * z2;

            result.Content = res.ToString();
        }

        private void Divide_button_Click(object sender, RoutedEventArgs e)
        {
            Complex z1 = new Complex(Convert.ToDouble(a.Text), Convert.ToDouble(b.Text));
            Complex z2 = new Complex(Convert.ToDouble(c.Text), Convert.ToDouble(d.Text));
            Complex res = z1 / z2;

            result.Content = res.ToString();
        }
    }
}