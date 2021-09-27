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
        // Calculator не оглошувати! Він static 

        public Form1()
        {
            InitializeComponent();
            graphics = pictureBox.CreateGraphics();
            graphic = new Graphic(graphics);
        }

        private void btnCreateNewMap_Click(object sender, EventArgs e)
        {
            //allPoints = Calculator.generatePoints(pointsCount, pictBoxArea.Width, pictBoxArea.Height);
        }

        private void btnDrawNet_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculateRoute_Click(object sender, EventArgs e)
        {

        }
    }
}
