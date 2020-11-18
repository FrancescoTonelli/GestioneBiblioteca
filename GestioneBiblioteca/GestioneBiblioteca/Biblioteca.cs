﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneBiblioteca
{
    public class Biblioteca
    {
        public Biblioteca()
        {

        }

        private string _nome;
        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Nome non valido");
                _nome = value;
            }
        }

        private string _indirizzo;
        public string Indirizzo
        {
            get
            {
                return _indirizzo;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    throw new Exception("Indirizzo non valido");
                _indirizzo = value;
            }
        }

        private int _apertuta;
        public int Apertuta
        {
            get
            {
                return _apertuta;
            }
            set
            {
                if(value < 0 || value > 24)
                {
                    throw new Exception("Apertuta non valida");
                }
                _apertuta = value;
            }
        }

        private int _chiusura;
        public int Chiusura
        {
            get
            {
                return _chiusura;
            }
            set
            {
                if (value < 0 || value > 24)
                {
                    throw new Exception("Chiusura non valida");
                }
                _chiusura = value;
            }
        }

        private List<Libro> _libri;
        public List<Libro> Libri
        {
            get
            {
                return _libri;
            }
            set
            {
                if (value.Count < 1)
                    throw new Exception("Lista di libri non valida, deve essere presente alemno un libro");
                _libri = value;
            }
        }
    }
}
