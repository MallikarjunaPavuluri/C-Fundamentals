using System;
namespace Demo
{
    class group1
    {
        private int nvalue;
        public int Nvalue
        {
            get;
            set;
        }
        public group1(int p)
        {
            nvalue = p;
        }
        public void setvalue(int p)
        {
            Nvalue = p;
        }
        public void Display()
        {
            Console.WriteLine($"Small n-{nvalue} \n Big N-{Nvalue}");
        }
    }
    class Program
    {
        public static void Main(String []args)
        {
            group1 a = new group1(79);
            a.setvalue(20);
            a.Display();
        }
    }
}
