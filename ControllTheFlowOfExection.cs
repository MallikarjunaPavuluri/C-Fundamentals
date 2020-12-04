using System;
using System.Collections.Generic;

namespace Trainingwithcshap
{
    class Program
    {
         public static void Medals(char c)
        {
            switch(c)
            {
                case 'A':
                    Console.WriteLine("Extradenary:");
                    break;
                case 'B':
                    Console.WriteLine("Excellent:");
                    break;
                case 'C':
                    Console.WriteLine("Average:");
                    break;
                case 'D':
                    Console.WriteLine("Ok:");
                    break;
                case 'F':
                    Console.WriteLine("Fail:");
                    break;
                default:
                    Console.WriteLine("Not Listed:");
                    break;
            }
        }
        public static char Grade(double d)
        {
            if (d > 80)
            {
                return 'A';
            }
            else if (d > 70)
            {
                return 'B';
            }
            else if (d > 60)
            {
                return 'C';
            }
            else if (d > 50)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
        static void Main(string[] args)
        {

            var grade = new List<double>();
            Console.WriteLine("Enter Marks And to exit enter E ");
            char eds = 'a';
            double marks = 0;
            string input = "A";


            while (input != "E")
            {
                try
                {
                    input = Console.ReadLine();
                    if (double.TryParse(input, out marks))
                    {
                        if (marks <= 100 && marks >= 0)
                        {
                            grade.Add(marks);
                        }
                        else
                        {
                            throw new ArgumentException($"Invalid {nameof(grade)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid formate:");
                    }

                }

                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Data Handelled");
                }

            }
        
            
           
          
            int cnt = 0;
            char ch='a';
            foreach(var i in grade)
            {
                ch = Program.Grade(i);
                Console.Write($"Data {i}---->{ch}------>");
                Program.Medals(ch);

                 if(i<=100.0&&i>=0)
                {
                    continue;
                }
                else
                {
                    goto display;
                }
            }
            if(cnt==0)
            {
                Console.WriteLine("Valid Data");
            }

        display:
            {
                Console.WriteLine("just Goto satatement");
            }
           
            var pos = 0;
            var avg = 0.0;
            for(pos=0;pos<grade.Count;pos++)
            {
                avg += grade[pos];

            }
            avg /= grade.Count;
            Console.WriteLine($"Aveage Grade of Provided Data-{avg:N1}");
            pos = 0;
            var min = 0.0;
            if(grade.Count>0)
            {
                min = grade[pos];
                do
                {
                    if(min<0)
                    {
                        break;
                    }
                    if(grade[pos]<min)
                    {
                        min = grade[pos];
                    }
                    pos++;
                } while (pos < grade.Count);
                Console.WriteLine($"Min Value in data is-{min}");
            }
            else
            {
                Console.WriteLine("No Data is There:");
            }
            pos = 0;
            var max = 0.0;
            while(pos<grade.Count)
            {
                  if(grade[pos]>max)
                {
                    max = grade[pos];
                }
                pos++;
            }
            Console.WriteLine($"Max Value in data is-{max}");




        }
    }
}
    
