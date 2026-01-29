
namespace TS.TechnicalTest;

public class LongestSentanceAnswer
{
    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
        return 0;

        char[] delimitersForSentence = { '-', '?', '!' };
        var sentences = s.Split(delimitersForSentence, StringSplitOptions.RemoveEmptyEntries);

        int wordCount = 0;

        foreach (var sentence in sentences)
        {
            var words = sentence.Split(' ', StringSplitOptions.RemoveEmptyEntries).Count(w => w.Any(char.IsLetter));
            if (words > wordCount)
            {
                wordCount = words;
            }
        }

        return wordCount;
    }
}
