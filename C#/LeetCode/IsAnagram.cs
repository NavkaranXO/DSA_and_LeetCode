// Using Sorting
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
        {
          return false;
        }
        char[] n;
        char[] m;
        
        n = s.ToCharArray(0, s.Length);
        m = t.ToCharArray(0, t.Length);

        Array.Sort(n);   
        Array.Sort(m);

        string s1 = new string(n);

        string s2 = new string(m);
        if( s1 == s2 ) {
            return true;
        }
        else {
            return false;
        }
    }
}

// Using HashMap
public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
        {
            return false;
        }

        Dictionary<char, int> n = new Dictionary<char, int>();
        Dictionary<char, int> m = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            n[s[i]] = n.GetValueOrDefault(s[i], 0) + 1;
            m[t[i]] = m.GetValueOrDefault(t[i], 0) + 1;
        }

        if (!n.Except(m).Any())
        {
            return n.Count == m.Count;
        }

        return false;
    }
}
