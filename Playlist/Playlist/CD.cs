using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playlist
{
    class CD
    {
        private string _titolo;
        private string _autore;
        private List<Brani> _brani;

        public CD(string titolo, string autore)
        {
            _titolo = titolo;
            _autore = autore;
            _brani = new List<Brani>();
        }
        public string Titolo{get { return _titolo; }  set { _titolo = value; }}
       
        
        public string Autore
        {
            get { return _autore; }
            set { _autore = value; }
        }
        public void AggiungiBrano(Brani b)
        {
            _brani.Add(b);
        }
        public double Durata()
        {
            double totale = 0;
            foreach (Brani b in _brani)
            {
                totale += b.Durata;
            }
            return totale;
        }
       

    }
}
