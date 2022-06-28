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
    /// Логика взаимодействия для PageKiksheringRidev3_2.xaml
    /// </summary>
    public partial class PageKiksheringRidev3_2 : Window
    {
        public PageKiksheringRidev3_2()
        {
            InitializeComponent();
        }
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PageKiksheringRidev3_3 aw = new PageKiksheringRidev3_3();
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
            MessageBox.Show("На данынй момент, включен режим Drive");
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
