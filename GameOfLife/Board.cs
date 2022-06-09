using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Board
    {
        private readonly Random random = new Random();
        public readonly Cell[,] Cells;
        public readonly int CellSize;
        public int numberOfLivingCells = 0;

        public int Columns { get { return Cells.GetLength(0); } }
        public int Rows { get { return Cells.GetLength(1); } }
        public int Width { get { return Columns * CellSize; } }
        public int Height { get { return Rows * CellSize; } }

        public Board(int width, int height, int cellSize, double liveDensity = 0.1)
        {
            CellSize = cellSize;
            Cells = new Cell[width / cellSize, height / cellSize];
            for (int x = 0; x < Columns; x++)
                for (int y = 0; y < Rows; y++)
                    Cells[x, y] = new Cell();
            MakeNeighhobs();
        }

        public void life() 
        {
            foreach (var cell in Cells)
                cell.DetermineState();

            foreach (var cell in Cells)
            {
                cell.Life();
                if (cell.isAlive)
                    numberOfLivingCells += 1;
            }
        }

        private void MakeNeighhobs()
        {
            for (int x = 0; x < Columns; x++) 
            {
                for (int y = 0; y < Rows; y++)
                {
                    int leftCellsXValue = (x > 0) ? x - 1 : Columns - 1;
                    int rightCellsXValue = (x < Columns - 1) ? x + 1 : 0;

                    int topCellsYValue = (y > 0) ? y - 1 : Rows - 1;
                    int bottumCellsYValue = (y < Rows - 1) ? y + 1 : 0;

                    Cells[x, y].neighbors.Add(Cells[leftCellsXValue, y]);
                    Cells[x, y].neighbors.Add(Cells[rightCellsXValue, y]);

                    Cells[x, y].neighbors.Add(Cells[x, topCellsYValue]);
                    Cells[x, y].neighbors.Add(Cells[x, bottumCellsYValue]);

                    Cells[x, y].neighbors.Add(Cells[leftCellsXValue, topCellsYValue]);
                    Cells[x, y].neighbors.Add(Cells[leftCellsXValue, bottumCellsYValue]);

                    Cells[x, y].neighbors.Add(Cells[rightCellsXValue, topCellsYValue]);
                    Cells[x, y].neighbors.Add(Cells[rightCellsXValue, bottumCellsYValue]);
                }
            }
        }

        public void Randomize(double liveDensity)
        {
            foreach (var cell in Cells)
                cell.isAlive = random.NextDouble() < liveDensity;
        }
    }
}
