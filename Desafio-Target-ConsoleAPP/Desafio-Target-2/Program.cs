using Desafio_Target_2;

int valor;
Console.WriteLine("Insira um valor para ser encontrado na sequência de Fiboonacci");

bool isValorValido, isFibonacci;

do
{
    if(int.TryParse(Console.ReadLine(), out valor))
    {
        isValorValido = true;
        isFibonacci = Fibonacci.VerificaNumero(valor);

        if(isFibonacci)
            Console.WriteLine(String.Format("O Valor {0} pertence a sequência de Fibonacci!", valor));
        else
            Console.WriteLine(String.Format("O Valor {0} NÃO pertence a sequência de Fibonacci!", valor));
    } else
    {
        isValorValido = false;
        Console.WriteLine("Valor inválido, coloque um número inteiro como entrada");
    }
} while(!isValorValido);