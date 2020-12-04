using System;
using System.Collections.Generic;
using System.Xml;

namespace Trainingwithcshap
{ 
    public abstract class Info
    {
         string mailid;
         string uniqueid;
         string phoneno;
         string name;
         int age;
        public abstract void CollectInfo();
       
        abstract public void Display();
       
        public int Age
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Mailid
        {
            get;
            set;
        }
        public string Phoneno
        {
            get;
            set;
        }


    }
    class Student:Info
    {
        private double[] subjects = new double[6]; 
        private int rollno;
        public override void CollectInfo()
        {
            int i;

            Console.WriteLine("Enter Student Name-");
            var input = Console.ReadLine();
            Name = input;
            Console.WriteLine("Enter Student Phone Number");
            input = Console.ReadLine();
            Phoneno = input;
            Console.WriteLine("Enter Student Mail Id:");
            input = Console.ReadLine();
            Mailid = input;
            Console.WriteLine("Enter Student Age-");
            input = Console.ReadLine();
            while (!int.TryParse(input, out i))
            {
                Console.WriteLine("Invalid Data Enter Again-");
                input = Console.ReadLine();
            }
            Age = i;
            Console.WriteLine("Enter Student UniqueId-");
            input = Console.ReadLine();
            Uniqueid = input;

        }
        public override void Display()
        {
            Console.WriteLine($"Student Details:");
            Console.WriteLine($"-------------------------------");
            Console.WriteLine($"Student Name-{Name}");
            Console.WriteLine($"Student RollNo-{Rollno}");
            Console.WriteLine($"Student Mailid-{Mailid}");
            Console.WriteLine($"Student PhoneNo-{Phoneno}");
            Console.WriteLine($"Student Age-{Age}");
            Console.WriteLine($"Student UniqueId-{Uniqueid}");
            for(int i=0;i<6;i++)
            {
                Console.WriteLine($"Student Marks in {i+1}-{subjects[i]}");
            }
        }
        public Student()
        {
            rollno = 0;
        }
        public void setMarks()
        {
            var input = "Ok";
            double d;
            for(int i=0;i<6;i++)
            {
                Console.WriteLine($"Enter Marks in {i + 1} Subject");
                 input = Console.ReadLine();
                while (!double.TryParse(input, out d))
                {
                    Console.WriteLine("Enter Valid Data:");
                    input = Console.ReadLine();
                }
                subjects[i] = d;

            }
        }

        public int Rollno
        {
            get;
            set;
        }
        public string Uniqueid
        {
            get;
            set;

        }
     
    }
    class Hostel : Info
    {
        private int roomno;
        public int Roomno
        {
            set;
            get;
        }
        public override void CollectInfo()
        {
            int i;

            Console.WriteLine("Enter Student Name-");
            var input = Console.ReadLine();
            Name = input;
            Console.WriteLine("Enter Student Phone Number");
            input = Console.ReadLine();
            Phoneno = input;
            Console.WriteLine("Enter Student Mail Id:");
            input = Console.ReadLine();
            Mailid = input;
            Console.WriteLine("Enter Student Age-");
            input = Console.ReadLine();
            while (!int.TryParse(input, out i))
            {
                Console.WriteLine("Invalid Data Enter Again-");
                input = Console.ReadLine();
            }
            Age = i;
            Console.WriteLine("Enter Student UniqueId-");
            input = Console.ReadLine();
            Uniqueid = input;

        }
        public string Uniqueid
        {
            get;
            set;
        }
        public override void Display()
        {
            Console.WriteLine($"Hostel Details:");
            Console.WriteLine("--------------------");
            Console.WriteLine($"Student Room-{Roomno}");
            Console.WriteLine($"Student Name-{Name}");
            Console.WriteLine($"Student Mailid-{Mailid}");
            Console.WriteLine($"Student PhoneNo-{Phoneno}");
            Console.WriteLine($"Student Age-{Age}");
            Console.WriteLine($"Student UniqueId-{Uniqueid}");
        }
    }
    class Program
    {
      
        static void Main(string[] args)
        {
            int rollno;
            Student s = new Student();
            s.CollectInfo();
            Console.WriteLine("Enter RollNo-");
            var input = Console.ReadLine();
            while(!int.TryParse(input,out rollno))
            {
                Console.WriteLine("Enter Valid Data:");
                input = Console.ReadLine();
            }
            s.Rollno = rollno;
            s.setMarks();
            s.Display();
            Hostel h = new Hostel();
            h.CollectInfo();
            Console.WriteLine("Enter RoomNo-");
            input = Console.ReadLine();
            while (!int.TryParse(input, out rollno))
            {
                Console.WriteLine("Enter Valid Data:");
                input = Console.ReadLine();
            }
            h.Roomno = rollno;
            h.Display();

        }
    }
}
