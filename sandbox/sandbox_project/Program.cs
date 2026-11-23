using System;
using System.Collections.Generic;
SayHello(4);


void SayHello(int count)
{

    if (count <= 0)
    {
        return;
    }
    else
    {
        Console.WriteLine("Hello");
        SayHello(count - 1);
    }

}
