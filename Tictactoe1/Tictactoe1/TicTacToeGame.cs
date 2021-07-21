using System;
namespace Tictactoe1
{
    public class TicTacToeGame
    {
        int player = 1;
       public void tictactoe()
        {
            char[] board = new char[10];
            for(int i=1;i<10;i++)
            {
                board[i] = '_';
            }
        }
        public void ChooseXorO()
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

        }

    }
}
