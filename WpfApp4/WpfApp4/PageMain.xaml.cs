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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Window
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверны, что хотите выти из системы?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                PageAuth RW = new PageAuth();
                RW.Show();
                this.Close();
            }
        }
        private void Button_ClickInfo(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Компания Fluffy предоставляет услуги по аренде транспортов.\nХотите узнать подробнее?\nВыбирайте любой из предолженных транспортов на вашем экране");
        }
        private void Button_ClickWarn(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("На серверах платежных систем проходят технические работы. Оплата доступна только через карту!");
        }
        private void Button_ClickKikshering(object sender, RoutedEventArgs e)
        {
            PageKikshering RW = new PageKikshering();
            RW.Show();
            this.Close();
        }
        private void Button_ClickBikeshering(object sender, RoutedEventArgs e)
        {
            PageBikeshering RW = new PageBikeshering();
            RW.Show();
            this.Close();
        }
        private void Button_ClickCharter(object sender, RoutedEventArgs e)
        {
            PageCharter RW = new PageCharter();
            RW.Show();
            this.Close();
        }
        private void Button_ClickKarshering(object sender, RoutedEventArgs e)
        {
            PageKarshering RW = new PageKarshering();
            RW.Show();
            this.Close();
        }
    }
}
