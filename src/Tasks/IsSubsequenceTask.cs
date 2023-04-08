namespace Leetcode.Tasks;

internal class IsSubsequenceTask
{
    public bool IsSubsequence(string s, string t)
    {
        if (s.Length > t.Length)
            return false;

        int currentIndex = -1, prevIndex = -1;
        for (int i = 0; i < s.Length; i++)
        {
            currentIndex = t.IndexOf(s[i], prevIndex + 1);

            if (currentIndex < 0 || currentIndex < prevIndex)
                return false;

            prevIndex = currentIndex;
        }

        return true;
    }
}