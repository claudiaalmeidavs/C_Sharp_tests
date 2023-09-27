using System;
using System.Linq;
/* 
LINQ (Language Integrated Query) is a set of extensions that provides a way to query and manipulate data from data sources, such as arrays, collections, databases, and XML.
In this example, we're importing the Concat method.
*/

class Program
{
    static void Main()
    {
        string[] femaleNames = {"Cláudia", "Maria", "Mariana", "Vanessa", "Liliana"};
        string[] maleNames = {"João", "Luís", "Carlos", "Francisco", "Jupiter"};
        string[] allNames = femaleNames.Concat(maleNames).ToArray();

        foreach (string name in allNames)
        
       {
       Console.WriteLine(name);
       }
    }
}