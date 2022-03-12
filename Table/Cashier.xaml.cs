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

namespace Table
{
    /// <summary>
    /// Логика взаимодействия для Cashier.xaml
    /// </summary>
    public partial class Cashier : Window
    {
        private MainWindow main;
        List<string> list = new List<string>();

        public Cashier()
        {
            InitializeComponent();
        }

        public Cashier(MainWindow main)
        {
            this.main = main;
            InitializeComponent();
        }

        private void BtnTermAdd1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string text;
            do
            {
                int a = random.Next(100);
                char b = (char)random.Next('A', 'Z');
                text = b + "" + a;
                if (!list.Contains(text)) list.Add(text);
            } while (!list.Contains(text));
            main.NumberChange.Text += text + "\n";
        }

        private void BtnTermAdd2_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string text;
            do
            {
                int a = random.Next(100);
                char b = (char)random.Next('A', 'Z');
                text = b + "" + a;
                if (!list.Contains(text)) list.Add(text);
            } while (!list.Contains(text));
            main.NumberChange.Text += text + "\n";
        }

        private void BtnCashAdd1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string text;
            do
            {
                int a = random.Next(100);
                char b = (char)random.Next('A', 'Z');
                text = b + "" + a;
                if (!list.Contains(text)) list.Add(text);
            } while (!list.Contains(text));
            main.NumberChange.Text += text + "\n";
        }

        private void BtnCashAdd2_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string text;
            do
            {
                int a = random.Next(100);
                char b = (char)random.Next('A', 'Z');
                text = b + "" + a;
                if (!list.Contains(text)) list.Add(text);
            } while (!list.Contains(text));
            main.NumberChange.Text += text + "\n";
        }
    }
}
