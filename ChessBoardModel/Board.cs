using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoardModel
{
    class Board
    {

        public int Size { get; set; }

        public Cell[,] TheGrid { get; set; }

        public Board(int size)
        {
            // The inital board size is defined by size
            Size = size;

            // create a new 2D array of type cell
            TheGrid = new Cell[Size, Size];


            // fill the 2D array with new Cells, each with unique x and y coordinates
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j] = new Cell(i, j);
                }
            }

        }

    }
}
