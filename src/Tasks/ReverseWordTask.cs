namespace Leetcode.Tasks;

internal class ReverseWordTask
{
    public string ReverseWords(string s)
    {
        Stack<string> words = new Stack<string>();
        List<char> word = new List<char>(s.Length);

        bool prevSpace = false;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != ' ')
            {
                word.Add(s[i]);
                prevSpace = false;
            }
            else if ((!prevSpace || i == s.Length - 1) && word.Any())
            {
                prevSpace = true;
                words.Push(new string(word.ToArray()));
                word.Clear();
            }
        }

        if (word.Any())
            words.Push(new string(word.ToArray()));

        return string.Join(" ", words);
    }
}