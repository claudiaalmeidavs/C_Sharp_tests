using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> stringCollection = new List<string>();

        stringCollection.Add("Adding a string");
        stringCollection.Add("Adding another string");
        stringCollection.Add("Adding one more string");
        stringCollection.RemoveAt(0);
        stringCollection.Remove("Adding one more string");

        foreach (string str in stringCollection)
        {
            Console.WriteLine(str);
        }
    }
}