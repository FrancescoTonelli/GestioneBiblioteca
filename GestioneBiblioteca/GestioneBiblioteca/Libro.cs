using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBiblioteca
{
    class Libro
    {
        public Libro(string titolo,string autore, int numeroPagine, int annoPubblicazione, string editore)
        {
            try
            {
                Titolo = titolo;
                Autore = autore;
                NumeroPagine = numeroPagine;
                AnnoPubblicazione = annoPubblicazione;
                Editore = editore;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        private string _titolo;
        public string Titolo
        {
            get
            {
                return _titolo;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) == true)
                    throw new Exception("titolo non valido");
                _titolo = value;
            }
        }

        private string _autore;
        public string Autore
        {
            get
            {
                return _autore;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) == true)
                    throw new Exception("autore non valido");
                _autore = value;
            }
        }

        private int _numeroPagine;
        public int NumeroPagine
        {
            get
            {
                return _numeroPagine;
            }
            set
            {
                try
                {
                    if (value <= 0)
                        throw new Exception("il numero di pagine non può essere negativo o avere 0 pagine");
                    _numeroPagine = value;
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

        private int _annoPubblicazione;
        public int AnnoPubblicazione
        {
            get
            {
                return _annoPubblicazione;
            }
            set
            {
                try
                {
                    if (DateTime.Now.Year<value)
                        throw new Exception("questo libro proviene dal futuro? Come fa ad avere la data di pubblicazione futura?");
                    _annoPubblicazione = value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }

        private string _editore;
        public string Editore
        {
            get
            {
                return _editore;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value) == true)
                    throw new Exception("editore non valido");
                _editore = value;
            }
        }

        
    }
}
