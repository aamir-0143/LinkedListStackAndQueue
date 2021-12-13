using System;

namespace LinkedListStackAndQueue
{ 


    class Program
    {
        static void Main(string[] agrs) 
        {
            Console.WriteLine("Hello World !");
            //LinkedListStack linkedListStack = new LinkedListStack();
            //linkedListStack.Push(70);
            //linkedListStack.Push(30);
            //linkedListStack.Push(56);
            //linkedListStack.Display();
            //linkedListStack.peek();
            //linkedListStack.pop();
            //linkedListStack.IsEmpty();
            //linkedListStack.Display();




            LinkedListQueue linkedListQueue = new LinkedListQueue();
            linkedListQueue.Enqueue(56);
            linkedListQueue.Enqueue(30);
            linkedListQueue.Enqueue(70);
            linkedListQueue.Display();
            linkedListQueue.Dequeue();
            linkedListQueue.Display();
           

        }

    }
}