using System;
namespace Assignment1;
class Program{
    public static void Main(string[] args)
    {
        ClassTeacher classTeacher1=new ClassTeacher("Sabitha", "Alex", new DateTime(1978,09,23),"7654676588","Female","sabitha@gmail.com","Computer Science","Chemistry","B. Sc Chemistry",4,new DateTime(2022,10,09));
        StudentInfo student1=new StudentInfo("Sanjay","Vedha",new DateTime(2001,12,21),"8579009407","Male","sanjay@yahoo.com","IT","B. Tech",8 );
        PrincipalInfo principal1=new PrincipalInfo("Sri Padma","Shreekar",new DateTime(1979,11,23),"968547543","Male","sripadma@gmail.com","M. Sc",9,new DateTime(2023,02,12));
        classTeacher1.ShowDetails();
        student1.Showdetails();
        principal1.ShowDetails();
        
        ClassTeacher classTeacher2=new ClassTeacher("latha", "Kumar", new DateTime(1989,04,09),"849939333","Female","latha@gmail.com","EI","English","MCA",5,new DateTime(2023,05,29));
        StudentInfo student2=new StudentInfo("Niranjan","Vedha",new DateTime(2006,09,28),"784583443","Male","ninja@yahoo.com","CSC","B. E",4 );
        PrincipalInfo principal2=new PrincipalInfo("Meenakshi","Madhav",new DateTime(1988,01,27),"549594309","Female","meenakshi@gmail.com","M. Tech",7,new DateTime(2023,07,26));
        classTeacher2.ShowDetails();
        student2.Showdetails();
        principal2.ShowDetails();
        
    }
}