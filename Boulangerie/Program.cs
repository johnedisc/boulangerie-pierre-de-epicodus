using System;
using System.Threading;
using System.Collections.Generic;
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
      int langSelect = ValidateInteger(Console.ReadLine());
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

    static int ValidateInteger(string usrValue)
    {
      try
      {
        return Int32.Parse(usrValue);
      }
      catch (FormatException ex)
      {
        Console.WriteLine("{0} please enter an integer.", ex.Message.ToLower());
        return 0;
      }
    }

    static void French()
    {
      Console.WriteLine("today's pastries are: ${0}. buy 3, get one free.", Pastry.PastryUnitCost);
      Console.WriteLine("and bread is: ${0}. buy 2, get one free.", Bread.BreadUnitCost);
      List<int> order = new List<int>(takeOrder("en"));
    }
    
    static void English()
    {
          Console.WriteLine("Nous ne servons pas les clients qui ne peuvent pas parler français");
          Console.WriteLine("redirection.........");
          Thread.Sleep(2000);
          Console.WriteLine("welcome to generic uninteresting American pastries.");
          Console.WriteLine("today's pastries are: ${0}. buy 3, get one free.", Pastry.PastryUnitCost);
          Console.WriteLine("and bread is: ${0}. buy 2, get one free.", Bread.BreadUnitCost);
          List<int> order = new List<int>(takeOrder("en"));
    }

    static List<int> takeOrder(string language)
    {
      List<int> order = new List<int>();
      if (language == "en")
      {
        Console.WriteLine("how many pastries can we get you?");
        Console.WriteLine("(choose an integer greater than or equal to 0)");
        order.Add(ValidateInteger(Console.ReadLine()));
        Console.WriteLine("how many loaves of bread can we get you?");
        Console.WriteLine("(choose an integer greater than or equal to 0)");
        order.Add(ValidateInteger(Console.ReadLine()));
        return order;
      }
      else
      {
        Console.WriteLine("how many pastries can we get you?");
        Console.WriteLine("(choose an integer greater than or equal to 0)");
        order.Add(ValidateInteger(Console.ReadLine()));
        Console.WriteLine("how many loaves of bread can we get you?");
        Console.WriteLine("(choose an integer greater than or equal to 0)");
        order.Add(ValidateInteger(Console.ReadLine()));
        return order;
      }
    }
  }
}
