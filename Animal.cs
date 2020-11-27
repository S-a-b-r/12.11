using System;
using System.Collections.Generic;
using System.Text;

namespace lab11.animals
{
    public class Animal
    {
        public int hunger;
        public int thirst;
        public string name;
        public string sex;
        public int age;
        public string type; //Травоядный, хищник или всеядный;
        public bool alive;
        public int weight;
        public string size;
        public string kind;
        public Animal(string Name,string Sex,int Age, string Types, int Weight, string Size, string Kind) {
            hunger = 0;
            thirst = 0;
            name = Name;
            sex = Sex;
            age = Age;
            type = Types; //Травоядный, хищник или всеядный;
            weight = Weight;//kg
            size = Size;//XXS,XS,S...XXL
            kind = Kind;
            alive = true;
        }
        public virtual void death()
        {
            alive = false;
            Console.WriteLine("К сожалению, ваше животное " + name + " умерло");
        }

        public void eat()
        {
            hunger -= 10;
            Console.WriteLine("Ваше животное " + name + " поело");
        }

        public void live()
        {
            hunger += 1;
            thirst += 1;
        }

        public virtual string getInfo()
        {
            return "Animal: " + base.GetType() + "; alive: " + alive + "; name: " + name + "; sex: " + sex + "; age: " + age + "y.o. ; type: " + type + "; weight: " + weight + "kg; size: " + size + "; kind: " + kind + "; hunger:" + hunger + "; thirst:" + thirst;
        }
    }
}