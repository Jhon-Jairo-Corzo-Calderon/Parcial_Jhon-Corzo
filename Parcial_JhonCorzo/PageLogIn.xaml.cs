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
    /// Interaction logic for PageLogIn.xaml
    /// </summary>
    public partial class PageLogIn : Page
    {
        public PageLogIn()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string usuario = txtUsername.Text;
            string password = txtPassword.Password;

            if (usuario == "admin" && password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new PageAdmin());
            }
            else if ((usuario == "empleado")  && txtPassword.Password == "1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.mainFrame.NavigationService.Navigate(new PageEmpleado());
            }
            else
            {
                MessageBox.Show("Invalid Credentials");
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            txtPassword.Password = "";
            txtUsername.Text = "";
        }
    }
}
