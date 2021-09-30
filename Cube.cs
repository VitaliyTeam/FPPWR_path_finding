using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPWR_path_finding
{
    class Cube
    {
        private List<Point> points = new List<Point>();
        private int column;
        private int row;

        public Cube(List<Point> points, int column, int row)
        {
            this.Points = points;
            this.Column = column;
            this.Row = row;
        }

        public List<Point> Points { get => points; set => points = value; }
        public int Column { get => column; set => column = value; }
        public int Row { get => row; set => row = value; }
    }
}
