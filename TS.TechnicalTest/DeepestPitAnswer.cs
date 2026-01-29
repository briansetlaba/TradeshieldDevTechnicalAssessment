namespace TS.TechnicalTest;

public class DeepestPitAnswer
{
    public static int Solution(int[] points)
    {
        if (points == null || points.Length < 3)
        return -1;

        int deepest = -1;

        for (int i = 0; i < points.Length -1; i++)
        {
            if (points[i] > 0 && points[i] > points[i + 1])
            {
                int p = i;
                int q = i + 1;

                while (q + 1 < points.Length && points[q] > points[q + 1])
                {
                    q++;
                }
            }
        }

        return deepest;
    }
}
