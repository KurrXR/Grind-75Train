//最佳優化 但用Dic會多元一點

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        int[] count = new int[26];

        for (int i = 0; i < s.Length; i++)
        {
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        foreach (int c in count)
        {
            if (c != 0)
                return false;
        }
        return true;
    }
}


/*
public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> count = new Dictionary<char, int>();

        foreach (char c in s) {
            if (!count.ContainsKey(c))
                count[c] = 0;
            count[c]++;
        }

        foreach (char c in t) {
            if (!count.ContainsKey(c))
                return false;

            count[c]--;
            if (count[c] < 0)
                return false;
        }

        return true;
    }
}
*/