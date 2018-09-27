using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz_znanja
{
    public class pitanja
    {
        private string _pitanje;
        private string _tocanOdgovor;
        private List<string> _hint;
        private List<string> _odgovori;
        public string Pitanje
        {
            get { return _pitanje; }
            set { _pitanje = value; }
        }
       
        public string TocanOdgovor
        {
            get { return _tocanOdgovor; }
            set { _tocanOdgovor = value; }
        }
        public List<string> Odgovori
        {
            get { return _odgovori; }
            set { _odgovori = value; }
        }
        public List<string> Hint
        {
            get { return _hint; }
            set { _hint = value; }
        }
        public  pitanja(string p, string to, List<string> od, List<string> h)
        {
            this.Pitanje = p;
            this.Odgovori = od;
            this.TocanOdgovor = to;
            this.Hint = h;
        }
    }
}
