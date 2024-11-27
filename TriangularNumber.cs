public class IsTriangularNumber
{    
    public static bool IsNumberTriangular(long x)
    {
        //Формула:
        // x = n(n + 1) / 2, где x - это n-ое треугольное число.
        // n^2 + n - 2x = 0
        // n = (-1 ± √(1 + 8x)) / 2

        if (x <= 0) return false;

        long discriminant = 1 + 8 * x;

        // Проверяем, что корень дискриминанта целое число (если это так, то в числителе получится целое число), 
        // а значит n - целое, а значит x - тругольное число n-ого места в последовательности треугольных чисел
        long sqrtDiscriminant = (long)Math.Sqrt(discriminant);
        return sqrtDiscriminant * sqrtDiscriminant == discriminant;
    }
}