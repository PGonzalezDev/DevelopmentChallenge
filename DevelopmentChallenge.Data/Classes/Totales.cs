using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Totales
    {
        public int Cantidad { get; set; }
        public decimal Areas { get; set; }
        public decimal Perimetros { get; set; }
        public Totales() { }

        public Totales(int cantidad, decimal areas, decimal perimetros)
        {
            Cantidad = cantidad;
            Areas = areas;
            Perimetros = perimetros;
        }
    }
}
