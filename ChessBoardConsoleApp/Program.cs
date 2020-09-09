using ChessBoardModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

            Cell currentCell = setCurrentCell();
            currentCell.CurrentlyOccupied = true;

            // calculate all legal moves 

            myBoard.MarkNextLegalMoves(currentCell, chosenPiece());

            // print the chess board 
            printBoard(myBoard);
            Console.ReadKey();
        }

        private static string chosenPiece()
        {

            Console.WriteLine("Enter the name of the chess piece");
            string piece = Console.ReadLine().ToLower();

            while (true)
            {
                if (piece == "knight" || piece == "king" || piece == "rook" || piece == "queen" || piece == "bishop")
                {
                    return piece;
                }
                else
                {
                    Console.WriteLine("Please enter a valid piece name");
                    piece = Console.ReadLine();

                }
            }


        }

        private static Cell setCurrentCell()
        {

            // get x and y coordinate

            Console.WriteLine("Enter the row number");
            int currentRow;
            while (!int.TryParse(Console.ReadLine(), out currentRow) || currentRow >= myBoard.Size || currentRow < 0)
            {
                Console.WriteLine("Please enter a valid row number");
            }



            Console.WriteLine("Enter the column number");
            int currentColumn;
            while (!int.TryParse(Console.ReadLine(), out currentColumn) || currentColumn >= myBoard.Size || currentColumn < 0)
            {
                Console.WriteLine("Please enter a valid column number");
            }






            return myBoard.TheGrid[currentRow, currentColumn];
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
