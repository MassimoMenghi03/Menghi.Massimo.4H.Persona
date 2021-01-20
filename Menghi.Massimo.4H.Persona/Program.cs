using System;

namespace Menghi.Massimo._4H.Persona
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona A = new Persona("Cognome", "Nome", "17");
            Persona B = new Persona("Nome", "Cognome", "22");

            B.Stampa(A, B);
        }
    }

    class Persona
    {
        string _cognome;
        string _nome;
        string _anni;

        public string Cognome
        {
            get
            {
                return _cognome;
            }
            set
            {
                _cognome = value;
            }
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public string Anni
        {
            get
            {
                return _anni;
            }
            set
            {
                _anni = value;
            }
        }

        public Persona(string c, string n, string e)
        {
            Cognome = c;
            Nome = n;
            Anni = e;
        }

        public string Stampa(Persona p, Persona q)
        {
            return $"{q.Cognome}";
        }

        public void Compleanno(string nAnni)
        {
            Anni = nAnni;
        }

        public bool Coetanei(Persona p, Persona q)
        {
            if(Convert.ToInt32(p.Anni) == Convert.ToInt32(q.Anni))
            {
                return true;
            }

            return false;
        }
        
    }
}
