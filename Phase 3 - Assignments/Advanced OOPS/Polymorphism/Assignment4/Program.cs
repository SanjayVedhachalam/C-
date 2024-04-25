using System;
namespace Assignment4;
class Program{
    public static void Main(string[] args)
    {
        PersonDetails person=new PersonDetails("Sanjay","Vedha","Male","B. Tech");
        FreeLancer lancer=new FreeLancer(person.Name,person.FatherName,person.Gender,person.Qualification,"Software Engineer",30);
        Syncfusion syncfusion=new Syncfusion(lancer.Name,lancer.FatherName,lancer.Gender,lancer.Qualification,lancer.Role,lancer.NoOfWorkingDays,"Chennai");
        
        lancer.CalculateSalary();
        lancer.DisplayEmployeeDetails();

        syncfusion.CalculateSalary();
        syncfusion.DisplayEmployeeDetails();
    }
}