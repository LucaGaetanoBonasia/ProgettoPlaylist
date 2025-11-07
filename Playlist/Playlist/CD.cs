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
        public string GetTitolo()
        {
            return _titolo;
        }
        public void SetTitolo(string titolo)
        {
            _titolo = titolo;
        }
        public string GetAutore()
        {
            return _autore;
        }
        public void SetAutore(string autore)
        {
            _autore = autore;
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
