using System;
using System.Collections.Generic;
using System.Text;

namespace lab11.animals
{
    public class Monkey:Animal
    {
        bool canSpeak;
        public Monkey(string Name, string Sex, int Age, string Types,int Weight,string Size, string Kind, bool CanSpeak) : base(Name, Sex, Age, Types, Weight, Size, Kind){
            canSpeak = CanSpeak;
        }
        public void speakWithPeoples(){
            if(canSpeak){
                Console.WriteLine("Здарова, люди");
            }
            else{
                Console.WriteLine("У-у-у-у");
            }
        }
        public void smoke(){
            Console.WriteLine("Что, ни разу не видел курящих обезьян? Все бывает в первый раз...");
        }

        public override string getInfo()
        {
            return "Monkey: " + base.GetType() + "; alive: " + alive + "; name: " + name + "; sex: " + sex + "; age: " + age + "y.o. ; type: " + type + "; weight: " + weight + "kg; size: " + size + "; kind: " + kind + "; hunger:" + hunger + "; thirst:" + thirst + "; canSpeak: " + canSpeak;
        }

    }
}