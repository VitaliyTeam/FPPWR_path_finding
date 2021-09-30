using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPPWR_path_finding
{
    public partial class Form1 : Form
    {
        Graphic graphic;
        Graphics graphics;
        Dictionary<Point, int> allPoints;
        PictureBox pictBoxArea;
        // Calculator не оглошувати! Він static
        // Я знаю це логічно

        public Form1()
        {
            InitializeComponent();
            this.Height = 800;
            this.Width = 1000;
            pictBoxArea = new PictureBox();
            pictBoxArea.BackColor = Color.White;
            pictBoxArea.Height = 601;
            pictBoxArea.Width = 601;
            this.Controls.Add(pictBoxArea);
            graphics = pictBoxArea.CreateGraphics();
            graphic = new Graphic(graphics);
            allPoints = new Dictionary<Point, int>();           
        }

        private void btnCreateNewMap_Click(object sender, EventArgs e)
        {
            graphic.ClearImage();
            graphic.Map.Cubes = new List<Cube>();
            graphic.DrawMap(new Size(pictBoxArea.Width, pictBoxArea.Height));
            allPoints = Calculator.generatePoints(int.Parse(pointsCount.Text), pictBoxArea.Width, pictBoxArea.Height);
            graphic.DrawPointDictionary(allPoints);
            label1.Text = graphic.Map.GetPoints(allPoints);
        }

        private void btnDrawNet_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCalculateRoute_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {          
            
        }
    }
}
