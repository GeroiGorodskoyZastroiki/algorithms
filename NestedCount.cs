using System.Collections;

public static class IEnumerableExtensions
{
    public static int NestedCount(this IEnumerable array)
    {
        int count = 0;

        foreach (var item in array)
            count += (item is IEnumerable subArray && item is not string) ? subArray.NestedCount() : 1;

        return count;
    }
}
