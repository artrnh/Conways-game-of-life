using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_game_of_life
{
    class Row
    {
        internal List<Cell> cells;

        internal Row()
        {
            cells = new List<Cell>();
        }

        internal void AddCellLeft(int row, int column)
        {
            cells.Insert(0, new Cell(row, column));
        }

        internal void AddCellRight(int row, int column)
        {
            cells.Add(new Cell(row, column));
        }
    }
}
