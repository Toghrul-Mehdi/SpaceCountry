using ConsoleApp6.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Country
    {
        private static int _id=1;
        public int CountryID;
        public string CountryName;
        public string CountryNameUpt;
        public double Area;
        public string Anthem;
        public Types Region;

        public Country(string name,string anthem,double area)
        {
            CountryID = _id++;
            CountryName = name ;
            Anthem = anthem ;
            Area = area ;
            
        }

        public Country(string uptname)
        {
            CountryName = uptname;   
        }





    }
}
