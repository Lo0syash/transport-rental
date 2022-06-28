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
    /// Логика взаимодействия для PageKiksheringRidev2_3.xaml
    /// </summary>
    public partial class PageKiksheringRidev2_3 : Window
    {
        public PageKiksheringRidev2_3()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageKiksheringRidev2_2 aw = new PageKiksheringRidev2_2();
            aw.Show();
            this.Close();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PageKiksheringRidev2 aw = new PageKiksheringRidev2();
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
