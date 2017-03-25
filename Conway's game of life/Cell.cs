using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Conway_s_game_of_life
{
    class Cell
    {
        internal bool alive { get; set; }
        internal bool nextAlive { get; set; }
        internal int rowNumber { get; set; }
        internal int columnNumber { get; set; }
        internal Rectangle rectangle { get; set; }

        public Cell(int row, int column)
        {
            alive = false;
            rowNumber = row;
            columnNumber = column;
        }
    }
}
