using System;

namespace Tictactoe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tictactoe!");
            TicTacToeGame obj = new TicTacToeGame();
            obj.tictactoe();
            obj.ChooseXorO();

            Console.ReadKey();

        }

    }
}
