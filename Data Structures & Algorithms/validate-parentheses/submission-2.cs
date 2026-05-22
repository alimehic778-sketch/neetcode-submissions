
public class Solution
{
    public bool IsValid(string s)
    {
        if (s.Length % 2 != 0)
            return false;

        while (s.Contains("()") || s.Contains("[]") || s.Contains("{}"))
        {
            s = s.Replace("()", "")
                 .Replace("[]", "")
                 .Replace("{}", "");
        }

        return s.Length == 0;
    }
}