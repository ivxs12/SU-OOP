using System;
using System.Collections.Generic;
using WildFarm.Models.Animals.Mammals;
using WildFarm.Models.Animals;
using WildFarm.Models.Foods;

namespace WildFarm
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] inputAnimal = Console.ReadLine().Split();
            string[] inputFood = Console.ReadLine().Split();
            List<Animal> animals = new List<Animal>();

            while (inputAnimal[0] != "End")
            {
                switch (inputAnimal[0])
                {
                    case "Hen":
                        Animal hen = new Hen(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), Convert.ToDouble(inputAnimal[3]));
                        Console.WriteLine(hen.Speak());
                        hen.Eat(GetFood(inputFood));
                        animals.Add(hen);
                        break;
                    case "Owl":
                        Animal owl = new Owl(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), Convert.ToDouble(inputAnimal[3]));
                        Console.WriteLine(owl.Speak());
                        owl.Eat(GetFood(inputFood));
                        animals.Add(owl);
                        break;
                    case "Mouse":
                        Animal mouse = new Mouse(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), inputAnimal[3]);
                        Console.WriteLine(mouse.Speak());
                        mouse.Eat(GetFood(inputFood));
                        animals.Add(mouse);
                        break;
                    case "Cat":
                        Animal cat = new Cat(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), inputAnimal[3], inputAnimal[4]);
                        Console.WriteLine(cat.Speak());
                        cat.Eat(GetFood(inputFood));
                        animals.Add(cat);
                        break;
                    case "Dog":
                        Animal dog = new Dog(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), inputAnimal[3]);
                        Console.WriteLine(dog.Speak());
                        dog.Eat(GetFood(inputFood));
                        animals.Add(dog);
                        break;
                    case "Tiger":
                        Animal tiger = new Tiger(inputAnimal[1], Convert.ToDouble(inputAnimal[2]), inputAnimal[3], inputAnimal[4]);
                        Console.WriteLine(tiger.Speak());
                        tiger.Eat(GetFood(inputFood));
                        animals.Add(tiger);
                        break;
                    default:
                        break;
                }
                inputAnimal = Console.ReadLine().Split();
                if (inputAnimal[0] == "End")
                {
                    break;
                }
                inputFood = Console.ReadLine().Split();
            }
            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }
        public static Food GetFood(string[] inputFood)
        {
            Food food;
            switch (inputFood[0])
            {
                case "Fruit":
                    food = new Fruit(Convert.ToInt32(inputFood[1]));
                    return food;
                case "Meat":
                    food = new Meat(Convert.ToInt32(inputFood[1]));
                    return food;
                case "Seeds":
                    food = new Seeds(Convert.ToInt32(inputFood[1]));
                    return food;
                case "Vegetable":
                    food = new Vegetable(Convert.ToInt32(inputFood[1]));
                    return food;
            }
            return null;
        }
    }
}
