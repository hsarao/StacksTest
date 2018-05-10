using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class Point
    {
        public int Row { get; }
        public int Column { get; }

        public Point(int row, int column)
        {
            this.Row = row;
            this.Column = column;
        }

        //public int getRow()
        //{
        //    return this.Row;
        //}

        //public int getColumn()
        //{
        //    return this.Column;
        //}

        override
        public String ToString()
        {
            return "[" + Row.ToString() + ", " + Column.ToString() + "]";
        }
    }
}
