using System;

class Program
{
    static void Main()
    {
      int Number = 0;
      int Saved = 0;
      Console.WriteLine("Type the amount you want to earn"); 
      if (int.TryParse(Console.ReadLine(), out Number) == false)
    {
         Console.WriteLine("Type a valid number");
    }
      else
        {
         Console.WriteLine("Now type how much you can save per month");
         if (int.TryParse(Console.ReadLine(), out Saved) == false)
        {
             Console.WriteLine("Type a valid number");
        }
            else
            {
                int Months = (int)Math.Ceiling((double)Number / Saved);
                Console.WriteLine($"You will need to save for {Months} months to reach your goal.");
            }
        }    
    }   
} 
