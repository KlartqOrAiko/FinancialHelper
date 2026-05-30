using System;

class Program
{
    static void Main()
    {
      int Number = 0;
      int Guardado = 0;
      Console.WriteLine("Digite o quanto você quer ganhar"); 
      if (int.TryParse(Console.ReadLine(), out Number) == false)
    {
         Console.WriteLine("Digite um número válido");
    }
      else
        {
         Console.WriteLine("Agora digite o quanto você consegue guardar por mês");
         if (int.TryParse(Console.ReadLine(), out Guardado) == false)
        {
             Console.WriteLine("Digite um número válido");
        }
            else
            {
                int Meses = (int)Math.Ceiling((double)Number / Guardado);
                Console.WriteLine($"Você precisará guardar por {Meses} meses para alcançar seu objetivo.");
            }
        }    
    }   
}    