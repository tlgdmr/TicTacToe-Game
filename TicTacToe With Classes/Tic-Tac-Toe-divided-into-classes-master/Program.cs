using System;

namespace TicTacToe
{
    class Program
    {   
        private static void Main(string[] args)
        {
            InitGame();
        }

        /// <summary>
        /// Menu Bar section, when the project start.
        /// </summary>
        public static void InitGame()
        {
            Console.Clear();

            Console.WriteLine("1 = Start the Game");
            Console.WriteLine("2 = About The Author");
            Console.WriteLine("3 = Exit");

            string choose = Console.ReadLine();

            if (choose == "1")
            {
                GameEngine.StartGame();
                return;
            }
            else if (choose == "2")
            {
                Author.DisplayAuthorInfo();
                return;
            }
            else if (choose == "3")
            {
                QuitGame.Exit();
                return;
            }
        }
    }
}
