using System;

namespace Assignment1
{
    public interface IAnimal
    {
        string Name{get;set;}
        string Habitat{get;set;}
        string EatingHabit{get;set;}
        void DisplayName();
    }
}
