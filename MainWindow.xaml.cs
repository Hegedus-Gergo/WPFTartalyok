using Osztalyok;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Tartaly> elemek = new List<Tartaly>();
        List<string> listaforras = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            lbTartalyok.ItemsSource = listaforras;
            
                btnDuplaz.IsEnabled = false;
            btnLeenged.IsEnabled = false;
        }


        private void btnDuplaz_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex == -1)
            {
            }
            else
            {
                int index = lbTartalyok.SelectedIndex;
                elemek[index].DuplazMeretet();
                listaforras[index] = elemek[index].Info();
                lbTartalyok.Items.Refresh();
            }
        }

        private void btnLeenged_Click(object sender, RoutedEventArgs e)
        {
            if (lbTartalyok.SelectedIndex == -1)
            {
            }
            else
            {
                int index = lbTartalyok.SelectedIndex;
                elemek[index].TeljesLeengedes();
                listaforras[index] = elemek[index].Info();
                lbTartalyok.Items.Refresh();
            }
        }
       
        private void rdoKocka_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = false;
            txtBel.IsEnabled = false;
            txtCel.IsEnabled = false;
            txtAel.Text = "10";
            txtBel.Text = "10";
            txtCel.Text = "10";
        }

        private void rdoTeglatest_Checked(object sender, RoutedEventArgs e)
        {
            txtAel.IsEnabled = true;
            txtBel.IsEnabled = true;
            txtCel.IsEnabled = true;
            txtAel.Text = "";
            txtBel.Text = "";
            txtCel.Text = "";
        }

        private void btnFelvesz_Click(object sender, RoutedEventArgs e)
        {
            btnDuplaz.IsEnabled = true;
            btnLeenged.IsEnabled = true;
            Tartaly t = new Tartaly(txtNev.Text, Convert.ToInt32(txtAel.Text), Convert.ToInt32(txtBel.Text), Convert.ToInt32(txtCel.Text));
                elemek.Add(t);
                listaforras.Add(t.Info());
                lbTartalyok.Items.Refresh();
                StreamWriter sw = new StreamWriter("ki.csv", append: true);

                sw.Close();
        }

        private void btntolt_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Convert.ToDouble(txtMennyitTolt.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Számot kell megadni");
            }
            if (txtMennyitTolt > )
        }
    }
}
