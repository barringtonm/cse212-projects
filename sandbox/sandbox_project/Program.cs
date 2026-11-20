using System;
using System.Collections.Generic;
//==============================
//1.STACK USING A LINKED LIST(LIFO)
//==============================
Console.WriteLine("===Stack Demo (Head = Tail) ===");
LinkedList<string> stack = new();

//Push -->AddFirst (O(1))

stack.AddFirst("Page 1");
stack.AddFirst("Page 2");
stack.AddFirst("Page 3"); //Page 3 is the head (top) of the stack

//GetTop ->First.Value (O(1))    
if (stack.First != null)
{
    Console.WriteLine($"Top of the stack: {stack.First.Value}");
}


//Pop -->RemoveFirst (O(1))
if (stack.First != null)
{
    string poppedItem = stack.First.Value;
    stack.RemoveFirst();
    Console.WriteLine($"Popped from the stack: {poppedItem}");
}


//==============================
//2.QUEUE USING A LINKED LIST(FIFO) 
//==============================
Console.WriteLine("===Queue Demo (Head = Front,Tail = Back)// ===");
LinkedList<string> queueList = new();

//Enqueue -->AddLast (O(1))
queueList.AddLast("Person A");
queueList.AddLast("Person B");
queueList.AddLast("Person C"); //Person C is the tail (back) of the queue

//Size ->Count (O(1))
Console.WriteLine($"Size of the queue: {queueList.Count}");

//Dequeue ->RemoveFirst.Value (O(1))
if (queueList.First != null)
{
    Console.WriteLine($"Front of the queue: {queueList.First.Value}");
}

//Dequeue -->RemoveFirst (O(1))
if (queueList.First != null)
{
    string served = queueList.First.Value;
    queueList.RemoveFirst();
    Console.WriteLine($"Dequeued (served);from the queue: {served}");
}
//IsEmpty ->Count == 0 (O(1))
Console.WriteLine($"Is the queue empty? {queueList.Count == 0}");