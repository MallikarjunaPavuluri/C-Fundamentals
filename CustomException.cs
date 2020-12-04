using System;
namespace Bank
{
    public class Customer
    {
        private String username;
        private String password;
        public String Userame
        {
            get;
            set;
        }
        public String Password
        {
            get;
            set;
        }


    }
    public class AccessDenied:Exception
    {
           public AccessDenied(String s): base(s)
        {

        }
    }
    public class Program
    {
        static void Main(String[] args)
        {
            Customer s = new Customer();
            Console.WriteLine("Enter Name");
            var input = Console.ReadLine();
            s.Userame = input;
            Console.WriteLine("Enter PassWord");
             input = Console.ReadLine();
            s.Password = input;
            try
            {
                Console.WriteLine("Enter User Name-");
                var username= Console.ReadLine();
                Console.WriteLine("Enter Password-");
                 input = Console.ReadLine();
                if (input.Equals(s.Password) && username.Equals(s.Userame)) 
                {
                    Console.WriteLine("Access Granted");
                }
                else
                {
                    throw new AccessDenied("AccessDenied Please Enter Valid User Name Or Password");
                }
            }
            catch(AccessDenied e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("Access Handled");

        }
    }
}
