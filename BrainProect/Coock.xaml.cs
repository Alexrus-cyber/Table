using System;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace BrainProect
{
    /// <summary>
    /// Interaction logic for Coock.xaml
    /// </summary>
    public partial class Coock : Window
    {
        private MainWindow main;
        private Buyer buyer;
        public DispatcherTimer _timer;
        private SpeechSynthesizer synthesizer;
        public int h = 0;
        public int m = 0;
        public int s = 11;

        public Coock()
        {
            InitializeComponent();
        
        }
        public Coock(MainWindow main)
        {
            buyer = new Buyer(this);
            buyer.Show();
            this.main = main;
            Manager.MainFrame = buyer.ListView1;
            synthesizer = new SpeechSynthesizer();
           
            _timer = new DispatcherTimer();
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ListViewItem listViewItem = new ListViewItem();
            _timer.Tick += new EventHandler(timerTick);
            _timer.Interval = new TimeSpan(0, 0, 0, 0 , 1000);
            _timer.Start();

            if (s == 10)
            {
                _timer.Tick += new EventHandler(timerTick);
                _timer.Interval = new TimeSpan(0, 0, 0, 0, 2000);
                _timer.Start();
            }

            foreach (var item in main.list)               // Проверка листа на выделение, удаление выделенных элементов.
            {
                if (listViewItem != null)
                {
                        listViewItem.IsSelected = listViewItem.IsSelected;
                 
                        if (listViewItem.Content == listViewItem.Content)
                            {
                                Manager.MainFrame.Items.Remove(ListView3.SelectedItem);
                            }
                        buyer.ListView2.Items.Add(ListView3.SelectedItem);
                        
                        ListView3.Items.Remove(ListView3.SelectedItem);
                        
                    if (listViewItem.Content == null)
                            {
                                buyer.ListView2.Items.Remove(buyer.ListView2.SelectedItem);
                            }

                     
                }
            }

        }
        private void timerTick(object sender, EventArgs e)
        {
        
            s = s - 1;
            if (h == 0 && m == 0 && s == 0)
            {
                buyer.ListView2.Items.Clear();
                _timer.Stop();
                s = 10;
            }
        }
    }
}
