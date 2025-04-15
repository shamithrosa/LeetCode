namespace LeetCode.Questions.Easy
{
    /// <summary>
    /// Given a roman numeral, convert it to an integer.
    /// </summary>
    public class Q13
    {
        public int RomanToInt(string romanNumString)
        {
            int sum = 0;
            int arrLength = romanNumString.Length;

            for (int i = 0; i < arrLength; i++)
            {
                if (romanNumString[i] == 'I')
                {
                    sum += 1;
                    if (i + 1 < arrLength)
                    {
                        if (romanNumString[i + 1] == 'V')
                        {
                            sum += 3;
                            i++;
                        }
                        else if (romanNumString[i + 1] == 'X')
                        {
                            sum += 8;
                            i++;
                        }

                    }

                }
                else if (romanNumString[i] == 'V')
                {
                    sum += 5;
                }
                else if (romanNumString[i] == 'X')
                {
                    sum += 10;
                    if (i + 1 < arrLength)
                    {
                        if (romanNumString[i + 1] == 'L')
                        {
                            sum += 30;
                            i++;
                        }
                        else if (romanNumString[i + 1] == 'C')
                        {
                            sum += 80;
                            i++;
                        }
                    }
                }
                else if (romanNumString[i] == 'L')
                {
                    sum += 50;
                }
                else if (romanNumString[i] == 'C')
                {
                    sum += 100;
                    if (i + 1 < arrLength)
                    {
                        if (romanNumString[i + 1] == 'D')
                        {
                            sum += 300;
                            i++;
                        }
                        else if (romanNumString[i + 1] == 'M')
                        {
                            sum += 800;
                            i++;
                        }
                    }
                }
                else if (romanNumString[i] == 'D')
                {
                    sum += 500;
                }
                else if (romanNumString[i] == 'M')
                {
                    sum += 1000;
                }
            }

            return sum;
        }
    }
}
