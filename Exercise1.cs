using System;

namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("hello, what is your name ");
      string name = Console.ReadLine();

      Console.WriteLine("how old are you ");
      int age = Console.ReadLine();

      Console.WriteLine($"Hello, {name}! You are {age} years old.");
     }
  }
}