namespace LeetCode.Questions.Easy
{
    public class Q28
    {
        public int FindNeedleInHaystack(string haystack, string needle)
        {
            //convert both strings to char array
            var haystack_char = haystack.ToCharArray();
            var needle_char = needle.ToCharArray();
            int needleCharArraySize = needle_char.Length;

            //check if haystack 1st char is equal to needle 1st char & check if needle last char equals to heystack index of needle length position char
            char needle_firstchar = char.MinValue;
            char needle_lastChar = char.MinValue;

            if (haystack.Contains(needle))
                if (needleCharArraySize > 0 && haystack_char.Length >= needleCharArraySize)
                {
                    needle_firstchar = needle_char[0];
                    needle_lastChar = needle_char[needleCharArraySize - 1];

                    if (haystack_char.Length > 0)
                    {
                        for (int i = 0; i < haystack_char.Length; i++)
                        {
                            if (needle_firstchar == haystack_char[i])
                            {
                                if (needle_lastChar == haystack_char[needleCharArraySize - 1 + i])
                                {
                                    string subStr = haystack.Substring(i, needleCharArraySize);
                                    if (needle.Equals(subStr))
                                    {
                                        return i;
                                    }
                                }
                            }
                        }
                    }
                }

            return -1;
        }

        /*
        var match = Regex.Match(haystack, needle);
        if (match.Success)
            return match.Index;
        else
            return -1;
        */

        /*
         return haystack.IndexOf(needle);
         */
    }
}
