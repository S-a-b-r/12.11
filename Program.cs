using System;
using lab11.animals;

namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
           Animal[] zoo = {
                new Bird("Andrey", "male", 2, "veg", 1, "S", "sinichka", true),
                new Monkey("Koko", "female", 7, "omni", 140,"M","gorilla", true),
                new Fish("Nemo","male",1,"veg",1,"XS","clown","sea")
            };

            for(var i = 0; i < zoo.Length; i++)
            {
                if(zoo[i] is Bird)
                {
                    var a = (Bird)zoo[i];
                    Console.WriteLine(a.getInfo());
                }
                else if(zoo[i] is Monkey)
                {
                    var a = (Monkey)zoo[i];
                    Console.WriteLine(a.getInfo());
                }
                else if(zoo[i] is Fish)
                {
                    var a = (Fish)zoo[i];
                    Console.WriteLine(a.getInfo());
                }
                else
                {
                    var a = zoo[i];
                    Console.WriteLine(a.getInfo());
                }
            }
            Console.ReadLine();
        }
    }
}
