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

        public void MarkNextLegalMoves(Cell currentCell, string chessPiece)
        {

            // clear the board
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    TheGrid[i, j].CurrentlyOccupied = false;
                    TheGrid[i, j].LegalNextMove = false;
                }
            }


            // find all legal moves and mark the cells as legal

            switch (chessPiece)
            {
                case "Knight":
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    TheGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;


                    break;

                case "King":
                    break;

                case "Rook":
                    break;

                case "Bishop":
                    break;

                case "Queen":
                    break;


                default:
                    break;
            }

        }


    }
}
