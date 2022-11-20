using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMine
{
    internal class DataStruct
    {
        private string fisier;
        private int frecventa;

        public DataStruct(string fisier, int frecventa) 
        {
            this.fisier = fisier;
            this.frecventa = frecventa;
        }

        public string getFisier()
        {
            return this.fisier;
        }

        public int getFrecventa()
        {
            return this.frecventa;
        }

        public void setFisier(string fisier)
        {
            this.fisier = fisier;
        }

        public void setFrecventa(int frecventa)
        {
            this.frecventa = frecventa;
        }
    }
}
