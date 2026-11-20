using System;
using System.Collections.Generic;
using System.Linq;

LinkedList<string> linkedList = new();
linkedList.AddFirst("A");
linkedList.Remove("B");
linkedList.Find("C");
linkedList.AddLast("E");



Console.WriteLine("Linked List Contents:");
foreach (var item in linkedList)
{
    Console.WriteLine(item);
}
