using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge_Cap6
{
    class Program
    {
        static void Main(string[] args)
        {
            var Countries = new List<Country>();
            var option = 0;

            do
            {
                Console.WriteLine("1 - Create");
                Console.WriteLine("2 - Read");
                Console.WriteLine("3 - Update");
                Console.WriteLine("4 - Delete");
                Console.WriteLine("5 - Exit");
                Console.WriteLine("---------------");

                if (!Int32.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Wrong option!");
                }
                else
                {
                    var id = 0;

                    switch (option)
                    {
                        case 1:
                            id = 1;
                            if ((from country in Countries select country.Id).Any())
                            {
                                id += (from country in Countries select country.Id).Max();
                            }

                            Console.WriteLine("Name of country: ");
                            Countries.Add(
                                new Country { Id = id, Name = Console.ReadLine() }
                                );
                            break;
                        case 2:
                            //I can filter and display after!
                            (from country in Countries select country)
                                .OrderBy(o => o.Id)
                                .ToList()
                                .ForEach(s =>
                            {
                                Console.WriteLine($"{s.Id} * {s.Name} ");
                            });
                            break;
                        case 3:
                            Console.WriteLine("Id of country: ");
                            id = 0;
                            if (int.TryParse(Console.ReadLine(), out id))
                            {

                                var c = (from country in Countries
                                         where country.Id.Equals(id)
                                         select country
                                ).FirstOrDefault();

                                foreach (var item in Countries)
                                {
                                    if (item.Equals(c))
                                    {
                                        Countries.Remove(c);
                                        Console.WriteLine("Name of country: ");
                                        c.Name = Console.ReadLine();
                                        Countries.Add(c);
                                        break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid Id");
                            }

                            break;
                        case 4:
                            Console.WriteLine("Id of country: ");
                            id = 0;
                            if (int.TryParse(Console.ReadLine(), out id))
                            {
                                var r = (from country in Countries
                                         where country.Id.Equals(id)
                                         select country
                                         ).FirstOrDefault();
                                Countries.Remove(r);
                            }
                            else
                            {
                                Console.WriteLine("Invalid Id");
                            }
                            break;
                        case 5:
                            Console.WriteLine("Bye!");
                            break;
                        default:
                            Console.WriteLine("Wrong option!");
                            break;
                    }
                }
                Console.WriteLine("");

            } while (option != 5);

        }
    }
}
