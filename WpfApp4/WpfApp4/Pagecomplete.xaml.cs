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

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для Pagecomplete.xaml
    /// </summary>
    public partial class Pagecomplete : Window
    {
        DBContainer5 db;
        public Pagecomplete()
        {
            InitializeComponent();
            db = new DBContainer5();

        }
        int a;
        int b;
        string goodText;
        
        private void Cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Cb.SelectedIndex == 0)
            {
                a = 0;
            }
            if (Cb.SelectedIndex == 1)
            {
                a = 1;
            }
            if (Cb.SelectedIndex == 2)
            {
                a = 2;
            }
            if (Cb.SelectedIndex == 3)
            {
                a = 3;
            }
        }
        private void Check_Checked(object sender, RoutedEventArgs e)
        {
            if (Check.IsChecked == true)
                b = 1;
            else b = 0;
        }
        private void Minute_TextChanged(object sender, TextChangedEventArgs e)
        { 
            TextBox tb = sender as TextBox;
            if (double.TryParse(tb.Text, out double value))
                goodText = tb.Text;
            else
            {
                 tb.Text = goodText;
                 tb.CaretIndex = tb.Text.Length;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Cb.Text == "")
            {
                MessageBox.Show("Выберите самокат!");
            }
            else
            {

                if (a == 0)
                {
                    PageKiksheringRide aw = new PageKiksheringRide();
                    aw.Show();
                    this.Close();
                }
                if (a == 1)
                {
                    PageKiksheringRidev1 aw = new PageKiksheringRidev1();
                    aw.Show();
                    this.Close();

                }
                if (a == 2)
                {
                    PageKiksheringRidev2 aw = new PageKiksheringRidev2();
                    aw.Show();
                    this.Close();
                }
                if (a == 3)
                {
                    PageKiksheringRidev3 aw = new PageKiksheringRidev3();
                    aw.Show();
                    this.Close();
                }
            }
        }
        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            PageKikshering RW = new PageKikshering();
            RW.Show();
            this.Close();

        }

    }
}
