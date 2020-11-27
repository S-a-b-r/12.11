
using System;
using System.Collections.Generic;
using System.Text;

namespace lab11.animals
{
    public class Bird:Animal
    {
        public bool canFly;
        public Bird(string Name, string Sex,int Age, string Types,int Weight,string Size, string Kind, bool CanFly) : base(Name, Sex, Age, Types, Weight, Size, Kind)
        {
            canFly = CanFly;
        }
        
        public void fly()
        {
            if (canFly)
            {
                Console.WriteLine("Юху, мы летаем");
                hunger += 1;
                thirst += 1;
            }
            else
            {
                Console.WriteLine("К сожалению, данный вид не умеет летать");
            }
        }

        public void sing()
        {
            Console.WriteLine("Чик-чирик!");
        }

        public override string getInfo()
        {
            return "Bird: " + base.GetType() + "; alive: " + alive + "; name: " + name + "; sex: " + sex + "; age: " + age + "y.o. ; type: " + type + "; weight: " + weight + "kg; size: " + size + "; kind: " + kind + "; hunger: " + hunger + "; thirst: " + thirst + "; canFly: "+ canFly ;
        }
        
    }
}