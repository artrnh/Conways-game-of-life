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
            //сгенерировать точки для каждой ячейки и вокруг них построить квадраты
        }
    }
}
