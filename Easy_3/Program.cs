/*
 * https://leetcode.com/problems/roman-to-integer/
 */
int RomanToInt(string s)
{
    Dictionary<char, int> romanDictionary = new Dictionary<char, int>
        { { 'I', 1 }, { 'V', 5 }, { 'X', 10 }, { 'L', 50 }, { 'C', 100 }, { 'D', 500 }, { 'M', 1000 } };
    ;
    int res = 0;
    int x = 0;

    for (var i = s.Length - 1; i >= 0; i--)
    {
        if (x <= romanDictionary[s[i]])
        {
            res += romanDictionary[s[i]];
            x = romanDictionary[s[i]];
        }
        else
        {
            res -= romanDictionary[s[i]];
        }
    }

    return res;
}