using System;

namespace Tictactoe1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to tictactoe!");
            char[] board;
            TicTacToeGame obj = new TicTacToeGame();
            board = obj.tictactoe();
            obj.ChooseXorO();
            obj.boardgame(board);



            Console.ReadKey();

        }

    }
}
