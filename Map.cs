using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPPWR_path_finding
{
    class Map
    {
        List<Cube> cubes = new List<Cube>();
        public Map() { }

        internal List<Cube> Cubes { get => cubes; set => cubes = value; }

        public string GetPoints(Dictionary<Point, int> allPoints)
        {
            for (int i = 0; i < allPoints.Count; i++)
            {
                for (int j = 0; j < cubes.Count; j++)
                {
                    if(cubes[j].Column == allPoints.ElementAt(i).Key.X / 100 
                        && cubes[j].Row == allPoints.ElementAt(i).Key.Y / 100)
                    {
                        cubes[j].Points.Add(allPoints.ElementAt(i).Key); 
                    }
                }
            }
            string points = "";
            for (int i = 0; i < cubes.Count; i++)
            {
                points += $"{i + 1}.P:{cubes[i].Points.Count}\n";
            }
            return points;
        }
        
    }
}
