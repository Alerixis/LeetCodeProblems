using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{

    /*Instructions: 
    Implement atoi which converts a string to an integer.

    The function first discards as many whitespace characters as necessary until the first non-whitespace character is found. 
    Then, starting from this character takes an optional initial plus or minus sign followed by as many numerical digits as possible, and interprets them as a numerical value.
    
    The string can contain additional characters after those that form the integral number, which are ignored and have no effect on the behavior of this function.
    
    If the first sequence of non-whitespace characters in str is not a valid integral number, or if no such sequence exists because either str is empty 
    or it contains only whitespace characters, no conversion is performed.
    
    If no valid conversion could be performed, a zero value is returned.
    
    */

    public class AtoIImplementation
    {
        public void Run()
        {
            int result = MyAtoi("-91283472332");
        }

        public int MyAtoi(string s)
        {
            //Trim whitespace
            s = s.Trim();
            if(s.Length <= 0)
            {
                return 0;
            }

            //Check for sign
            int index = 0;
            int sign = 1;

            if (s[index] == '-' || s[index] == '+')
            {
                index++;
                sign = s[0] == '+' ? 1 : -1;
            }

            int result = 0;
            while(index < s.Length && s[index] >= '0' && s[index] <= '9')
            {
                if(result > Int32.MaxValue / 10 ||
                    (result == Int32.MaxValue / 10 && s[index] - '0' > Int32.MaxValue % 10))
                {
                    return (sign == 1) ? Int32.MaxValue : Int32.MinValue;
                }
                result = result * 10 + (s[index++] - '0');
            }
            return result * sign;
        }
    }
}
