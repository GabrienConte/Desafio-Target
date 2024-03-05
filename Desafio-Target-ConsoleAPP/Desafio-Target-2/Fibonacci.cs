using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Target_2
{
    public static class Fibonacci
    {
        private static int valorAnterior = 0;
        private static int valorAnterior2 = 1;
        public static bool VerificaNumero(int valor)
        {
            bool pertenceFibonacci = false;
            int proximoValor;
            while(!pertenceFibonacci && valor >= valorAnterior)
            {
                proximoValor = valorAnterior + valorAnterior2;
                valorAnterior = valorAnterior2;
                valorAnterior2 = proximoValor;

                if(valor == valorAnterior)
                    pertenceFibonacci = true;
            }
            return pertenceFibonacci;
        }
    }
}
