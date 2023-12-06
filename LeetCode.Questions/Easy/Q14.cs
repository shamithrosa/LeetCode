namespace LeetCode.Questions.Easy
{
    public class Q14
    {
        public string LongestCommonPrefix(string[] testInput)
        {
            if (testInput.Length == 0 || testInput == null) return string.Empty;

            for (int i = 0; i < testInput[0].Length; i++)
            {
                char currentchar = testInput[0][i];

                for (int j = 0; j < testInput.Length; j++)
                {
                    var abc = testInput[j].Length;
                    var xyz = testInput[j][i];

                    if (i == testInput[j].Length || testInput[j][i] != currentchar)
                    {
                        return testInput[0].Substring(0, i);
                    }
                }
            }

            return testInput[0];
        }
    }
}
