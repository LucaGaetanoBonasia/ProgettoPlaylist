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
        private int _durata;

        public Brani(string titolo, string autore, int durata)
        {
            _autore = autore;
            _titolo = titolo;
            _durata = durata;
        }

        public string Titolo
        {
            get { return _titolo; }
            set { _titolo = value; }
        }

        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }

        public int Durata
        {
            get { return _durata; }
            set { _durata = value; }
        }

        public override string ToString()
        {
            return ($"Titolo:{_titolo} Autore:{_autore} Durata:{_durata} minut");
        }

        public bool shortSong(double durata)
        {
            return (_durata < durata);
        }

    }
}