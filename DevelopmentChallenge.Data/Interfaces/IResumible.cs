using DevelopmentChallenge.Data.Classes;
using DevelopmentChallenge.Data.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevelopmentChallenge.Data.Interfaces
{
    internal interface IResumible
    {
        string ObtenerLinea(IEnumerable<FormaGeometrica> formas, FormaEnum formaEnum, IdiomaEnum idioma);
    }
}
