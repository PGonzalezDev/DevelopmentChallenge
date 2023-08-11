using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevelopmentChallenge.Data.Classes
{
    public abstract class FormaGeometrica
    {
        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();

        public static string Imprimir(List<FormaGeometrica> formas, IdiomaEnum idioma)
        {
            var sb = new StringBuilder();

            if (formas == null || !formas.Any())
            {
                return LanguageHelper.ObtenerHeaderVacio(idioma);
            }

            sb.Append(LanguageHelper.ObtenerHeader(idioma));

            var cuadrados = formas.Where(x => x is Cuadrado);
            var circulos = formas.Where(x => x is Circulo);
            var triangulos = formas.Where(x => x is TrianguloEquilatero);
            var rectangulos = formas.Where(x => x is Rectangulo);

            sb.Append(Cuadrado.ObtenerLinea(cuadrados, idioma));
            sb.Append(Circulo.ObtenerLinea(circulos, idioma));
            sb.Append(TrianguloEquilatero.ObtenerLinea(triangulos, idioma));
            sb.Append(Rectangulo.ObtenerLinea(rectangulos, idioma));

            Totales totales = new Totales()
            {
                Cantidad = formas.Count,
                Perimetros = formas.Sum(x => x.CalcularPerimetro()),
                Areas = formas.Sum(x => x.CalcularArea())
            };

            sb.Append(LanguageHelper.ObtenerFooter(totales, idioma));

            return sb.ToString();
        }
    }
}
