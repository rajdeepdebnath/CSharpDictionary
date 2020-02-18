using System;
using System.Collections.Generic;

namespace CSharpDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var newDictionary = new Dictionary<int, int>();

            newDictionary.Add(1,5);
            newDictionary.Add(2,10);

            newDictionary.Clear();

            foreach (var item in newDictionary)
            {
                Console.WriteLine($"key:{item.Key},value{item.Value}");
            }


            Console.WriteLine("done...");
        }
    }
}
