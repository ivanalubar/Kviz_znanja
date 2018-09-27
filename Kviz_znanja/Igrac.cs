using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kviz_znanja
{
    public class Igrac
    {
        private string _ime;
        private int _bodovi;
        public string Ime
        {
            get { return _ime; }
            set { _ime = value; }
        }
        public int Bodovi
        {
            get { return _bodovi; }
            set { _bodovi = value; }
        }
        public Igrac(string i, int b)
        {
            this.Ime = i;
            this.Bodovi = b;
        }
    }
}
