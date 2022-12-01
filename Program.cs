using System;

namespace HelloWorld
{
    class Program
    {
        
        public class addition 
        {
            public int add(int a, int b)
            {
                Console.WriteLine("the sum of two no is:"+ (a + b));
                return 0;
            }
            public int add(int a, int b, int c)
            {
                Console.WriteLine("the sum of three no is:"+(a + b + c));
                return 0;
            }
            public int add(int a, int b, int c, int d)
            {
                Console.WriteLine("the sum of four no is:"+(a + b + c + d));
                return 0;
            }

        }
        public class subtraction 
        {
            public int substraction(int a, int b)
            {
                Console.WriteLine("the subtraction of two no is:"+(a - b));
                return 0;
            }
            public int substraction(int a, int b, int c)
            {
                Console.WriteLine("the subtraction of three no is:"+(a - b - c));
                return 0;
            }
            public int substraction(int a, int b, int c, int d)
            {
                Console.WriteLine("the subtraction of four no is:"+(a - b - c - d));
                return 0;
            }

        }
        static void Main(string[] args)
        {
            addition Addition = new addition();
            subtraction sub = new subtraction();
            
            Console.WriteLine("enter 1 for addition:");
            Console.WriteLine("enter 2 for substraction:");
            int x = Convert.ToInt32(Console.ReadLine());
            switch (x)
            {
                
                    case 1:
                    Console.WriteLine("how many values you want to enter");
                    int p= Convert.ToInt32(Console.ReadLine());
                    if (p == 2)

                    {
                        Console.WriteLine("enter the value of first no");
                        int a= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b= Convert.ToInt32(Console.ReadLine());
                        Addition.add(a, b);
                        
                    }
                    else if (p == 3)
                    {
                        Console.WriteLine("enter the value of first no");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of third no");
                        int c = Convert.ToInt32(Console.ReadLine());
                        Addition.add(a , b, c);
                    }
                    else if (p== 4)
                    {
                        Console.WriteLine("enter the value of first no");
                        int a= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of third no");
                        int c= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of fourth no");
                        int d= Convert.ToInt32(Console.ReadLine());
                        Addition.add(a, b, c ,d);
                    }
                    else

                        Console.WriteLine("you enter the wrong operation");
                    break;
                case 2:
                    Console.WriteLine("how many values you want to enter");
                    int q= Convert.ToInt32(Console.ReadLine());

                    if (q == 2)
                    {
                        Console.WriteLine("enter the value of first no");
                        int a= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b= Convert.ToInt32(Console.ReadLine());
                        sub.substraction(a, b);
                    }
                    else if (q == 3)
                    {
                        Console.WriteLine("enter the value of first no");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of third no");
                        int c= Convert.ToInt32(Console.ReadLine());
                        sub.substraction(a, b ,c);
                    }
                    else if (q == 4)
                    {
                        Console.WriteLine("enter the value of first no");
                        int a= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of second no");
                        int b= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of third no");
                        int c= Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enter the value of fourth no");
                        int d= Convert.ToInt32(Console.ReadLine());
                        sub.substraction(a,b,c,d);
                    }
                    
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;
            }
            
        }
    }
}
