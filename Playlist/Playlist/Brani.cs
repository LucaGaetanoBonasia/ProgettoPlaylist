using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class Brani
    {
        private string _titolo;
        private string _autore;
        private double _durata;

        public Brani(string titolo, string autore, double durata)
        {
            _autore = autore;
            _titolo = titolo;
            _durata = durata;
        }

        public string Titolo
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public double Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        public string toString()
        {
            return (_titolo + _autore + _durata);
        }

        public bool shortSong(double durata)
        {
            return (_durata < durata);
        }

    }
}
