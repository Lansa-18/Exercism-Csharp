public static class ReverseString
{
    public static string Reverse(string input)
    {
        char[] charArr = new char[input.Length];
        int counter = 0;

        for (int i = input.Length - 1; i >= 0; i--)
        {
            charArr[counter] = input[i];
            counter++;
        }

        return new string(string.Join(string.Empty, charArr));
    }
}