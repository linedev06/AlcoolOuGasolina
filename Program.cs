
using System;

class Program
{
   static double CalcRazao(double etanol, double gasolina)
   {
       return etanol / gasolina;
   }

   static bool VerifyRecomendacao(double razao)
   {
       double percentualLimite = 0.73;
       return razao <= percentualLimite;
   }

   static void Main()
   {
       Console.WriteLine("Digite o preço do etanol (em R$): ");
       double precoEtanol = Convert.ToDouble(Console.ReadLine());

       Console.WriteLine("Digite o preço da gasolina (em R$): ");
       double precoGasolina = Convert.ToDouble(Console.ReadLine());

       double razao = CalcRazao(precoEtanol, precoGasolina);
       double razaoPorcentagem = razao * 100;

       Console.WriteLine();
       Console.WriteLine("Razão entre os preços: " + razaoPorcentagem.ToString("F0") + "%");

       bool recomendacao = VerifyRecomendacao(razao);

       if (recomendacao)
       {
           Console.ForegroundColor = ConsoleColor.DarkGreen;
           Console.WriteLine("Recomenda-se abastecer com gasolina.");
       }
       else
       {
           Console.ForegroundColor = ConsoleColor.DarkYellow;
           Console.WriteLine("Recomenda-se abastecer com etanol.");
       }

       Console.WriteLine();
       Console.ResetColor();
   }
}
