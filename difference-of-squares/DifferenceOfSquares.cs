public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        int sum = 0;

        for (int i = 0; i <= max; i++)
        {
            sum += i;
        }

        return (int) Math.Pow(sum, 2);

        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateSumOfSquares(int max)
    {
        int sum = 0;

        for (int i = 0; i <= max; i++)
        {
            sum += (int)Math.Pow(i, 2);
        }

        return sum;
        throw new NotImplementedException("You need to implement this method.");
    }

    public static int CalculateDifferenceOfSquares(int max)
    {
        int squareOfSum = CalculateSquareOfSum(max);
        int sumOfSquares = CalculateSumOfSquares(max);

        return squareOfSum - sumOfSquares;
        throw new NotImplementedException("You need to implement this method.");
    }
}