using System;
using System.Collections;
using System.Linq;

public class GetMazePaths
{

    public static void Main()
    {

    }
    public static List<string> GetMPaths(int sr, int sc, int dr, int dc)
    {

        if (sr == dr && sc == dc)
        {
            List<string> bpath = new List<string>();
            bpath.Add("");
            return bpath;
        }

        List<string> hpath = new List<string>();
        List<string> vpath = new List<string>();


        if (sr < dr)
        {
            hpath = GetMPaths(sr, sc + 1, dr, dc);
        }
        if (sc < dc)
        {
            vpath = GetMPaths(sr + 1, sc, dr, dc);
        }
        List<string> fres = new List<string>();
        fres.AddRange(hpath.Select(e => "h" + e));
        fres.AddRange(vpath.Select(e => "v" + e));

        return fres;

    }
}