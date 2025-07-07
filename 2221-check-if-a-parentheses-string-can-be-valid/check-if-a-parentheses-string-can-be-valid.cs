public class Solution
{
    public bool CanBeValid(string s, string locked)
    {
        int length = s.Length;

        // If length of string is odd, return false.
        if (length % 2 == 1)
        {
            return false;
        }

        Stack<int> openBrackets = new Stack<int>();
        Stack<int> unlocked = new Stack<int>();

        // Iterate through the string to handle '(' and ')'
        for (int i = 0; i < length; i++)
        {
            if (locked[i] == '0')
            {
                unlocked.Push(i);
            }
            else if (s[i] == '(')
            {
                openBrackets.Push(i);
            }
            else if (s[i] == ')')
            {
                if (openBrackets.Count > 0)
                {
                    openBrackets.Pop();
                }
                else if (unlocked.Count > 0)
                {
                    unlocked.Pop();
                }
                else
                {
                    return false;
                }
            }
        }

        // Match remaining open brackets with unlocked characters
        while (
            openBrackets.Count > 0 &&
            unlocked.Count > 0 &&
            openBrackets.Peek() < unlocked.Peek()
        )
        {
            openBrackets.Pop();
            unlocked.Pop();
        }

        if (openBrackets.Count > 0)
        {
            return false;
        }

        return true;
    }
}
