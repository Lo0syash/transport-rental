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
    /// Логика взаимодействия для Pagecomplete2.xaml
    /// </summary>
    public partial class Pagecomplete2 : Window
    {
        DBContainer5 db;
        public Pagecomplete2()
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
            if (Minute.Text == "")
                label_wrap.Text = "";
            else
            {
                if (b == 1)
                {
                    double a = Convert.ToInt32(Minute.Text);
                    a = (a * 7) + 370;
                    label_wrap.Text = a.ToString();
                }
                if (b == 0)
                {
                    double a = Convert.ToInt32(Minute.Text);
                    a = (a * 7) + 335;
                    label_wrap.Text = a.ToString();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (a == 0)
            {
                Car newCar = new Car()
                {
                    Minute = Minute.Text,
                    Price = label_wrap.Text,
                    Trans = Cb.Text,
                };
                db.Cars.Add(newCar);
                db.SaveChanges();
                MessageBox.Show("заявка отправлена, ожидайте звонка");
            }
            if (a == 1)
            {
                Car newCar = new Car()
                {
                    Minute = Minute.Text,
                    Price = label_wrap.Text,
                    Trans = Cb.Text,
                };
                db.Cars.Add(newCar);
                db.SaveChanges();
                MessageBox.Show("заявка отправлена, ожидайте звонка");

            }
            if (a == 2)
            {
                Car newCar = new Car()
                {
                    Minute = Minute.Text,
                    Price = label_wrap.Text,
                    Trans = Cb.Text,
                };
                db.Cars.Add(newCar);
                db.SaveChanges();
                MessageBox.Show("заявка отправлена, ожидайте звонка");
            }
            if (a == 3)
            {
                Car newCar = new Car()
                {
                    Minute = Minute.Text,
                    Price = label_wrap.Text,
                    Trans = Cb.Text,
                };
                db.Cars.Add(newCar);
                db.SaveChanges();
                MessageBox.Show("заявка отправлена, ожидайте звонка");
            }
        }
        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            PageBikeshering RW = new PageBikeshering();
            RW.Show();
            this.Close();

        }

    }
}
