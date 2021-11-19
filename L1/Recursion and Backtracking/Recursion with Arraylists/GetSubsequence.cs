using System;
public class GetSubsequence
{
    public static List<string> GetSubseq(string str)
    {
        if (str.Length == 0)
        {
            List<string> blist = new List<string>();
            blist.Add("");
            return blist;

        }

        char current = str[0];  //x
        string remaining = str.Substring(1);  //yz
        List<string> rresult = GetSubseq(remaining); // result for yz
        List<string> final = new List<string>();

        foreach (var item in rresult)
        {
            final.Add(item);
        }

        foreach (var item in rresult)
        {
            final.Add(current + item);
        }
        return final;

    }
}
