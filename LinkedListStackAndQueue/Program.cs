using System;

namespace LinkedListStackAndQueue
{ 


    class Program
    {
        static void Main(string[] agrs) 
        {
            Console.WriteLine("Hello World !");

            LinkedListStack LinkedListStack = new LinkedListStack(); 
            LinkedListStack.Push(70);
            LinkedListStack.Push(30);
            LinkedListStack.Push(56);
            LinkedListStack.Display();
        }
    
    }
}