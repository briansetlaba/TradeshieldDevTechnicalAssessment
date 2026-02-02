
namespace TS.TechnicalTest;

public class LongestSentenceAnswer
{
    private static readonly char[] SentenceDelimiters = { '.', '?', '!' };

    public static int Solution(string s)
    {
        if (string.IsNullOrWhiteSpace(s))
            return 0;

        return GetSentences(s)
        .Select(CountWordsWhichAreValid)
        .Max();
    }

    private static IEnumerable<string> GetSentences(string text)
    {
        return text.Split(
        SentenceDelimiters,
        StringSplitOptions.RemoveEmptyEntries
        );
    }

    private static int CountWordsWhichAreValid(string sentence)
    {
        return sentence
        .Split(' ', StringSplitOptions.RemoveEmptyEntries)
        .Count(IsValidWord);
    }

    private static bool IsValidWord(string token)
    {

        return token.Any(char.IsLetter);
    }
}
