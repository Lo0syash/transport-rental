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
    /// Логика взаимодействия для PageKiksheringRidev3_3.xaml
    /// </summary>
    public partial class PageKiksheringRidev3_3 : Window
    {
        public PageKiksheringRidev3_3()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageKiksheringRidev3_2 aw = new PageKiksheringRidev3_2();
            aw.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageKiksheringRidev3 aw = new PageKiksheringRidev3();
            aw.Show();
            this.Close();
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На данынй момент, включен режим Eco");
        }
        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Завершить поездку?", "Состояние", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                PageEnd aw = new PageEnd();
                aw.Show();
               
                this.Close();
            }
        }
    }
}
