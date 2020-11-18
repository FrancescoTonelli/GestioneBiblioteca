using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestioneBiblioteca
{



    public class ClasseBiblioteca(string nome, string indirizzo, int apertura, int chiusura, List<Libro> libri)
    {
        Nome = nome;
        Indirizzo = indirizzo;
        if(Apertura<Chiusura)
        {
           Apertura = apertura;
           Chiusura = chiusura;
        }
        else
        {
            throw new Exception(" Apertura e chiusura non validi");
        }

   }

    
    public string  _nome;
     public string  Nome
    {
        get
        {
            retutn _nome;
        }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new Exception("Nome non valido");
            }
               _nome = value;
        }
    }

      public string _indirizzi;
      public string Indirizzi
      {
       get
       {
         return _indirizzi;
       }

       set
       {
         if(string.IsNullOrWhiteSpace(value))
         {
             throw new Exception("Indirizzo non valido");
          }
          
        _indirizzi = value;
       }

      }

       private List<Libro> _libri;
       public List<libro> Libri
       {
          get
          {
             retutn _libri;
          }
         set
         {
            if(value.Count < 1)
            {
              throw new Exception("lista libri non Presente")
            }
             _libri = value;
         }
       }
       public int _chiusura;
       public int Chiusura
       {
       get
       {
        return _chiusura;
       }
       set
       {
            if(value < 1 && value > 24)
            {
            throw new Exception("Chiusura non valida");
            }
        _chiusura = value;
       }


       }


      public void AddLibro(Libro libro)
      {
           Libri.Add(libro);
      }
  
       public Libro RicercaTitolo(string titolo)
       {
           for (int i = 0; i < libri.Count; i++)
    {
               if(Titolo[i].Titolo == titolo)
               {
                   Titolo.Add(Titolo[i]);
               }
           }
    return titolo;
       }

public List<Libro> RicercaAutore(string autore)
{
    List<Libro> libri = new List<Libro>;
    {
       for (int i = 0; i < libri.Count; i++)
        {
            if(Libri[i].Autore == autore)
            {
                Libri.Add(Libri[i]);
            }
        }
        return libri;
                
    }
}

public int NumeroLibri()
{
    return Libri.Count();
}

}