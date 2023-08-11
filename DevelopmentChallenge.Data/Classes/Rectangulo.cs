using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _largo;
        private readonly decimal _ancho;

        public Rectangulo() { }

        public Rectangulo(decimal largo, decimal ancho)
        {
            _largo = largo;
            _ancho = ancho;
        }

        public override decimal CalcularArea()
        {
            return _largo * _ancho;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (_largo + _ancho);
        }

        public static string ObtenerLinea(IEnumerable<FormaGeometrica> formas, IdiomaEnum idioma)
        {
            if (formas != null && formas.Any())
            {
                Totales totales = new Totales()
                {
                    Cantidad = formas.Count(),
                    Perimetros = formas.Sum(x => x.CalcularPerimetro()),
                    Areas = formas.Sum(x => x.CalcularArea())
                };

                return LanguageHelper.ObtenerLineaTraducida(totales, FormaEnum.Rectangulo, idioma);
            }

            return string.Empty;
        }
    }
}
