using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using System.Text;

namespace DevelopmentChallenge.Data.Helpers
{
    public static class LanguageHelper
    {
        public static string ObtenerHeader(IdiomaEnum idioma)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return "<h1>Reporte de Formas</h1>";
                case IdiomaEnum.Ingles:
                    return "<h1>Shapes report</h1>";
                case IdiomaEnum.Italiano:
                    return "<h1>Relazione sulle forme</h1>";
                default:
                    return string.Empty;
            }
        }

        public static string ObtenerHeaderVacio(IdiomaEnum idioma)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return "<h1>Lista vacía de formas!</h1>";
                case IdiomaEnum.Ingles:
                    return "<h1>Empty list of shapes!</h1>";
                case IdiomaEnum.Italiano:
                    return "<h1>Elenco vuoto di forme!</h1>";
                default:
                    return string.Empty;
            }
        }

        public static string ObtenerFooter(Totales totalFormas, IdiomaEnum idioma)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0}:<br/>", TraducirTotal(idioma));
            sb.AppendFormat("{0} {1} ", totalFormas.Cantidad, TraducirForma(idioma, totalFormas.Cantidad == 1));
            sb.AppendFormat("{0} {1} ", TraducirPerimetro(idioma), totalFormas.Perimetros.ToString("#.##"));
            sb.AppendFormat("{0} {1}", TraducirArea(idioma), totalFormas.Areas.ToString("#.##"));

            return sb.ToString();
        }

        public static string ObtenerLineaTraducida(Totales totalForma, FormaEnum forma, IdiomaEnum idioma)
        {
            var sb = new StringBuilder();

            sb.AppendFormat("{0} {1}", totalForma.Cantidad, TraducirFormas(forma, idioma, totalForma.Cantidad == 1));
            sb.AppendFormat(" | {0} {1:#.##}", TraducirArea(idioma), totalForma.Areas);
            sb.AppendFormat(" | {0} {1:#.##} <br/>", TraducirPerimetro(idioma), totalForma.Perimetros);

            return sb.ToString();
        }

        private static string TraducirTotal(IdiomaEnum idioma)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                case IdiomaEnum.Ingles:
                    return "TOTAL";
                case IdiomaEnum.Italiano:
                    return "TOTALE";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirArea(IdiomaEnum idioma)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                case IdiomaEnum.Ingles:
                case IdiomaEnum.Italiano:
                    return "Area";

                default:
                    return string.Empty;
            }
        }

        private static string TraducirPerimetro(IdiomaEnum idioma)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                case IdiomaEnum.Italiano:
                    return "Perimetro";
                case IdiomaEnum.Ingles:
                    return "Perimeter";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirForma(IdiomaEnum idioma, bool singular)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return (singular) ? "forma" : "formas";
                case IdiomaEnum.Ingles:
                    return (singular) ? "shape" : "shapes";
                case IdiomaEnum.Italiano:
                    return (singular) ? "forma" : "forme";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirFormas(FormaEnum forma, IdiomaEnum idioma, bool singular)
        {
            switch (forma)
            {
                case FormaEnum.Cuadrado:
                    return TraducirCuadrado(idioma, singular);
                case FormaEnum.Circulo:
                    return TraducirCirculo(idioma, singular);
                case FormaEnum.TrianguloEquilatero:
                    return TraducirTriangulo(idioma, singular);
                case FormaEnum.Rectangulo:
                    return TraducirRectangulo(idioma, singular);
                default:
                    return string.Empty;
            }
        }

        private static string TraducirCuadrado(IdiomaEnum idioma, bool singular)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return (singular) ? "Cuadrado" : "Cuadrados";
                case IdiomaEnum.Ingles:
                    return (singular) ? "Square" : "Squares";
                case IdiomaEnum.Italiano:
                    return (singular) ? "Piazza" : "Piazze";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirCirculo(IdiomaEnum idioma, bool singular)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return (singular) ? "Círculo" : "Círculos";
                case IdiomaEnum.Ingles:
                    return (singular) ? "Circle" : "Circles";
                case IdiomaEnum.Italiano:
                    return (singular) ? "Cerchio" : "Cerchi";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirTriangulo(IdiomaEnum idioma, bool singular)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return (singular) ? "Triángulo" : "Triángulos";
                case IdiomaEnum.Ingles:
                    return (singular) ? "Triangle" : "Triangles";
                case IdiomaEnum.Italiano:
                    return (singular) ? "Triangolo" : "Triangoli";
                default:
                    return string.Empty;
            }
        }

        private static string TraducirRectangulo(IdiomaEnum idioma, bool singular)
        {
            switch (idioma)
            {
                case IdiomaEnum.Castellano:
                    return (singular) ? "Rectángulo" : "Rectángulos";
                case IdiomaEnum.Ingles:
                    return (singular) ? "Rectangle" : "Rectangles";
                case IdiomaEnum.Italiano:
                    return (singular) ? "Rettangolo" : "Rettangoli";
                default:
                    return string.Empty;
            }
        }
    }
}
