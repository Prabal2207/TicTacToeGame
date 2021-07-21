using System;
namespace Tictactoe1
{
    public class TicTacToeGame
    {
       public char[] board = new char[10];
        public char[] tictactoe()
        {
             
            for(int i=1;i<10;i++)
            {
                board[i] = ' ';
            }
            return board;
            
        }
        public char ChooseXorO()
        {
            Console.Write("Enter X or O : ");
            char UserChoice = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(char.ToUpper(UserChoice));
            if (UserChoice == 'X')
            {
                Console.WriteLine("Player's letter is X.");

            }
            else if (UserChoice == 'O')
            {
                Console.WriteLine("Player's letter is O.");

            }
            else
            {
                Console.WriteLine("Error. You have to choose X or O only.");
            }
            return UserChoice;
        }
            public void boardgame(char[] board)

            {

             Console.WriteLine("     |     |      ");
             Console.WriteLine("  {0}  |  {1}  |  {2}", board[1], board[2], board[3]);
             Console.WriteLine("_____|_____|_____ ");
             Console.WriteLine("     |     |      ");
             Console.WriteLine("  {0}  |  {1}  |  {2}", board[4], board[5], board[6]);
             Console.WriteLine("_____|_____|_____ ");
             Console.WriteLine("     |     |      ");
             Console.WriteLine("  {0}  |  {1}  |  {2}", board[7], board[8], board[9]);
             Console.WriteLine("     |     |      ");

            }

        

    }
}
