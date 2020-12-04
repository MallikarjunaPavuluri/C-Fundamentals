using System;
using System.IO;

namespace Practise
{
    public struct Subjects
    {
     public    int maths,physics, chemistry;
    }
    public enum Months
    {
        jan,feb,mar,apr,may,jun,jul,aug,sep,oct,nov,dec
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            FileStream f = new FileStream("C:\\Users\\Public\\Documents\\file.txt", FileMode.OpenOrCreate);
            StreamWriter s = new StreamWriter(f);
            StreamReader r = new StreamReader(f);
            f.WriteByte(65);
            TextWriter wr = File.CreateText("C:\\Users\\Public\\Documents\\file1.txt");
            wr.WriteLine("Hello this is Mallikarjuna");
            wr.Close();
            TextReader rr = File.OpenText("C:\\Users\\Public\\Documents\\file1.txt");
            string rte= rr.ReadToEnd();
            Console.WriteLine(rte);
            s.WriteLine("HI This is Mallikarjuna");
            string i = r.ReadLine();
            Console.WriteLine(i);
            s.Close();
            f.Close();
            Subjects sub = new Subjects();

            sub.maths = 10;
            sub.physics = 10;
            sub.chemistry = 10;
            Console.WriteLine($"Mathematics-{sub.maths}\nChemistry-{sub.physics}\nChemistry-{sub.chemistry}");
            Months m = new Months();
            Console.WriteLine((int)Months.jan);


        }
    }
}
