using System;

namespace Trainingwithcshap
{
    class Teacher
    {

        String subject;
        string college;
        string phoneno;
        string mailid;
        string idno;
        Teacher()
        {

        }
        ~Teacher()
        {
            Console.WriteLine("Distructor");
        }
    }
    public class Student
    {
       public string name;
       public static string college="Vasavi";
       public int rollno;
       public  string mailid;
       public  string phoneno; 
       static Student()
        {

        }

    }

    static class  Book
    {
        static string name="Na";
      /*  public  Book()
        {
            name = "NA";
        } */
      //Static class don't have instance Constructor 
      //in static class don't have instance variable and methods only static parameter
      //this can't be used static block
        public static  void SetName(String Name)
        {
           name = Name;
        }
       public static  String GetName()
        {
            return name;
        } 
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Book b = new Book(); gives error due to nature of static 
            Book.SetName("Mallikarjuna");
            Console.WriteLine();
            Console.WriteLine(Book.GetName());

            Student s = new Student();
            s.name = "Mallikarjun";
            Student.college = "Vasavi";//static members accessed through Class name only if try to access through reference ytou get error
            s.mailid = "pavulurimallikarjunarao@gmail.com";
            s.phoneno = "8008471623";
            s.rollno = 79;
            Console.WriteLine($"Details of Student:\nName     :{s.name}\nMail Id  :{s.mailid}" +
                $"\nPhone No :{s.phoneno}\nRool No  :{s.rollno}\nCollege  :{Student.college}");


       
         }
    }
}
