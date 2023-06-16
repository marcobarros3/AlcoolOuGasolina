using System;

class Program {
  public static void Main (string[] args) {

          Console.ForegroundColor = ConsoleColor.DarkGreen;
          Console.WriteLine("--- Etanol ou Gasolina? ---\n");

Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.Write("Digite o preço do etanol (R$).....: ");
decimal etanol = Convert.ToDecimal(Console.ReadLine());

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.Write("Digite o preço da gasolina (R$)...: ");
decimal gasolina = Convert.ToDecimal(Console.ReadLine());

string recomendacao;

if (AbastecerComGasolina(etanol, gasolina))
{
    recomendacao = "Gasolina";
}
else
{
 Console.ForegroundColor = ConsoleColor.DarkYellow;   
  recomendacao = "Etanol";
}

double razao = RazaoEtanolGasolina(etanol, gasolina) * 100;

    Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine($"\nO preço do etanol corresponde a {razao:N1}% do preço da gasolina.");
Console.WriteLine($"\nRecomendação: Abasteça com {recomendacao.ToUpper()}.");

double RazaoEtanolGasolina(decimal precoEtanol, decimal precoGasolina)
{
    return Convert.ToDouble(precoEtanol / precoGasolina);
}

bool AbastecerComGasolina(decimal precoEtanol, decimal precoGasolina)
{
    const double MinRazaoUsoGasolina = 0.73;
    return RazaoEtanolGasolina(precoEtanol, precoGasolina) >= MinRazaoUsoGasolina;
}
     
        static void ResetarCor()
        {
            Console.ResetColor();
        }

        static void LimparTela()
        {
            Console.Clear();
        }

        static void PularLinha()
        {
            Console.WriteLine();
        }
    }
  }