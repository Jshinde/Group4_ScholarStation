using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using DataAccessControler;
using System.Data;
using System.Collections;
using System;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Navigation;

namespace Scholar_Station
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            mainWindowFrame.NavigationService.Navigate(new logInFrame());
        }
       
    }
}