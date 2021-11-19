using System;
using System.Collections.Generic;
using System.Linq;

public class SortZeroOne{
	
public static void Main()
{
	List <string> op = GetKeyPadCount("78");

Console.Write(String.Join(", ",op));
}


private static List < string > GetKeyPadCount(string str) {

    if (str.Length == 0) {
        return new List < string > () {
            ""
        };
    }

    String[] kpc = new String[] {
        ".;",
        "abc",
        "def",
        "ghi",
        "jkl",
        "mno",
        "pqrs",
        "tu",
        "vwx",
        "yz"
    };

    char ch = str[0];
    string rStr = str.Substring(1);
    List <string> reSoFar = GetKeyPadCount(rStr);
    List <string> re = new List < string > ();

    string temp = kpc[ch - '0'];
    for (int i = 0; i < temp.Length; i++) {
        re.AddRange(reSoFar.Select(e => temp[i] + e));
    }
    return re;


}
}