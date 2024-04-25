using System;

namespace Assignment1
{
    public class Duck:IAnimal
    {
        public string Name { get ; set ; }
        public string Habitat { get ; set ; }
        public string EatingHabit { get ; set; }
        public Duck(string name,string habitat,string eatingHabit){
            Name=name;
            Habitat=habitat;
            EatingHabit=eatingHabit;
        }

        public void DisplayName()
        {
            System.Console.WriteLine($"Duck Name: {Name}");
            
        }
        public void DisplayInfo(){
            DisplayName();
            System.Console.WriteLine($"Duck Habitat: {Habitat}");
            System.Console.WriteLine($"Duck Eating Habit: {EatingHabit}");
        }
    }
}
