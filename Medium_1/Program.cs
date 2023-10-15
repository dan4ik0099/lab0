int LengthOfLongestSubstring(string s)
{
    var str = "";
    var i = 0;
    var max = 0;
    var l = 0;
    for (; i < s.Length; i++)
    {
        if (!str.Contains(s[i]))
        {
            str += s[i];
            if (str.Length > max)
            {
                max = str.Length;
            }
        }
        else
        {
            l++;
            str = "";
            i = 0 + l;
            i--;
        }
    }

    return max;
}