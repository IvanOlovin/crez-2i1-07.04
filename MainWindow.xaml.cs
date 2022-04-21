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

namespace crez_2i1_07._04
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        double startcena;
        double Dostavka;
        double Samovivoz;
        double summa;
        double sdacha;

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            Dostavka = 5000;
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            Samovivoz = 500;
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            startcena = 2500 + Dostavka + Samovivoz;
            cena.Content = startcena;
            summa = Convert.ToDouble(textBox1.Text);
            sdacha = summa - startcena;
            label4.Content = sdacha;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double Computer;
            double TV;

            switch (comboBox.SelectedIndex)
            {
                case 0:
                    Computer = 5000;
                    Image2_png.Source = new BitmapImage(new Uri("https://overclockers.ru/st/legacy/blog/281867/260905_O.jpg"));
                    break;
                case 1:
                    TV = 7000;
                    Image2_png.Source = new BitmapImage(new Uri("https://itc.ua/wp-content/uploads/2019/10/dsc09973.jpg"));
                    break;
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            summa = Convert.ToDouble(textBox1.Text);
        }
    }
}
