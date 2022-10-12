using System.Runtime.ExceptionServices;

namespace Практическая__3
{
    internal class Program3
    {
        static void Main()
        { while (true)
            {
                Console.WriteLine("\nПереключение между октавами F4 и F5" + "\nдля выхода нажмите 'Enter'");
                ConsoleKeyInfo x = Console.ReadKey();
                if (x.Key == ConsoleKey.F5)
                {
                    First();
                }
                else if (x.Key == ConsoleKey.F4)
                {
                    Second();
                }
                else if (x.Key == ConsoleKey.Enter)
                {
                    Environment.Exit(0);
                }
            }
        }

        static void First()
        {
            Console.Clear();
            Console.WriteLine("5 октава");
            int[] ok5 = { 523, 554, 587, 622, 659, 698, 739, 784, 830, 880, 932, 987 };
            n(ok5);
        static void n(int[] h)
            {
                ConsoleKeyInfo a;
                do {
                    a = Console.ReadKey();
                    Console.Clear();
                    int cb;
                    if (a.Key == ConsoleKey.I)
                    {
                        cb = h[0];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.B)
                    {
                        cb = h[1];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.C)
                    {
                        cb = h[2];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.D)
                    {
                        cb = h[3];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.E)
                    {
                        cb = h[4];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.F)
                    {
                        cb = h[5];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.G)
                    {
                        cb = h[6];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.H)
                    {
                        cb = h[7];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.W)
                    {
                        cb = h[8];
                        nota(cb);
                    }
             
                    if (a.Key == ConsoleKey.Z)
                    {
                        cb = h[9];
                        nota(cb);
                    }
             
                    if (a.Key == ConsoleKey.T)
                    {
                        cb = h[10];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.P) 
                    {
                        cb = h[11];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.Tab) 
                    {
                     break;
                    }
                } while (a.Key != ConsoleKey.Escape);
            }
        static void nota(int num)
            {
                Console.Beep(num, 250);
            }
        }
        static void Second()
        {
            Console.Clear();
            Console.WriteLine("4 октава");
            int[] ok4 = { 261, 277, 293, 311, 329, 349, 369, 392, 415, 440, 466, 493 };
            n(ok4);
            static void n(int[] h)
            {
                ConsoleKeyInfo a;
                do
                {
                    a = Console.ReadKey();
                    Console.Clear();
                    int cb;
                    if (a.Key == ConsoleKey.I)
                    {
                        cb = h[0];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.B)
                    {
                        cb = h[1];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.C)
                    {
                        cb = h[2];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.D)
                    {
                        cb = h[3];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.E)
                    {
                        cb = h[4];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.F)
                    {
                        cb = h[5];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.G)
                    {
                        cb = h[6];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.H)
                    {
                        cb = h[7];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.W)
                    {
                        cb = h[8];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.Z)
                    {
                        cb = h[9];
                        nota(cb);
                    }

                    else if (a.Key == ConsoleKey.T)
                    {
                        cb = h[10];
                        nota(cb);
                    }
                    else if (a.Key == ConsoleKey.P)
                    {
                        cb = h[11];
                        nota(cb);
                    }
                    if (a.Key == ConsoleKey.Tab)
                    {
                       break;
                    }
                } while (a.Key != ConsoleKey.Escape);
            }
            static void nota(int num)
            {
                Console.Beep(num, 250);
            }
        }
    }
}
