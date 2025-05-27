//時間複雜度	O(n)	一次過濾 + 一次雙指標比較
//空間複雜度	O(n)	需要額外存放過濾後的字串字元

public class Solution
{
    public bool IsPalindrome(string s)
    {

        s = RemoveNonAlphnumericChar(s);
        int startIndex = 0;
        int endIndex = s.Length - 1;

        while (startIndex < endIndex)
        {
            if (s[startIndex] != s[endIndex])
                return false;

            startIndex++;
            endIndex--;
        }

        return true;
    }

    public string RemoveNonAlphnumericChar(string s)
    {
        List<char> charList = new List<char>();
        foreach (char c in s)
        {
            if ((c >= '0' && c <= '9')
            || (c >= 'A' && c <= 'Z')
            || (c >= 'a' && c <= 'z'))
                charList.Add(c);
        }

        return new string(charList.ToArray()).ToLower();
    }
}