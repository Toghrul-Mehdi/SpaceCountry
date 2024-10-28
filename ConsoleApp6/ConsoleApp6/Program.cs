using ConsoleApp6.Core;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            bool f1=false;
            bool f2=false;
            bool f3=false;
            AppDbContext db = new AppDbContext();
            do
            {
                Console.WriteLine("1.Sisteme Giris    0.Cixis");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        do
                        {
                            Console.WriteLine("1.Planet Yarat   2.Butun Planetleri gor   3.Planet Sec   0.Exit");

                            choice = Console.ReadLine();
                            switch(choice)
                            {
                                case "1":
                                    Console.WriteLine("Planet Adi daxil edin:");
                                    string planetname= Console.ReadLine();
                                    bool planetarea_f = false;
                                    double planetarea;
                                    do
                                    {
                                        Console.WriteLine("Area daxil edin:");
                                        planetarea_f=double.TryParse(Console.ReadLine(), out planetarea);
                                    } while (!planetarea_f);
                                    Planet planet = new Planet(planetname,planetarea);
                                    db.CreatePlanet(planet);
                                    break;
                                case "2":
                                    Console.WriteLine("Butun planetler:");
                                    db.GetAllPlanets();
                                    break;
                                case "3":
                                    Console.WriteLine("Planet secin:");
                                    planetname = Console.ReadLine();
                                    if (db.GetPlanet(planetname) == true)
                                    {
                                        Console.WriteLine("Planete ugurla girdiniz!(God Mode)");

                                        do
                                        {
                                            Console.WriteLine("1.Olke yarat  2.Olke gor  3.Update   4.Evvelki menuya qayit   0.Exit");

                                            choice= Console.ReadLine();

                                            switch (choice)
                                            {
                                                case "1":
                                                    Console.WriteLine("Olke adi daxil edin:");
                                                    string countryname= Console.ReadLine();
                                                    Console.WriteLine("Himn daxil edin:");
                                                    string anthem= Console.ReadLine();
                                                    bool countryarea_f = false;
                                                    double countryarea;
                                                    do
                                                    {
                                                        Console.WriteLine("Area daxil edin:");
                                                        countryarea_f = double.TryParse(Console.ReadLine(), out countryarea);
                                                    } while (!countryarea_f);

                                                    Country country =new Country(countryname,anthem,countryarea);
                                                    db.CreateCountry(country);
                                                    Console.WriteLine("Region daxil edin:");
                                                    do
                                                    {

                                                        Console.WriteLine("1.Avropa  2.Asiya  3.Afrika 4.Amerika");

                                                        string choice_region= Console.ReadLine();
                                                        switch (choice_region)
                                                        {

                                                            case "1":
                                                                country.Region = Types.Avropa;
                                                                f3=true;
                                                                break;
                                                            case "2":
                                                                country.Region = Types.Asiya;
                                                                f3=true;
                                                                break;
                                                            case "3":
                                                                country.Region = Types.Afrika;
                                                                f3 = true;
                                                                break;
                                                            case "4":
                                                                country.Region = Types.Amerika;
                                                                f3 = true;
                                                                break;
                                                            default:
                                                                break;
                                                        }                                                        
                                                    } while (!f3);
                                                    break;
                                                default:
                                                    break;
                                                case "2":
                                                    Console.WriteLine("Butun Olkeler:");
                                                    db.GetAllCountries();
                                                    break;
                                                case "3":
                                                    
                                                    int countryid;
                                                    bool countryid_f = false;
                                                    do
                                                    {
                                                        Console.WriteLine("Id daxil edin:");
                                                        countryid_f=int.TryParse(Console.ReadLine(),out countryid);
                                                        if (countryid > 0)
                                                        {
                                                            countryid_f = true;
                                                        }
                                                        else
                                                        {
                                                            countryid_f = false;
                                                        }
                                                    } while (!countryid_f);

                                                   db.UpdateCountry(countryid);
                                                    
                                                    break;
                                                case "4":
                                                    f2 = true;
                                                    break;
                                                case "0":
                                                    return;
                                                    break;
                                            }

                                        } while (!f2);
                                    }
                                    break;
                                case "0":
                                    return;
                                    break;
                                default:
                                    break;
                            }
                        } while (!f1);
                        
                        break;
                    default:
                        break;
                }








            } while (!f);
        }
    }
}
