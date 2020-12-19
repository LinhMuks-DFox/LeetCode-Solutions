using System;

namespace _0x0D {
    class Program {
        static void Main (string[] args) 
        {
            Solution s = new Solution ();

            Console.WriteLine ($"VIIV: {s.RomanToInt("VIIV")}");
        }
    }
    /*Tested! Well Done!*/
    public class Solution {

        public int RomanToInt (string s) {
            int sum = 0;
            int preNum = Map (s[0]);
            for (int i = 1; i < s.Length; i++) {
                int num = Map (s[i]);
                if (preNum < num) {
                    sum -= preNum;
                } else {
                    sum += preNum;
                }
                preNum = num;
            }
            sum += preNum;
            return sum;
        }

        private int Map (char c) {
            switch (c) {
                case 'I':
                case 'i':
                    return 1;
                case 'V':
                case 'v':
                    return 5;
                case 'X':
                case 'x':
                    return 10;
                case 'L':
                case 'l':
                    return 50;
                case 'C':
                case 'c':
                    return 100;
                case 'D':
                case 'd':
                    return 500;
                case 'M':
                case 'm':
                    return 1000;
                default:
                    return default;
            }
        }
    }
}