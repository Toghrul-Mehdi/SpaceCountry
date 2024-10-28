using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class AppDbContext
    {
        List<Country> country = new List<Country>();
        List<Planet> planet = new List<Planet>();

        public void CreateCountry(Country countrys)
        {
            country.Add(countrys);
        }

        

        public void GetAllCountries()
        {
            foreach (Country countrys in country)
            {
                Console.WriteLine();
                Console.WriteLine("Olke id:"+countrys.CountryID);
                Console.WriteLine("Olke adi:"+countrys.CountryName);
                Console.WriteLine("Olke erazisi:"+countrys.Area);
                Console.WriteLine("Olke himni:"+countrys.Anthem);
                Console.WriteLine("Olke regionu:"+countrys.Region);
                Console.WriteLine();
            }
        }



        public void UpdateCountry(int id)
        {

            Country countryToUpdate = country.Find(c => c.CountryID == id);

            if (countryToUpdate != null)
            {
                Console.WriteLine("Yeni ad girin:");
                countryToUpdate.CountryName = Console.ReadLine();

                Console.WriteLine("Yeni area girin:");
                
                if (int.TryParse(Console.ReadLine(), out int area))
                {
                    countryToUpdate.Area = area;
                }
                else
                {
                    Console.WriteLine("Error");
                    return;
                }

                Console.WriteLine("Yeni himn girin:");
                countryToUpdate.Anthem = Console.ReadLine();

                Console.WriteLine("Olke melumatlari deyisdi");
            }
            else
            {
                Console.WriteLine("Error: Olke tapilmadi.");
            }


        }

        public void CreatePlanet(Planet planets)
        {
            planet.Add(planets);
        }
        public void RemovePlanet(int id)
        {
            Planet planets = planet.Find(X=>X.Equals(id));
            planet.Remove(planets);
        }

        public void GetAllPlanets()
        {
            foreach (Planet planets in planet)
            {
                Console.WriteLine();
                Console.WriteLine("Planet adi:"+planets.Name);
                Console.WriteLine("Planet erazisi:"+planets.Area);                
                Console.WriteLine();
            }
        }
        public bool UpdatePlanet(int id)
        {
            bool f = false;
            foreach (Planet planets in planet)
            {
                if (planets.PlanetId == id)
                {
                    f = true;
                }
            }
            return f;
        }

        public bool GetPlanet(string name)
        {
            bool f = false;
            foreach(Planet planets in planet)
            {
                if (planets.Name.Equals(name))
                {
                    f = true;
                }
            }
            return f;
        }

    }
}
