
Console.WriteLine(IsAnagram("anagram", "nagaram"));

bool IsAnagram(string s, string t)
{
    if (s.Length != t.Length)
    {
        return false;
    }

    Dictionary<char, int> dicS = new Dictionary<char, int>();
    Dictionary<char, int> dicT = new Dictionary<char, int>();

    for (int i = 0; i < s.Length; i++)
    {

        if (dicS.ContainsKey(s[i]))
        {
            dicS[s[i]] = dicS[s[i]] + 1;
        }
        else
        {
            dicS.Add(s[i], 1);
        }

    }

    var dicSAsList = dicS.ToList();

    for (int i = 0; i < t.Length; i++)
    {

        if (dicT.ContainsKey(t[i]))
        {
            dicT[t[i]] = dicT[t[i]] + 1;
        }
        else
        {
            dicT.Add(t[i], 1);
        }

    }

    var dicTAsList = dicT.ToList();

    for (int i = 0; i < dicSAsList.Count; i++)
    {
        if (!dicTAsList.Exists(x => x.Key == dicSAsList[i].Key && x.Value == dicSAsList[i].Value))
        {
            return false;
        }
    }

    return true;
}