namespace longestPalindromeSubstring
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(longestPalindrome("babad"));
        }

        static int longestPalindrome(string s)
        {
            // get length of input String
            int n = s.Length;

            // All subStrings of length 1
            // are palindromes
            int maxLength = 1, start = 0;

            // Nested loop to mark start and end index
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i; j < s.Length; j++)
                {
                    int flag = 1;

                    // Check palindrome
                    for (int k = 0; k < (j - i + 1) / 2; k++)
                        if (s[i + k] != s[j - k])
                            flag = 0;

                    // Palindrome
                    if (flag != 0 && (j - i + 1) > maxLength)
                    {
                        start = i;
                        maxLength = j - i + 1;
                    }
                }
            }

            Console.Write("longest palindrome subString is: ");
            printSubStr(s, start, start + maxLength - 1);

            // return length of LPS
            return maxLength;
        }

        static void printSubStr(String str, int low, int high)
        {
            for (int i = low; i <= high; ++i)
                Console.Write(str[i]);
        }

    }
}