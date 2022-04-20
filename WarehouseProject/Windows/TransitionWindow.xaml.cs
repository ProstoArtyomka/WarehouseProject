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

namespace WarehouseProject.Windows
{
    /// <summary>
    /// Логика взаимодействия для TransitionWindow.xaml
    /// </summary>
    public partial class TransitionWindow : Window
    {
        public TransitionWindow()
        {
            InitializeComponent();
        }

        private void btnWorkingWithProduct_Click(object sender, RoutedEventArgs e)
        {
            Frame.Source = new Uri("..\\..\\Pages\\HomePage.xaml", UriKind.RelativeOrAbsolute);
            //Для тестов работы листов
            //Frame.Source = new Uri("..\\..\\Pages\\AddProductPage.xaml", UriKind.RelativeOrAbsolute);
            //Frame.Source = new Uri("..\\..\\Pages\\AddProductMovePage.xaml", UriKind.RelativeOrAbsolute);
            //Frame.Source = new Uri("..\\..\\Pages\\StatementProductPage.xaml", UriKind.RelativeOrAbsolute);
            //Frame.Source = new Uri("..\\..\\Pages\\ContactCustomerSupportPage.xaml", UriKind.RelativeOrAbsolute);
            //Frame.Source = new Uri("..\\..\\Pages\\CustomerSupportPage.xaml", UriKind.RelativeOrAbsolute);
        }

        private void btnReference_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnGenerateReport_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
