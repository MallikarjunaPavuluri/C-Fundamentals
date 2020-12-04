using System;
namespace Bank
{
    
// Elements defined in a namespace cannot be explicitly declared as private, protected, protected internal, or private protected

public  class Demo
    {
      private  class Inner
        {

        }

    }
    class Program
    {
        public void Display(params int[] a)
        {
            foreach (var i in a)
                Console.Write(i + "\t");
        }
        public void ObjectDisplay(params object[]b)
        {
            foreach(var i in b)
            {
                Console.WriteLine(i + "\t");
            }
        }
        public static void Main(String []args)
        {
            Program p = new Program();
            p.Display(1,2);
            Console.WriteLine();
            p.Display(1, 2,3,4);
            Console.WriteLine();
            p.ObjectDisplay(1, "Malli", 90.5);

        }
    }
}
