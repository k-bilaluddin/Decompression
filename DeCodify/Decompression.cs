using System.Text;

namespace DeCodify
{
    public class Decompression
    {
        public string DecodeString(string s)
        {
            if (string.IsNullOrEmpty(s))
                return string.Empty;

            var result = new StringBuilder();
            var currentLetters = new StringBuilder();

            int i = 0;

            while (i < s.Length)
            {
                if (char.IsLetter(s[i]))
                {
                    currentLetters.Append(s[i]);
                    i++;
                }
                else if (char.IsDigit(s[i]))
                {
                    if (currentLetters.Length == 0)
                        return string.Empty;

                    int start = i;
                    while (i < s.Length && char.IsDigit(s[i]))
                    {
                        i++;
                    }

                    int repeat = int.Parse(s.Substring(start, i - start));

                    if (repeat > 0)
                    {
                        for (int j = 0; j < repeat; j++)
                        {
                            result.Append(currentLetters);
                        }
                    }

                    currentLetters.Clear();
                }
                else
                {
                    throw new InvalidOperationException("Invalid character in input string.");
                }
            }

            return result.ToString();
        }
    }
}
