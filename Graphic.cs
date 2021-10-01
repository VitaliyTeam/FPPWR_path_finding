using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FPPWR_path_finding
{
    class Graphic
    {
        private Graphics graphics;

        public Graphic(Graphics graphics)
        {
            this.graphics = graphics;
        }

        public Graphic()
        {

        }

        public Dictionary<Point, int> Net(Dictionary<Point, int> allPoints, Size size)
        {
            allPoints = Calculator.sortDictionaryByValue(allPoints);
            int stepsY = size.Height / 100;
            int stepsX = size.Width / 100;

            Dictionary<Point, int> sorted = new Dictionary<Point, int>();


            for (int i = 0; i < stepsY; i++)
            {
                Dictionary<Point, int> points = new Dictionary<Point, int>();
                for (int k = 0; k < stepsX; k++)
                {
                    
                    for (int j = 0; j < allPoints.Count; j++)
                    {
                        if (i * 6 < allPoints.ElementAt(j).Value && (i + 1) * 6 + 1> allPoints.ElementAt(j).Value)
                        {
                            points.Add(allPoints.ElementAt(j).Key, allPoints.ElementAt(j).Value);
                            allPoints.Remove(allPoints.ElementAt(j).Key);
                        }
                    }
                    
                }
                if (i % 2 == 0)
                {
                    points = Calculator.sortDictionaryByKey(points);                    
                    foreach (var item in points)
                    {
                        sorted.Add(item.Key, item.Value);
                    }
                }
                else
                {
                    points = Calculator.sortDictionaryByKeyDescending(points);
                    foreach (var item in points)
                    {
                        sorted.Add(item.Key, item.Value);
                    }
                }
            }
            List<Point> points1 = Calculator.DictionaryToList(sorted);
            DrawRoute(points1, Color.Black);
            return sorted;
        }

        public string DrawPointDictionary1(Dictionary<Point, int> points)
        {
            string stat = "";
            for (int i = 0; i < points.Count; i++)
            {
                DrawPoint(points.ElementAt(i).Key, Brushes.Black);
                int a = points.ElementAt(i).Key.Y / 100 * 6 + points.ElementAt(i).Key.X / 100 + 1;
                points[points.ElementAt(i).Key] = a;
                stat += $"{i + 1}.C:{a}\n";
            }
            
            return stat;
        }

        public void DrawMap(Size size)
        {
            int x = size.Width / 100 + 1;
            int y = size.Height / 100 + 1;

            for (int i = 0; i < x; i++)
            {
                graphics.DrawLine(new Pen(Color.Black) { Width = 1 }, new Point(i * 100, 1), new Point(i * 100, size.Height));
            }
            for (int i = 0; i < y; i++)
            {
                graphics.DrawLine(new Pen(Color.Black) { Width = 1 }, new Point(1, i * 100), new Point(size.Width, i * 100));
            }
        }

        public void PAUSE(int pause = 100)
        {
            Thread.Sleep(pause); // set this value to set drawing speed
        }

        public void DrawLine(Point p1, Point p2, Color color)
        {
            Pen pen = new Pen(color);
            pen.Width = 1;
            graphics.DrawLine(pen, p1, p2);
        }

        public void DrawCircle(Point p, int radius, Color color, int pause = 30)
        {
            Pen pen = new Pen(color);
            pen.Width = 2;
            graphics.DrawEllipse(pen, p.X - radius, p.Y - radius, 2 * radius, 2 * radius);
            PAUSE(pause);
        }

        public void DrawPoint(Point p, Brush brush)
        {
            graphics.FillRectangle(brush, p.X - 2, p.Y - 2, 4, 4);
        }

        public void DrawPointArray(Point[] points)
        {
            for (int i = 0; i < points.Length; i++)
            {
                DrawPoint(points[i], Brushes.Black);
            }
        }

        public void DrawPointDictionary(Dictionary<Point, int> points)
        {
            foreach (KeyValuePair<Point, int> result in points)
                DrawPoint(result.Key, Brushes.Black);
        }

        public void DrawPointList(List<Point> points)
        {
            foreach (Point point in points)
                DrawPoint(point, Brushes.Black);
        }

        public void ClearImage()
        {
            graphics.Clear(Color.White);
        }

        public void DrawRoute(List<Point> points, Color color, int pause = 10)
        {
            for (int i = 1; i < points.Count; i++)
            {
                DrawLine(points[i - 1], points[i], color);
                PAUSE(pause);
            }
        }
    }
}
