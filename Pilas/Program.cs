using System;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pila = new Stack();
            pila.Push(5);
            pila.Push(3);
            pila.Push(10);

            pila.Apuntador();

            //Pop
            Console.WriteLine(pila.Pop());
            pila.Apuntador();

            //Peek 
            Console.WriteLine(pila.Peek());
            Console.WriteLine(pila.Peek());
        }
    }
}
