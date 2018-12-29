using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace CursoCore.CrossCutting.Extensions
{
    public static class StringExtensions
    {
        public static string SomenteNumeros(this string strIn)
        {
            if (strIn != null)
            {
                var somentenumeros = new String(strIn.Where(c => Char.IsDigit(c)).ToArray());
                return somentenumeros;
            }
            return "";
        }

        public static string SomenteLetras(this string strIn)
        {
            if (strIn != null)
            {
                var somenteletras = new String(strIn.Where(c => Char.IsLetter(c)).ToArray());
                return somenteletras;
            }
            return "";
        }

        public static decimal ConverteParaDecimal(this string strIn, string masc)
        {
            var retorno = decimal.Parse(string.Format(CultureInfo.GetCultureInfo("pt-BR"), masc, strIn));
            return retorno;
        }

        public static string FormatoCpfCnpj(this string strIn)
        {
            if (!string.IsNullOrEmpty(strIn))
            {
                if(strIn.Length == 11) // cpf
                {
                    return strIn.Substring(0, 3) + "." + strIn.Substring(4, 3) + "." + strIn.Substring(7, 3) + "-" + strIn.Substring(10, 2);
                }
                if (strIn.Length == 14) // cnpj
                {
                    return strIn.Substring(0, 2) + "." + strIn.Substring(3, 3) + "." + strIn.Substring(6, 3) + "/" + strIn.Substring(8, 4) + "-" + strIn.Substring(13,2);
                }
            }
            return string.Empty;
        }
    }
}
