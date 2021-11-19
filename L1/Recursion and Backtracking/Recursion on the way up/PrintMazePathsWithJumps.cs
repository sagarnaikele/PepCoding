using System;

class PrintMazePathsWithJumps
{
    public static void Main()
    {

        Print(0, 0, 3, 4, "");

    }


    // sr - source row
    // sc - source column
    // dr - destination row
    // dc - destination column
    public void Print(int sr, int sc, int dr, int dc, ref string path)
    {

        if (sr == dr && sc == dc)
        {
            Console.WriteLine(path);
            return;
        }
        else if (sr > dr || sc > dc)
        {
            return;
        }


        //horizontal
        for (int jump = 1; jump <= dc - sc; jump++)
        {
            Print(sr + jump, sc, dr, dc, path + "h" + jump);
        }


        //vertical
        for (int jump = 1; jump <= dr - sr; jump++)
        {
            Print(sr, sc + jump, dr, dc, path + "v" + jump);
        }


        //diagonal
        for (int jump = 1; jump <= Math.Min(dr, dc); jump++)
        {
            Print(sr + jump, sc + jump, dr, dc, path + "d" + jump);
        }

    }


}

