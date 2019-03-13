﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.Oom.Battleship.Model
{
    public class Square
    {
        Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
        readonly int Row;
        readonly int Column;
    }
}
