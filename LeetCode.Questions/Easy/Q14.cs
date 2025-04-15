namespace LeetCode.Questions.Easy
{
    /// <summary>
    /// Given an array of strings, find the longest common prefix string amongst them.
    /// </summary>
    public class Q14
    {
        public string LongestCommonPrefix(string[] arrayOfWords)
        {
            if (arrayOfWords.Length == 0 || arrayOfWords == null) return string.Empty;

            for (int i = 0; i < arrayOfWords[0].Length; i++)
            {
                char currentChar = arrayOfWords[0][i];

                for (int j = 0; j < arrayOfWords.Length; j++)
                {
                    var abc = arrayOfWords[j].Length;
                    var xyz = arrayOfWords[j][i];

                    if (i == arrayOfWords[j].Length || arrayOfWords[j][i] != currentChar)
                    {
                        return arrayOfWords[0].Substring(0, i);
                    }
                }
            }

            return arrayOfWords[0];
        }
    }
}
