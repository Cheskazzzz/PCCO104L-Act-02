using System;

class Program {
public static void Main(string [] args)
    {
        int X = 30;
      
        for (int i = 1; i <= X; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
            {
               Console.WriteLine($"{i} - FooBar");
            }
            else if (i % 3 == 0)
            {
Console.WriteLine($"{i} - Foo");
            }
            else if (i % 5 == 0)
            {
                Console.WriteLine($"{i} - Bar");

            }
            else
            {
              Console.WriteLine(i);
            }
        }
    }
}

