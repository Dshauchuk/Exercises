namespace Leetcode.Tasks;

internal class MakeGoodStringTask
{
    public string MakeGood(string s)
    {
        List<char> result = new List<char>(s.Length);
        bool stringIsGood;

        do
        {
            stringIsGood = true;

            if (s.Length < 2)
                return s;

            for (int i = 0; i < s.Length; i++)
            {
                if (i == s.Length - 1)
                {
                    result.Add(s[i]);
                    continue;
                }

                if ((char.IsUpper(s[i]) && char.ToLower(s[i]) == s[i + 1]) ||
                    (char.IsLower(s[i]) && char.ToUpper(s[i]) == s[i + 1]))
                {
                    i++;
                    stringIsGood = false;
                    continue;
                }
                else
                    result.Add(s[i]);
            }

            if (!stringIsGood)
            {
                s = new string(result.ToArray());
                result.Clear();
            }
        }
        while (!stringIsGood);

        return new string(result.ToArray());
    }
}