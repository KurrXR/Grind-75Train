public class Solution
{
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> pairs = 
        new Dictionary<char, char>{ //因為左邊是Key,右邊是value 所以若DictionaryKey "(" 則去找 ")"
            {')','('},
            {']','['},
            {'}','{'}
        };
        foreach (char c in s)
        {
            if (pairs.ContainsValue(c)) // 若是左括號,則push進stack 由於這段是在確認Value,
            {
                stack.Push(c);
            }
            else if (pairs.ContainsKey(c)) // 若是右括號,則pop出stack 若不相等於對應的左括號,則return false
            {
                if (stack.Count == 0 || stack.Pop() != pairs[c])
                {
                    return false;
                }
            }
            else // 若不是括號,則return false
            {
                return false;
            }
        }
        return stack.Count == 0; // 若stack為空,則return true


    }
}

public class Solution
{
    public bool IsValid(string s)
    {
      
    }
}