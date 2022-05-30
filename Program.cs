using System;
using projetoPOORpg.src.Entities;

namespace projetoPOORpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 200, "Knight");
            Wizard wizard = new Wizard("Jenica", 899, "White Wizard");
            
            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));
            
        }
    }
}
