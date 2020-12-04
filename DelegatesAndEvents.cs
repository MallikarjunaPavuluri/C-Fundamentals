using System;
using System.Collections.Generic;
using System.Xml;

namespace Trainingwithcshap
{
    public delegate bool check(string str);
    public delegate void mail(object source, EventArgs args);
    class Eventhere
    {
        public void Mailhere(object src,EventArgs e)
        {
            Console.WriteLine("There is a space in mail id check");
        }
    }
    class Info
    {
        public event mail Mailcheck;
        private string phone;
        private string gmailid;
        public void Display()
        {
            Console.WriteLine($"Mobile No is- {phone}");
            Console.WriteLine($"Gmail Account No is- {gmailid}");
        }
        public bool Gmailcheck(string s)
        {
            if ((s.ToLower()).EndsWith("@gmail.com"))
            {   if(s.Contains(" "))
                {
                    if (Mailcheck != null)
                    {
                        Mailcheck(this, EventArgs.Empty);
                    }
                }
                gmailid = s;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Digits(string s)
        {
            if (s.Length == 10)
            {
                phone = s;
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(String[] args)
        {
            Info f = new Info();
            Eventhere h = new Eventhere();
            f.Mailcheck += h.Mailhere;

            check c = new check(f.Digits);
            Console.WriteLine("Enter The Mobile No");
            var input = Console.ReadLine();
            while (!c(input))
            {
                Console.WriteLine("Wrong Mobile No Enter Again");
                input = Console.ReadLine();
            }
            Console.WriteLine($"{input} Added Success!");
            Console.WriteLine($"Thank You for Adding Mobile No");
            Console.WriteLine("Enter Gmail id");
            input = Console.ReadLine();
            check d = new check(f.Gmailcheck);
            while (!d(input))
            {
                Console.WriteLine("Wrong Gamil Account Enter Again");
                input = Console.ReadLine();
            }
            Console.WriteLine($"{input} Added Success!");
            Console.WriteLine($"Thank You for Adding Google Account");
            f.Display();
        }
    }
}
