using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevelopmentChallenge.Data.Classes
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero() { }

        public TrianguloEquilatero(decimal lado)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
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

                return LanguageHelper.ObtenerLineaTraducida(totales, FormaEnum.TrianguloEquilatero, idioma);
            }

            return string.Empty;
        }
    }
}
