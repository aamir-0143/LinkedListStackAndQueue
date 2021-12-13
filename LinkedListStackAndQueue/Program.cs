using System;

namespace LinkedListStackAndQueue
{ 


    class Program
    {
        static void Main(string[] agrs) 
        {
            Console.WriteLine("Hello World !");

            LinkedListStack linkedListStack = new LinkedListStack();
            linkedListStack.Push(70);
            linkedListStack.Push(30);
            linkedListStack.Push(56);
            linkedListStack.Display();

        }
    
    }
}