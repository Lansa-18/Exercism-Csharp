using System.Text;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        // Using a string builder to build the resulting string.
        var result = new StringBuilder();

        // looping over each character in the text.
        foreach (char c in text)
        {
            if (char.IsLower(c))
            {
                // getting the position of the character
                int position = c - 'a';
                position = (position + shiftKey) % 26;

                // converting back to a letter and appending.
                int newCharASCII = 'a' + position;
                result.Append((char) newCharASCII);

            }
            else if (char.IsUpper(c))
            {
                // getting the position of the character
                int position = c - 'A';
                position = (position + shiftKey) % 26;
                int newCharASCII = 'A' + position;

                result.Append((char) newCharASCII);
            }
            else
            {
                result.Append(c);
            }
        }

        return result.ToString();
    }
}