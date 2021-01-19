using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projPilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> pilhaInt;
            pilhaInt = new Stack<int>();

            pilhaInt.Push(10);
            pilhaInt.Push(20);
            pilhaInt.Push(30);
            pilhaInt.Push(40);
            pilhaInt.Push(50);

            mostraPilha(pilhaInt);

            Console.WriteLine("Topo da pilha: {0}", pilhaInt.Peek());
            Console.WriteLine("Primeiro elemento da pilha: {0}", pilhaInt.First());
            Console.WriteLine("Último elemento da pilha: {0}", pilhaInt.Last());

            mostraPilha(pilhaInt);

            Console.WriteLine("Retirado da pilha: {0}", pilhaInt.Pop());

            mostraPilha(pilhaInt);

            Console.WriteLine("Retirado da pilha: {0}", pilhaInt.Pop());
            Console.WriteLine("Retirado da pilha: {0}", pilhaInt.Pop());
            Console.WriteLine("Retirado da pilha: {0}", pilhaInt.Pop());
            Console.WriteLine("Retirado da pilha: {0}", pilhaInt.Pop());
            mostraPilha(pilhaInt);

            Console.ReadKey();
        }

        static void mostraPilha(Stack<int> pi)
        {
            Console.WriteLine("--- Qtde: {0} ------", pi.Count);
            foreach (int i in pi)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("------------------");
            Console.WriteLine();
        }
    }
}
