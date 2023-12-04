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
using System.Xaml;
using System.Threading;
using System.IO;
namespace threads
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int count;
        public MainWindow()
        {
            InitializeComponent();
            Thread thread = new Thread(Unit), flow = new Thread(Box), flux = new Thread(Module), stream = new Thread(Bloc);
            thread.Start();
            flow.Start();
            flux.Start();
            stream.Start();
        }
        public static void Unit()
        {
            //TextBlock block = new TextBlock();
            for (count = 0; count < 100000; count++)
            {
                MessageBox.Show(count.ToString());
                //block.Text = count.ToString();
                //Thread.Sleep(100);
            }
        }
        public static void Box()
        {
            //TextBlock module = new TextBlock();
            for (count = 0; count < 100000; count++)
            {
                MessageBox.Show(count.ToString());
                //module.Text = count.ToString();
                //Thread.Sleep(100);
            }
        }
        public static void Module()
        {
            //TextBlock text_block = new TextBlock();
            for (count = 0; count < 100000; count++)
            {
                MessageBox.Show(count.ToString());
                //text_block.Text = count.ToString();
                //Thread.Sleep(100);
            }
        }
        public static void Bloc()
        {
            //TextBlock unit = new TextBlock();
            for (count = 0; count < 100000; count++)
            {
                MessageBox.Show(count.ToString());
                //unit.Text = count.ToString();
                //Thread.Sleep(100);
            }
        }
    }
}