// See https://aka.ms/new-console-template for more information
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime;

namespace Hello
{
    class H1
    {
        static void Main()
        {
            Console.WriteLine("HelloWorld");
            int currentTop = Console.CursorTop;
            int L =0;
            int T =0;
            for(int i=0; i<=100; i++)
            {
                Console.SetCursorPosition(0, currentTop);
                Console.WriteLine($"{i}%");
                T = Console.CursorTop;

                Console.SetCursorPosition(L, T);
                if(i%5 == 0 && i!=0)
                {
                    Console.Write("#");
                }
                L = Console.CursorLeft;
                
                Thread.Sleep(50);
            }
            Console.ReadKey();
        }

    }
}
