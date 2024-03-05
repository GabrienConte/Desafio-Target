using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target_5
{
    public static class InverteString
    {
        public static string StringInvertida(string valor)
        {
            char[] charsValor = valor.ToCharArray()
                , charsInvertido = new char[charsValor.Length];

            int indexAux = 0;
            for(int i = charsValor.Length - 1; i >= 0; i--)
            {
                charsInvertido[indexAux] = valor[i];

                indexAux++;
            }
            return new string(charsInvertido);
        }
    }
}
