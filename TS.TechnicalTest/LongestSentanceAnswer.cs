
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        return 0;

        char[] delimitersForSentence = { '-', '?', '!' };
        var sentences = s.Split(delimitersForSentence);

        return sentences.Length;
    }
}
