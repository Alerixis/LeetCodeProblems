using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    //Instrustions: Make a string converter from Roman Numeral string to an integer.
    public class RomanToInteger
    {
        private Dictionary<char, int> RomanCharMap = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        public void Run()
        {
            int result = RomanToInt("MCMXCIV");
            int test = 0;
        }

        public int RomanToInt(string s)
        {
            int value = 0;
            for(int i = 0; i < s.Length; i++)
            {
                switch(s[i])
                {
                    case 'I':
                        if(i < s.Length - 1 && (s[i + 1] == 'V' || s[i + 1] == 'X'))
                        {
                            value += RomanCharMap[s[++i]] - 1;
                        }
                        else
                        {
                            value++;
                        }
                        break;
                    case 'X':
                        if (i < s.Length - 1 && (s[i + 1] == 'L' || s[i + 1] == 'C'))
                        {
                            value += RomanCharMap[s[++i]] - 10;
                        }
                        else
                        {
                            value += RomanCharMap[s[i]];
                        }
                        break;
                    case 'C':
                        if (i < s.Length - 1 && (s[i + 1] == 'D' || s[i + 1] == 'M'))
                        {
                            value += RomanCharMap[s[++i]] - 100;
                        }
                        else
                        {
                            value += RomanCharMap[s[i]];
                        }
                        break;
                    default:
                        if (RomanCharMap.ContainsKey(s[i]))
                        {
                            value += RomanCharMap[s[i]];
                        } else
                        {
                            Console.WriteLine("Found an invalid character in the string: (" + s[i] + ")");
                        }
                        break;
                }
            }
            return value;
        }
    }
}
