using System;
/*
    Link: https://leetcode-cn.com/problems/string-to-integer-atoi/
    
    1. Normal case
    >>>"42"
    -->42

    2. Normal case2
    >>>"   42"
    -->42
    
    3. Return 0 while the first non-null char is not a number.
    >>>"This is test of convert string'42' to int"
    -->0

    4. Return (2**31-1 / -2**31) when inputted number is overflow
    >>>"-91283472332" 
    >>>-2147483648

    5. 
    >>>"424 with word"
    -->424
*/
public class Solution
{
    public int MyAtoi(string s)
    {
        Converter converter = new Converter();
        return converter.Convert(s);
    }
}

public class Converter
{
    public int Convert(string str)
    {
        int n = str.Length, index = 0;
        int sign = 1; int ret = 0;
        while (index < n && str[index] == ' ')
        {
            index++;
        }
        if (index == n)
            return 0;
        if (str[index] == '+')
        {
            index++;
        }
        else if (str[index] == '-')
        {
            sign *= -1;
            index++;
        }
        else if (!Char.IsDigit(str[index]))
            return 0;
        while (index < n && Char.IsDigit(str[index]))
        {
            int digit = str[index] - '0';
            if (ret > (Int32.MaxValue - digit) / 10) {
                // 本来应该是 ans * 10 + digit > Integer.MAX_VALUE
                // 但是 *10 和 + digit 都有可能越界，所有都移动到右边去就可以了。
                return sign == -1? Int32.MinValue : Int32.MaxValue;
            }
            ret = ret * 10 + digit;
            index++;
        }

        return ret * sign;
    }

}


public class MainPro
{
    public static void Main()
    {
        string test = "-4252 with world!"; // --> -4252
        Console.WriteLine(new Solution().MyAtoi(test));
    }
}

