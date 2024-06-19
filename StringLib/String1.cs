namespace StringLib;

public class String1 {

    public string Concat (string a, string b) {
        return $"{a} {b}";              // return a + " " + b
    }

    public string Upper(string a) {
        return a.ToUpper();
    }

    public string ToUpperEveryOther(string str) {
        var toUpper = true;
        var converted = string.Empty;
        foreach (var ch in str.ToCharArray()) {
            if (!char.IsLetter(ch)) {
                converted += ch;
                continue;
            }
            if (toUpper) {
                converted += ch.ToString().ToUpper();
            } else {
                converted += ch.ToString().ToLower();
            }
                toUpper = !toUpper;
        }
        return converted;
    }
}
