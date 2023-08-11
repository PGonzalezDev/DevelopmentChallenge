using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public class Cuadrado : FormaGeometrica, IResumible
    {
        private readonly decimal _lado;

        public Cuadrado() { }

        public Cuadrado(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
        
        public string ObtenerLinea(IEnumerable<FormaGeometrica> formas, IdiomaEnum idioma)
        {
            if (formas != null && formas.Any())
            {
                Totales totales = new Totales()
                {
                    Cantidad = formas.Count(),
                    Perimetros = formas.Sum(x => x.CalcularPerimetro()),
                    Areas = formas.Sum(x => x.CalcularArea())
                };

                return LanguageHelper.ObtenerLineaTraducida(totales, FormaEnum.Cuadrado, idioma);
            }

            return string.Empty;
        }
    }
}
