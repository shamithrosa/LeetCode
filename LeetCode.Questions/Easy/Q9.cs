using System.Linq;

namespace LeetCode.Questions.Easy
{
    public class Q9
    {
        public bool IsPalindrome(int x)
        {
            if(x < 0) return false;

            string strNum = x.ToString();
            var charArray = strNum.ToCharArray();
            var reveresCharArray = charArray.Reverse().ToArray();
            var reverseStrNum = new string(reveresCharArray);

            if (strNum == reverseStrNum)
                return true;
            else return false;
        }
    }
}
