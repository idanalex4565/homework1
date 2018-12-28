using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
          1)
            int a, b;
            Console.WriteLine("enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0) 
            {
                Console.WriteLine("1st % 2nd = 0");
            }
            else
            {
                Console.WriteLine("1st % 2nd != 0");
            }
            Console.ReadLine();
          2)
            int a, b, sum;
            double avg;
            Console.Write("enter 1st number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter 2nd number ");
            b = Convert.ToInt32(Console.ReadLine());
            sum = a + b;
            avg = sum / 2.0;
            Console.WriteLine("the sum is {0}",sum);
            Console.WriteLine("the avg is {0}",avg);
            Console.ReadLine();
          3)
            int a, sum=0;
            Console.Write("enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            while (a > -1)
            {
                sum = sum + a;
                Console.Write("again enter a number (hint it stops in a negetive number): ");
                a = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("the sum is {0}",sum);
            Console.ReadLine();
          4)
            int a ,x;
            Console.Write("enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 1)
            {
                x = a - 1;
                while (a % x != 0)
                {
                    x = x - 1;        
                }
                if (x==1)
                {
                    Console.WriteLine("rishoni");
                }
                else
                {
                    Console.WriteLine("lo rishoni");
                }
            }
            else
            {
                Console.WriteLine("lo rishoni");
            }
            Console.ReadLine();
          5)
            int secret, guess;
            Console.Write("enter the secret number (shh dont tell anyone!): ");
            secret = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter a guess number to unlock: ");
            guess = Convert.ToInt32(Console.ReadLine());
            while (secret != guess)
            {
                if (secret > guess)
                {
                    Console.WriteLine("the guess numbet is too small");
                    Console.Write("enter a guess number to unlock: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("the guess numbet is too big");
                    Console.Write("enter a guess number to unlock: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("bingo!");
            Console.ReadLine();
          6)
            int a, atz = 1, i=2;
            Console.Write("enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                while (i <= a)
                {
                    atz = atz * i;
                    i++;
                }
                Console.WriteLine("atzeret = {0}", atz);
            }
            else
            {
                Console.WriteLine("not allowed");
            }
            Console.ReadLine();
          7)
            int a, b, x;
            Console.Write("enter 1st number ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter 2nd number ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a > 0 || b > 0)
            {
                x = 0;
                if (a > b)
                {
                    while (b > 0)
                    {
                        x = x + a;
                        b = b - 1;
                    }
                    Console.WriteLine("1st * 2nd = {0}",x);
                }
                else
                {
                    while (a > 0)
                    {
                        x = x + b;
                        a = a - 1;
                    }
                    Console.WriteLine("1st * 2nd = {0}", x);
                }
            }
            else
            {
                Console.WriteLine("0");
            }
            Console.ReadLine();
            */
        }
    }
}
