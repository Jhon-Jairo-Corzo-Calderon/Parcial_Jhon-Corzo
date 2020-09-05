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
    /// Interaction logic for PageEmpleado.xaml
    /// </summary>
    public partial class PageEmpleado : Page
    {
        public PageEmpleado()
        {
            InitializeComponent();

            comboBoxBread.Items.Add("Aliñeado");
            comboBoxBread.Items.Add("No aliñeado");
            comboBoxBread.Items.Add("Especial");
        }

        public class PanInfo
        {
            public  string ClientName { get; set; }
            public  string ClientCC { get; set; }
            public  string Time { get; set; }
            public  string BreadKind { get; set; }
            public  string BreadAmount { get; set; }
            public  string Money { get; set; }
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.mainFrame.NavigationService.Navigate(new PageLogIn());

        }

        private void btnVender_Click(object sender, RoutedEventArgs e)
        {
            string clName = clientName.Text;

            int cedula=-1;
            try
            {
                cedula = Convert.ToInt32(clientCC.Text);               
            }
            catch (Exception x)
            {
                MessageBox.Show("Error en al digitar la cedula");
            }

            string breadClass;
            if (comboBoxBread.SelectedItem == null)
            {
                breadClass = "No class chosen";
            }
            else
            {
                breadClass = comboBoxBread.SelectedItem.ToString();
            }

            int valorPan = 1;
            if (breadClass=="Aliñeado")
            {
                valorPan = 1000;
            }
            else if(breadClass == "No aliñeado")
            {
                valorPan = 500;
            }
            else if (breadClass == "Especial")
            {
                valorPan = 2000;
            }


            int cantPanes=-1;
            try
            {
                cantPanes = Convert.ToInt32(clienteCant.Text);
            }
            catch (Exception x)
            {
                MessageBox.Show("Error en al digitar la cantidad de panes");
            }

            DateTime dateTime = DateTime.Now;

            string time = dateTime.ToString();

            int money = valorPan * cantPanes;
            string strmoney = Convert.ToString(money);

            if (clName=="" ||cedula==-1 ||breadClass == "No class chosen"|| cantPanes == -1 )
            {
                MessageBox.Show("Porfavor digite todos los datos.");
            }
            else
            {

                PanInfo cliente = new PanInfo();

                cliente.ClientName = clName;
                cliente.ClientCC = clientCC.Text;
                cliente.Time = time;
                cliente.BreadKind = breadClass;
                cliente.BreadAmount = clienteCant.Text;
                cliente.Money = strmoney;

                dataPan.Items.Add(cliente);
            }
            

        }

        
    }

}
