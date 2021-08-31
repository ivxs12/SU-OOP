using System;

namespace Telephony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();
            ISmartable smartphone = new Smartphone();
            IStationable stationary = new StationaryPhone();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Length <= 7)
                {
                    try
                    {
                        stationary.Call(numbers[i]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else
                {
                    try
                    {
                        smartphone.Call(numbers[i]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                try
                {
                    smartphone.Browse(urls[i]);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
