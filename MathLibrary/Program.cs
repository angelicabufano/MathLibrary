using MathLib;
using StringLib;

namespace MathConsole;

internal class Program {
    static void Main(string[] args) {

        var mod = Math1.Mod(8, 3);
        Console.WriteLine($"8 % 3 is {mod}");

        var sqr = Math1.Sqr(12);
        Console.WriteLine(sqr);

        var fact = Math1.Fact(5);
        Console.WriteLine(fact);

        var sl = new String1();
        var newStr = sl.Concat("Hello," , "World!");
        Console.WriteLine(newStr);

        var answer = Math1.Add(11, 22);
        Console.WriteLine(answer);

        var upper = new String1();
        var newstr = upper.Upper("hello");
        Console.WriteLine(newstr);

        var converted = sl.ToUpperEveryOther("aBCdeFG");
        Console.WriteLine(converted);
    }
}
