namespace lengthOfLongestSubstringWithoutRepeatingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // https://leetcode.com/problems/longest-substring-without-repeating-characters/solution/
            Console.WriteLine(LengthOfLongestSubstring("abcabcbb"));
        }

        static int LengthOfLongestSubstring(string s)
        {
            var dummyString = "";
            var result = -1;

            // Return zero if string is empty
            if (s.Length == 0)
                return 0;
            else if (s.Length == 1)
                return 1;

            foreach (char c in s)
            {
                // If string already contains the character
                // Then substring after repeating character
                if (dummyString.Contains(c))
                {
                    dummyString = dummyString.Substring(dummyString.IndexOf(c) + 1);
                }
                dummyString = dummyString + c;
                result = Math.Max(dummyString.Length, result);
            }
            return result;

        }
    }
}
