using System;
using System.Threading;
using Boulangerie.Models;

namespace Boulangerie
{
  class Program
  {

    static void Main()
    {
      Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~**~*~*~*~*~");
      Console.WriteLine("bienvenue à la boulangerie Pierre de Epicodus!");
      langHandler();

      Bread newBread = new Bread(7);
    }

    static void langHandler()
    {
      Console.WriteLine("pour le français entrez 1");
      Console.WriteLine("for english enter 2");
      try
      {
        int langSelect = Int32.Parse(Console.ReadLine());
        if (langSelect == 1)
        {
          French();
        }
        else if (langSelect == 2)
        {
          English();
        }
        else
        {
            Console.WriteLine("Please enter 1 or 2");
            langHandler();
        }
      }
      catch (FormatException ex)
      {
        Console.WriteLine("{0} please enter 1 or 2", ex.Message);
        langHandler();
      }
    }

    static void French()
    {
          Console.WriteLine("francais");
    }
    
    static void English()
    {
          Console.WriteLine("Nous ne servons pas les clients qui ne peuvent pas parler français");
          Console.WriteLine("redirection.........");
          Thread.Sleep(2000);
          Console.WriteLine("welcome to generic uninteresting American pastries.");
          Console.WriteLine("today's pastries are: ${0}. buy 3, get one free.", Pastry.PastryUnitCost);
          Console.WriteLine("and bread is: ${0}. buy 2, get one free.", Bread.BreadUnitCost);
    }

  }
}
