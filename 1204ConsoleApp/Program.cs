// See https://aka.ms/new-console-template for more information
RomanToInt("MCMXCIV");




static int RomanToInt(string s)
{
    int num = 0;
    int total = 0;
    int minus = 0;
    for (int i = 0; i < s.Length; i++)
    {
        switch (s[i])
        {
            case 'I':num = 1;break;
            case 'V':num = 5;break;
            case 'X':num = 10;break;
            case 'L':num = 50;break;
            case 'C':num = 100;break;
            case 'D':num = 500;break;
            case 'M':num = 1000;break;
        }
        total += num;
        if ( i < s.Length-1)
        {
            string test = s[i] + s[i + 1].ToString();
            switch (s[i] + s[i + 1].ToString())
            {
                case "IV":minus = 2;break;
                case "IX":minus = 2;break;
                case "XL":minus = 20;break;
                case "XC":minus = 20;break;
                case "CD":minus = 200;break;
                case "CM":minus = 200;break;
                default: minus = 0;break;
            }
            total -= minus;
        }
    }
    return total;
}

static string LongestCommonPrefix(string[] strs)
{
    for (int i = 0; i < strs.Length; i++)
    {
        IEnumerable<char> CommonChar;
        CommonChar=strs[i].Intersect(strs[i+1]);
        string Common = String.Join("", CommonChar);
    }
    return "1";

}
