using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Trim().Split(";" , StringSplitOptions.RemoveEmptyEntries);
            List<Person> peopleList = new List<Person>();
            List<Product> productList = new List<Product>();

            for (int i = 0; i < people.Length; i++)
            {
                string[] personValues = people[i].Trim().Split("=", StringSplitOptions.RemoveEmptyEntries);
                try
                {  
                    Person person = new Person(personValues[0], Convert.ToDecimal(personValues[1]));
                    peopleList.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            List<string> products = Console.ReadLine().Trim().Split(";", StringSplitOptions.RemoveEmptyEntries).Where(x => x != string.Empty).ToList();

            for (int i = 0; i < products.Count; i++)
            {
                try
                {
                    string[] productValues = products[i].Trim().Split("=", StringSplitOptions.RemoveEmptyEntries);
                    Product product = new Product(productValues[0], Convert.ToDecimal(productValues[1]));
                    productList.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            string[] command = Console.ReadLine().Split();

            while (command[0] != "END")
            {
                if (peopleList.Exists(x => x.Name == command[0]) && productList.Exists(x => x.Name == command[1]))
                {
                    if (peopleList.Find(x => x.Name == command[0]).Money >= productList.Find(x => x.Name == command[1]).Price)
                    {
                        peopleList.Find(x => x.Name == command[0]).Money -= productList.Find(x => x.Name == command[1]).Price;
                        peopleList.Find(x => x.Name == command[0]).BagOfProducts.Add(productList.Find(x => x.Name == command[1]));
                        Console.WriteLine($"{command[0]} bought {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"{command[0]} can't afford {command[1]}");
                    }
                }
                command = Console.ReadLine().Split();
            }
            foreach (Person person in peopleList)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
