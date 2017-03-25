using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conway_s_game_of_life
{
    class Grid
    {
        internal List<Row> rows;

        internal Grid()
        {
            rows = new List<Row>();
        }

        internal void AddRowBottom()
        {
            rows.Add(new Row());
        }

        internal void AddRowTop()
        {
            rows.Insert(0, new Row());
        }
    }
}
