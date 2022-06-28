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
    /// Логика взаимодействия для PageBank.xaml
    /// </summary>
    public partial class PageBank : Window
    {
        public PageBank()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (number.Text =="" || cvv.Text == "" || date.Text == "")
            {
                MessageBox.Show("Введены не все значения");
            }
            else {
                MessageBox.Show("Оплата прошла успешно");
                PageMain aw = new PageMain();
                aw.Show();
                this.Close();
            }

        }
        string goodText;
        private void Num_TextChanged_1(object sender, TextChangedEventArgs e)
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
    }
}
