using System;
using System.Collections.Generic;
using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using NUnit.Framework;

namespace DevelopmentChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual(
                "<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Castellano)
            );
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual(
                "<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<FormaGeometrica>(), IdiomaEnum.Ingles)
            );
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<FormaGeometrica> { new Cuadrado(5M) };
            var resumen = FormaGeometrica.Imprimir(cuadrados, IdiomaEnum.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            { 
                new Cuadrado(5M),
                new Cuadrado(1M),
                new Cuadrado(3M),
            };
            var resumen = FormaGeometrica.Imprimir(cuadrados, IdiomaEnum.Ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5M),
                new Circulo(3M),
                new TrianguloEquilatero(4M),
                new Cuadrado(2M),
                new TrianguloEquilatero(9M),
                new Circulo(2.75M),
                new TrianguloEquilatero(4.2M)
            };
            var resumen = FormaGeometrica.Imprimir(formas, IdiomaEnum.Ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5M),
                new Circulo(3M),
                new TrianguloEquilatero(4M),
                new Cuadrado(2M),
                new TrianguloEquilatero(9M),
                new Circulo(2.75M),
                new TrianguloEquilatero(4.2M)
            };
            var resumen = FormaGeometrica.Imprimir(formas, IdiomaEnum.Castellano);


            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnRectanguloEnCastellano()
        {
            var cuadrados = new List<FormaGeometrica> { new Rectangulo(5M, 10M) };
            var resumen = FormaGeometrica.Imprimir(cuadrados, IdiomaEnum.Castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectángulo | Area 50 | Perimetro 30 <br/>TOTAL:<br/>1 forma Perimetro 30 Area 50", resumen);
        }
    }
}
