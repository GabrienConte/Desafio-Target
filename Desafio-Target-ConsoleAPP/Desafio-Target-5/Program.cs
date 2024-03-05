using Desafio_Target_5;

bool isValorValido;

do
{
    Console.WriteLine("Insira um texto para inverter:");
    string valor = Console.ReadLine();
    if (!String.IsNullOrEmpty(valor.Trim()))
    {
        isValorValido = true;

        valor = InverteString.StringInvertida(valor);

        Console.WriteLine(String.Format("Seu texto invertido: {0}",valor));
    }
    else
    {
        isValorValido = false;
        Console.WriteLine("Nenhum valor inserido!");
    }
} while (!isValorValido);