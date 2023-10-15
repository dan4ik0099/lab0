bool IsPalindrome(int x)
{
    var str = x.ToString();
    var str2 = new string(str.Reverse().ToArray());
    if (str.Equals(str2))
    {
        return true;
    }

    return false;
}