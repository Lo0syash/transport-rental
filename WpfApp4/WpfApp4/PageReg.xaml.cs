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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Window
    {
        DBContainer5 db;
        public PageReg()
        {
            InitializeComponent();
            db = new DBContainer5(); 
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            if (login.Text == "" || password.Password == "" )
            {
                MessageBox.Show("Ошибка пустые поля");
                return;
            }
            if (db.Users.Select(item => item.Login).Contains(login.Text))
            {
                MessageBox.Show("Такой логин существует в системе");
                return;
            }
            if (password.Password == password2.Password)
            {
                User newUser = new User()
                {
                    Login = login.Text,
                    Password = password.Password,
                    Email = email.Text,
                };
                db.Users.Add(newUser);
                db.SaveChanges();
                MessageBox.Show("Вы успешно зарегестрировались");
                PageAuth aw = new PageAuth();
                aw.Show();
                this.Close();
            }
            else
                MessageBox.Show("Пароли не совпадают");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PageAuth aw = new PageAuth();
            aw.Show();
            this.Close();
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
