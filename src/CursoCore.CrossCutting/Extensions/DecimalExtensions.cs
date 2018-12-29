using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace CursoCore.CrossCutting.Extensions
{
    public static class DecimalExtensions
    {
        public static string Formatado(this decimal strIn, string masc)
        {
            var retorno = string.Format(string.Format(CultureInfo.GetCultureInfo("pt-BR"), masc, strIn));
            return retorno;
        }
    }
}
