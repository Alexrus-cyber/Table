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
        List<string> list1 = new List<string>();
        public byte f = 0;
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

            main.ListView1.Items.Add(text);
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
            main.ListView1.Items.Add(text);
        }

        private void BtnCashAdd1_Click(object sender, RoutedEventArgs e) // Создание рандомных заказов
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
            main.ListView1.Items.Add(text);
            //RadioButton rb = new RadioButton { IsChecked = false, Content = text + "\n" };
            //top.LetsGo.Children.Add(rb);
        }

        private void BtnCashAdd2_Click(object sender, RoutedEventArgs e)
        {
            //string text;
            //do
            //{
            //    int a = random.Next(100);
            //    char b = (char)random.Next('A', 'Z');
            //    text = b + "" + a;
            //    if (!list.Contains(text)) list.Add(text);
            //} while (!list.Contains(text));
            //main.NumberChange.Text += text + "\n";
            //if ()
            //{
            //    list = main.NumberChange.Text.Split('\n').ToList();

            //    list1.Add(list[list.Count - 1]);
            //    list.RemoveAt(list.Count - 1);

            //     main.NumberChange.Text = string.Join("\n", list.ToArray()); 
            //    f = 0;
            //    if (f == 0)
            //    {

            //       // main.NumberChangeReady.Text = list1[list1.Count - 1].ToString() + "\n";
            //        main.NumberChangeReady.Text = string.Join("", list1[list1.Count - 1].ToArray());

            //    }
            //}
            //if (list.Count > 0)
            //{
            //    main.ListView1.Items.RemoveAt(list[list.Count - 1]);

            //}
            ListViewItem listViewItem = new ListViewItem();

            foreach (var item in list)               // Проверка листа на выделение, удаление выделенных элементов.
            {
                if (listViewItem != null)
                {
                    listViewItem.IsSelected = listViewItem.IsSelected;
                    main.ListView2.Items.Add(main.ListView1.SelectedItem);
                    if (listViewItem.Content == null)
                    {
                        main.ListView2.Items.Remove(main.ListView2.SelectedItem);
                        main.ListView1.Items.Remove(main.ListView1.SelectedItem);
                    }
                    main.ListView1.Items.Remove(main.ListView1.SelectedItem);

                }
            }
            //main.ListView1.Items.Remove(main.ListView1.SelectedItem);


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {


        }
    }
}
