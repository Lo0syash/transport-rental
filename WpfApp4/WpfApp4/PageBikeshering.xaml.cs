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
    /// Логика взаимодействия для PageBikeshering.xaml
    /// </summary>
    public partial class PageBikeshering : Window
    {
        DBContainer5 db;
        public PageBikeshering()
        {
            InitializeComponent();
            db = new DBContainer5();
        }
        string goodText;
        private void Phone_TextChanged_1(object sender, TextChangedEventArgs e)
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
        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            PageMain RW = new PageMain();
            RW.Show();
            this.Close();

        }
        private void Go_ListenSmaokate(object sender, RoutedEventArgs e)
        {
            if (Name.Text == "" || Phone.Text == "")
            {
                MessageBox.Show("заполены не все поля");

            }
            else
            {
                Content newContent = new Content()
                {
                    Name = Name.Text,
                    Phone = Phone.Text,
                };
                db.ContentSet.Add(newContent);
                db.SaveChanges();
                Pagecomplete2 aw = new Pagecomplete2();
                aw.Show();
                this.Close();
            }
        }


        private void Name_TextInput(object sender, TextCompositionEventArgs e)
        {
            char inp = e.Text[0];
            if (inp < 'а' || inp > 'я')
                e.Handled = true;
        }

        private void Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Back || e.Key == Key.Space)
                e.Handled = true;
        }
    }
}
