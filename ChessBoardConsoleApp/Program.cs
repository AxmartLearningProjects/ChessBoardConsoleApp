using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardConsoleApp
{
    class Program
    {
        static Board myBoard = new Board(8);

        static void Main(string[] args)
        {

            // show empty chess board

            printBoard(myBoard);


            // ask for x and y coordinates


            // calculate all legal moves 


            // print the chess board 

            Console.ReadKey();
        }

        private static void printBoard(Board myBoard)
        {

            // print the chess board using an X for the piece location and + sign for legal move
            for (int i = 0; i < myBoard.Size; i++)
            {
                for (int j = 0; j < myBoard.Size; j++)
                {
                    Cell c = myBoard.TheGrid[i, j];

                    if (c.CurrentlyOccupied)
                    {
                        Console.Write("X");
                    }
                    else if (c.LegalNextMove)
                    {
                        Console.Write("+");
                    }
                    else
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine();

            }

            Console.WriteLine("===========================================");
        }
    }
}
