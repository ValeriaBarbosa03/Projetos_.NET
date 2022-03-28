using Projeto_Jogo.Entities;
using Projeto_Jogo.src.Entities;
using System;

namespace Projeto_Jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23,"Knight");
            Wizard wizard = new Wizard("Jennica", 99, "white wizard");

             Console.WriteLine(wizard.Attack(6));
             Console.WriteLine(wizard.Attack(1));
        }
    }
}
