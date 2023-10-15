using System;
using System.Collections.Generic;
using System.Linq;

namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            char[,] board = new char[3,3];
 
            void InitializeBoard()
            {
                for (int row = 0; row < 3; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        board[row, col] = ' ';
                    }
                }
            }
            void PrintBoard()
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("   1  2  3");

                for (int row = 0; row < 3; row++)
                {
                    Console.Write((char)(Convert.ToInt32('A' + row)));
                    //Oszlop-elválasztók kiírása:
                    for (int col = 0; col < 3; col++)
                    {
                        Console.Write(board[row, col]);
                        if (col < 2)
                        {
                            Console.Write("  |");
                        }                                             
                    }
                    //Új sort kezdünk:
                    Console.WriteLine();

                    //Sor-elválasztók kiírása:
                    if (row < 2)
                    {
                        Console.WriteLine("  ---------");
                    }
                                        
                }
                Console.WriteLine();
            }
            bool PlaceMark(int row, int col, char mark)
            {
                if (board[row, col] == ' ') 
                {
                    board[row, col] = mark;
                    return true;
                }
                else
                {
                    Console.WriteLine("Az adott hely foglalt. Válassz másikat!");
                    return false;
                }
            }

            //Eljárás hívása:
            InitializeBoard();
            PrintBoard();
            bool gameOver = false;

            while (!gameOver) 
            {
                Console.Write("Sorszám: ");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("Oszlopszám: ");
                y = Convert.ToInt32(Console.ReadLine());
                if (x >= 0 && x < 3 && y >= 0 && y < 3)
                {
                    if (PlaceMark(x, y, '+'))
                    {
                        PrintBoard();
                        //Ellenőrzése annak, hogy van-e győztes.
                        //Váltás a következő játékosra.
                    }
                }
                else
                {
                    Console.WriteLine("Érvénytelen pozíció. Próbáld újra!");
                }
            }
            Console.ReadKey();

            
        }
    }
}
