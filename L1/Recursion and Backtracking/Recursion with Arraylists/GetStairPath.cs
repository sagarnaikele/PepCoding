using System;
using System.Collections;
//https://nados.pepcoding.com/content/ae41ae29-11ca-4ae4-8ec7-72a411fd59b6/d341a7c9-1269-409c-b851-0bb512289544/b0de95ee-d178-450a-b3a0-325eeaccfa58/question/17c0ada5-3276-4f47-88ea-8fd7e208b73d
public class GetStairPath
{
    public static List<string> GetPath(int stair)
    {
        if (stair == 0)
        {
            List<string> bpath = new List<string>();
            bpath.Add("");
            return bpath();
        }
        else
        {
            return new List<string>();

        }

        List<string> path1 = GetPath(stair - 1); //5 4 3 2 1
        List<string> path2 = GetPath(stair - 2);//5 3 1
        List<string> path3 = GetPath(stair - 3);


        List<string> final = new List<string>();
        final.AddRange(path1.Select(e => "1" + e));
        final.AddRange(path2.Select(e => "2" + e));
        final.AddRange(path3.Select(e => "3" + e));



    }
}
