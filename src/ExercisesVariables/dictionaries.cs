using System;
using System.Collections.Generic;

public class Dictionaries {
    static void Main() {
        var dictionaryLetters = new Dictionary<string, string>(){
            {"a", "apple"},
            {"b", "banana"},
            {"c", "carrot"}
        };
        Console.Write("Before removal: ");
        foreach (var kvp in dictionaryLetters)
            Console.Write(kvp.Key + " " + kvp.Value + " ");
        Console.WriteLine();
        dictionaryLetters.Remove("c");
        Console.Write("After removal: ");
        foreach (var kvp in dictionaryLetters)
            Console.Write(kvp.Key + " " + kvp.Value + " ");
    }
}