using System;
namespace Lets_Code_Somethings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę:");
            int n;
            n= Int32.Parse(Console.ReadLine()); 
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < n;j++)
                {
                    if(i%2==0)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        if (j == 0 || j == n-1)
                        {
                            Console.Write("X");
                        }
                        else
                        {
                            Console.Write("-");
                        }
                       
                    }
                }
                Console.WriteLine();
            }
        }
    }
}