using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Parcial_JhonCorzo
{
    /// <summary>
    /// Interaction logic for PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        public PageAdmin()
        {
            InitializeComponent();
            
        }

        private void btnAdminLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new PageLogIn());
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (DataGrid row in data)
            {

            }
        }
    }
}
