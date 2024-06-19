using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;

namespace MathLib;

public static class Math1 {

    public static int Add (int x, int y) { 
        return x + y; 
    }
    public static int Sub (int x, int y) { 
        return x - y; 
    }
    public static int Mult (int x, int y) {
        return x * y; 
    }
    public static int Div (int x, int y) {
        return (x / y); 
    }
    public static int Mod (int x, int y) { 
        return x - (x / y * y); 
    }
    public static int Sqr(int x) {
        return x * x;
    }
    public static int Fact(int x) {
        var sum = 1;
        for (int i = x; i > 1; i--) {
            sum *= i;
        }
        return sum;
    }
  
}
