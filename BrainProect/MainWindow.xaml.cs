﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
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

namespace BrainProect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Organ> list = new List<Organ>();
        private Coock coock;
        private Buyer buyer; 
        private SpeechSynthesizer synthesizer;

        public byte f = 0;
        public string[] burgers = new string[] { " Бургер", " Картошка фри", " Кола ", " Чизбургер", " Креветки ", " Молочный коктейль", " Бизнес ланч ", " Баскет ", " Сырные шарики" };

        public MainWindow()
        {
            InitializeComponent();
            synthesizer = new SpeechSynthesizer();
        coock = new Coock(this);
            coock.Show();
   
        }

        private void BtnTermAdd1_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            string text;
            Organ o = new Organ();

            do
            {
                int a = random.Next(100);
                char b = (char)random.Next('A', 'Z');
                text = b + "" + a;
                o.Id = text;
                if (!list.Contains(o)) list.Add(o);
            } while (!list.Contains(o));
            int c = random.Next(8);
            int g = random.Next(8);
            int m = random.Next(8);
            o.Description = burgers[c] + burgers[g] + burgers[m];
            
            Manager.MainFrame.Items.Add(o);
            coock.ListView3.Items.Add(o);
            //switch (c)
            //{
            //    case 1:
            //        coock.ListView3.Items.Add(text + " " + burgers[c] + " " + burgers[c + 1]);
            //        break;
            //    case 2:
            //        coock.ListView3.Items.Add(text + " " + burgers[c] + " " + burgers[c + 1]);
            //        break;
            //    case 3:
            //        coock.ListView3.Items.Add(text + " " + burgers[c] + " " + burgers[c + 1]);
            //        break;
            //    case 4:
            //        coock.ListView3.Items.Add(text + " " + burgers[c] + " " + burgers[c + 1] + " " + burgers[c - 2]);
            //        break;
            //    case 5:
            //        coock.ListView3.Items.Add(text + " " + burgers[c] + " " + burgers[c - 1]);
            //        break;
            //    case 0:
            //        coock.ListView3.Items.Add(text + " " + burgers[c]);
            //        break;
            //}

        }

        /*private void BtnTermAdd2_Click(object sender, RoutedEventArgs e)
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
            Manager.MainFrame.Items.Add(text);
            coock.ListView3.Items.Add(text);
        }*/

        /*private void BtnCashAdd1_Click(object sender, RoutedEventArgs e) // Создание рандомных заказов
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
            Manager.MainFrame.Items.Add(text);
            coock.ListView3.Items.Add(text);

        }*/

        /*private void BtnCashAdd2_Click(object sender, RoutedEventArgs e)
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
            Manager.MainFrame.Items.Add(text);
            coock.ListView3.Items.Add(text);
        }*/
    }
}
