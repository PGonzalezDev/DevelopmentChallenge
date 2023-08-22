using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Classes
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;
        private decimal _radio { get { return _diametro / 2; } }
        
        public Circulo() { }

        public Circulo(decimal diametro)
        {
            _diametro = diametro;
        }

        public override decimal CalcularArea()
        {
            return (decimal)Math.PI * _radio * _radio;
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}
