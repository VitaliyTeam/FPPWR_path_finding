using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPPWR_path_finding
{
    public partial class Form1 : Form
    {
        Graphic graphic;
        Graphics graphics;
        Dictionary<Point, int> allPoints;
        // Calculator не оглошувати! Він static
        // Я знаю це логічно

        public Form1()
        {
            InitializeComponent();
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);
            allPoints = new Dictionary<Point, int>();
        }

        private void btnCreateNewMap_Click(object sender, EventArgs e)
        {
            allPoints = Calculator.generatePoints(int.Parse(pointsCount.Text), pictBoxArea.Width, pictBoxArea.Height);
            graphic.DrawPointDictionary(allPoints);
        }

        private void btnDrawNet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateRoute_Click(object sender, EventArgs e)
        {

        }
    }
}
