using System;
using System.Collections.Generic;
using System.Text;

namespace lab11.animals
{
    public class Fish:Animal
    {
        public string typeWater;//В какой воде обитает. Пресная или морская
        public Fish(string Name, string Sex, int Age, string Types,int Weight,string Size, string Kind, string TypeWater) : base(Name, Sex, Age, Types, Weight, Size, Kind)
        {
            typeWater = TypeWater;
        }

        public void swim(){
            hunger += 2;
            thirst += 2;
        }

        public override void death(){
            Console.WriteLine("Казалось бы, как рыба может утонуть? Но у нее это получилось. Ваша рыбка "+name+ " умерла");
            alive = false;
        }

        public override string getInfo()
        {
            return "Fish: " + base.GetType() + "; alive: " + alive + "; name: " + name + "; sex: " + sex + "; age: " + age + "y.o. ; type: " + type + "; weight: " + weight + "kg; size: " + size + "; kind: " + kind + "; hunger:" + hunger + "; thirst:" + thirst + "; typeWater: " + typeWater;
        }
        
    }
}