namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points == null || points.Length < 3)
        return -1;

        int deepest = -1;
        int index = 0;

        while (index < points.Length - 1)
        {
            if (IsPitStart(points, index))
            {
                int p = index;
                int q = FindValley(points, p);
                int r = FindBridge(points, q);

                if (isValidPit(p, q, r))
                {
                    deepest = Math.Min(deepest, CalculateDepth(points, p, q, r);
                }
                index = r;
            }
            else
            {
                   index++;
            }
        }

        return deepest;
    }

    private static bool IsValid(int[] points) => points == null || points.Length < 3;

    private static bool IsPitStart(int[] points, int index) => points[index] > 0 && points[index] > points[index + 1];

    private static int FindValley(int[] points, int start)
    {
        int i = start + 1;
        while (i + 1 < points.Length && points[i] < points[i + 1])
            i++;

        return i;
    }

    private static int FindBridge(int[] points, int valley)
    {
        int i = valley;

        while (i + 1 < points.Length && points[i] < points[i + 1]) i++;
        return i;
    }


    private static bool isValidPit(int p, int q, int r) => p < q && q < r;

    private static int CalculateDepth(int[] points, int p, int q, int r) => Math.Min(points[q], points[r]) - points[q])

}
