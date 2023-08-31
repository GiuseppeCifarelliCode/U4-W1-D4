using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
     internal class Cibo
    {
        public string Nome { get; set; }
        public double Prezzo { get; set; }

        public Cibo() { }
        public Cibo (string nome, double prezzo)
        {
            Nome = nome;
            Prezzo = prezzo;
        }
    }
}
