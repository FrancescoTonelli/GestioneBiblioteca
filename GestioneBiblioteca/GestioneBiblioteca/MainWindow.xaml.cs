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
            InizializzaListaLibri();
        }

        private Biblioteca b;

        public void InizializzaListaLibri()
        {
            try
            {
                string nomeBiblioteca = "Alberico De Giglio";
                string indirizzo = "Via Non So 22";
                int oraApertura = 8;
                int oraChiusura = 20;
                Libro l = new Libro("Le relazioni pericolose", "Un tizio francese", 200, 1900, "Mondadori");
                Libro m = new Libro("Boh", "Un tizio", 100, 2000, "Mondadori");
                Libro n = new Libro("Manuale", "Tu", 300, 2010, "Mondadori");
                List<Libro> libri = new List<Libro>();
                libri.Add(l);
                libri.Add(m);
                libri.Add(n);
                b = new Biblioteca(nomeBiblioteca, indirizzo, oraApertura, oraChiusura, libri);
                lblNome.Content = b.Nome;
                lblIndirizzo.Content = b.Indirizzo;
                lblOrario.Content = oraApertura + "-" + oraChiusura;
                lblN.Content = b.Libri.Count;
                RiempiListBox();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public void RiempiListBox()
        {
            lstLibri.Items.Clear();
            for(int i = 0; i < b.Libri.Count; i++)
            {
                string durata = b.Libri[i].ReadingTime().ToString();
                if(durata == "3")
                {
                    durata = "superiore di 3 ore";
                }
                else
                {
                    durata = durata + "h";
                }
                lstLibri.Items.Add(b.Libri[i].ToString() + ", durata lettura:" +durata);
            }
        }

        private void btnCrea_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string l = txtCrea.Text;
                string[] line = l.Split('/');
                Libro n = new Libro(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), line[4]);
                b.AddLibro(n);
                RiempiListBox();
            }catch(Exception)
            {
                MessageBox.Show("Impossibile creare il libro");
            }
        }

        private void btnCercaTitolo_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblPosTitolo.Content = b.RicercaTitolo(txtTitolo.Text).ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCercaAutore_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lstLibriAutore.Items.Clear();
                List<Libro> l = b.RicercaAutore(txtTitolo_Copy.Text);
                for(int i = 0; i < l.Count; i++)
                {
                    lstLibriAutore.Items.Add(l[i].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
