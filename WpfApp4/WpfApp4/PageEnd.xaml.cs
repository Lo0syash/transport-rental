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
    /// Логика взаимодействия для PageEnd.xaml
    /// </summary>
    public partial class PageEnd : Window
    {
        public PageEnd()
        {
            InitializeComponent();
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            PageBank aw = new PageBank();
            aw.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пока что недоступно");
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Пока что недоступно");
        }
    }
}
