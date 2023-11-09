public class LimitedInt {
    public int limit1;
    public int limit2;
    public int userInt;
    public int LimitInt() {
        if (userInt >= limit1 && userInt <= limit2) {
            return userInt;
        }
        else if (userInt > limit2) {
            return limit2;
        }
        else {
            return limit1;
        }
    }
}

using System;

public class LimitedIntTest {
    static void Main() {
        LimitedInt limitedInt = new LimitedInt();

        limitedInt.limit1: 10;
        limitedInt.limit2: 20;
        limitedInt.userInt: 15;

        int result = limitedInt.LimitInt();

        Console.WriteLine("Limited integer: " + result);
    }
}