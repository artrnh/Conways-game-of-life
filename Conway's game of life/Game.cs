using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Conway_s_game_of_life
{
    class Game
    {
        private const int rows = 50;
        private const int column = 50;
        private const int cellSize = 10;
        private Grid oldGrid;

        public Game()
        {
            oldGrid = CreateGrid(rows, column);
        }

        private Grid CreateGrid(int rows, int columns)
        {
            int rowCount = 0;
            Grid grid = new Grid();

            for (int i = 0; i < rows; i++)
            {
                grid.AddRowBottom();
            }

            foreach (Row row in grid.rows)
            {
                for (int i = 0; i < columns; i++)
                {
                    row.AddCellRight(rowCount, i);
                }
                rowCount++;
            }

            return grid;
        }

        public void Draw(Graphics graphics)
        {
            Point startPoint = new Point(5, 5);
            Point currentPoint = startPoint;

            foreach (Row row in oldGrid.rows)
            {
                foreach (Cell cell in row.cells)
                {
                    Rectangle cellRect = new Rectangle(currentPoint.X, currentPoint.Y, cellSize, cellSize);
                    cell.rectangle = cellRect;
                    if (cell.alive)
                        graphics.FillRectangle(Brushes.Black, cellRect);
                    else if (!cell.alive)
                        graphics.FillRectangle(Brushes.White, cellRect);

                    currentPoint = new Point((currentPoint.X + cellSize + 1), currentPoint.Y);
                }
                currentPoint = new Point(startPoint.X, (currentPoint.Y + cellSize + 1));
            }
        }

        public void ClickCell(int mouseX, int mouseY)
        {
            foreach (Row row in oldGrid.rows)
            {
                foreach (Cell cell in row.cells)
                {
                    if (cell.rectangle.Contains(mouseX, mouseY))
                    {
                        cell.alive = true;
                        cell.nextAlive = true;
                    }
                }
            }
        }

        public void Clear()
        {
            foreach (Row row in oldGrid.rows)
            {
                foreach (Cell cell in row.cells)
                {
                    cell.alive = false;
                }
            }
        }
    }
}
