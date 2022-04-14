using System;

namespace TicTacToeSubmissionConole
{
    class Program
    {
        int tempValue;


        static void Main(string[] args)
        {


            ConsoleColor oldColor = Console.ForegroundColor;

            Console.SetCursorPosition(30,2);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Tic Tac Toe");

            var ticTacToe = new TicTacToe();

            ticTacToe.Run();


            Console.ForegroundColor = oldColor ;


            Console.SetCursorPosition(20, 25);
            Console.WriteLine("Thank you for playing");
            Console.ReadLine();
        }
    }
}
