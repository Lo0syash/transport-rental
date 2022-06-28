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
using System.Timers;
using System.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Логика взаимодействия для PageAuth.xaml
    /// </summary>
    public partial class PageAuth : Window
    {
        DBContainer5 db;
        public PageAuth()
        {
            InitializeComponent();
            db = new DBContainer5();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageReg rw = new PageReg();
            rw.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (login.Text == "" && password.Password == "")
            {
                MessageBox.Show("Пустые поля");
                return;

            }
            if (login.Text == "" )
            {
                MessageBox.Show("Пустое поле логина");
                return;

            }
            if (password.Password == "")
            {
                MessageBox.Show("Пустое поле пароля");
                return;

            }
            if (db.Users.Select(item => item.Login + "" + item.Password).Contains(login.Text + "" + password.Password))
            {
                MessageBox.Show("Успешно");
                PageMain rw = new PageMain();
                rw.Show();
                this.Close();
            }
            else

                MessageBox.Show("ошибка логина/пароля");
        }
        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверны, что хотите завершить работу?", "Выход", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                this.Close();
            }
        }
    }
}
