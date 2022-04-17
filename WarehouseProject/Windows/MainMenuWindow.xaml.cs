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

namespace WarehouseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для MainMenuWindow.xaml
    /// </summary>
    public partial class MainMenuWindow : Window
    {
        public MainMenuWindow()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnWorkingWithProduct_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnReference_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortingArticle_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortingTheName_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortingSectionNumber_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSortinTheNameList_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAddProduct_Click(object sender, RoutedEventArgs e)
        {
            AddProductWindow openwindow = new AddProductWindow();
            openwindow.Show();
            this.Close();
        }

        private void bntDeleteItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}