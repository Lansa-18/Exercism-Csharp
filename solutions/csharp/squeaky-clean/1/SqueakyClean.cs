using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < identifier.Length; i++)
        {
            char ch = identifier[i];

            bool isGreekLowerCase = char.IsLower(ch) && ch >= 0x0370 && ch <= 0x03FF;
            
            if (char.IsControl(ch))
            {
                sb.Append("CTRL");
            }
            else if (ch == '-')
            {
                if (i + 1 < identifier.Length && char.IsLetter(identifier[i + 1]))
                {
                    char nextChar = char.ToUpper(identifier[i + 1]);
                    sb.Append(nextChar);
                    i++;
                }
            }
            else if (ch == ' ')
            {
                sb.Append('_');
            }
            else if (isGreekLowerCase)
            {

            }
            else if (!char.IsLetter(ch) && ch != '_')
            {

            }
            else
            {
                sb.Append(ch);
            }
        }

        return sb.ToString();
    }
}
