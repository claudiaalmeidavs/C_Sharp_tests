using System;

public class ConvertVariables {
    static void Main() {
        int x = int.MaxValue;
        long y = long.MaxValue;
        short z = short.MaxValue;

        long sum = (long)x + y + z;

        Console.WriteLine(sum);
    }
}