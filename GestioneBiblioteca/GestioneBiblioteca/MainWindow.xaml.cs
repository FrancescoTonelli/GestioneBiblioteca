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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestioneBiblioteca
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private List<Libro> raccolta;

        public void InizializzaListaLibri()
        {
            raccolta = new List<Libro>();
            string nomeBiblioteca = "Alberico De Giglio";
            string indirizzo = "Via Non So 22";
            int oraApertura = 8;
            int oraChiusura = 20;

            Libro l = new Libro("Le relazioni pericolose")
            
        }

        public void RiempiListBox()
        {

        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string l = txtCrea.Text;
                string[] line = l.Split('/');
            }catch(Exception)
            {
                MessageBox.Show("Impossibile creare il libro");
            }
        }

        private void btnCercaTitolo_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
