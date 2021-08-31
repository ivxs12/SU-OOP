using System;
using System.Linq;

namespace PizzaCalories
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            try
            {
                Pizza pizza = new Pizza(input[1]);
                input = Console.ReadLine().Split();

                try
                {
                    Dough dough = new Dough(input[1].ToLower(), input[2].ToLower(), Convert.ToDouble(input[3]));
                    pizza.Dough = dough;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

                input = Console.ReadLine().Split();

                while (input[0] != "END")
                {
                    try
                    {
                        Topping topping = new Topping(input[1].ToLower(), Convert.ToDouble(input[2]));
                        pizza.AddTopping(topping);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        return;
                    }
                    input = Console.ReadLine().Split();
                }
                Console.WriteLine(pizza.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
        }
    }
}
