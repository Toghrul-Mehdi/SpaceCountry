using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Planet
    {
        private static int _id;
        public int PlanetId { get; set; }
        public string Name { get; set; }
        public double Area;

        public Planet(string name,double area)
        {
            PlanetId = _id++;
            Name = name;
            Area = area;
        }



    }
}
