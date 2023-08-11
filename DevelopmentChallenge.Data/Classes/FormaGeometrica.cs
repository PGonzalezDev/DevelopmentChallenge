using DevelopmentChallenge.Data.Enums;
using DevelopmentChallenge.Data.Helpers;
using DevelopmentChallenge.Data.Interfaces;
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

            var formasAgrupadas = formas.GroupBy(x => x.GetType());

            foreach (var grupo in formasAgrupadas)
            {
                var firstResumible = grupo.First() as IResumible;
                var resumen = firstResumible.ObtenerLinea(grupo.ToList(), idioma);

                sb.Append(resumen);
            }

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
