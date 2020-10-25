﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Plantville
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        protected static string user_name;
        protected static string server_url;
        public LogIn()
        {
            InitializeComponent();
        }

        private void Btn_login_Click(object sender, RoutedEventArgs e)
        {
            user_name = txb_login.Text;

            if (rdb_heroku.IsChecked == true){
                server_url = "http://plantville.herokuapp.com/";
            }
            else if (rdb_custom.IsChecked == true)
            {
                server_url = "https://postman-echo.com/post";
            }
            MainPage mainP = new MainPage();
            NavigationService.Navigate(mainP);
        }

        public static string getUName()
        {
            return user_name;
        }
    }
}