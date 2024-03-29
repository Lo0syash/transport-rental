﻿using System;
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
    /// Логика взаимодействия для PageKarshering3.xaml
    /// </summary>
    public partial class PageKarshering3 : Window
    {
        DBContainer5 db;
        public PageKarshering3()
        {
            InitializeComponent();
            db = new DBContainer5();
        }
        private void Button_ClickExit(object sender, RoutedEventArgs e)
        {
            PageMain RW = new PageMain();
            RW.Show();
            this.Close();

        }
        private void Go_ListenCar(object sender, RoutedEventArgs e)
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
                MessageBox.Show("Ваша заявка отправлена, ожидайте звонка оператора");
            }

        }

        private void Button_Back(object sender, RoutedEventArgs e)
        {
            PageKarshering2 aw = new PageKarshering2();
            aw.Show();
            this.Close();
        }
        private void Button_Next(object sender, RoutedEventArgs e)
        {
            PageKarshering4 aw = new PageKarshering4();
            aw.Show();
            this.Close();
        }
    }
}
