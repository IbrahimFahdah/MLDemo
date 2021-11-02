using System;
using System.Collections.Generic;
using System.Linq;

namespace MLBuild.DataBuilder
{
    public class Helper
    {
        public static double CalcXc(List<Square> seqList, int squareSize)
        {
            var A = seqList.Where(x => x.IsFull).Sum(x => x.A);
            var sum = 0.0;
            foreach (var x in seqList.Where(x => x.IsFull))
            {
                sum += x.A * (x.Col * squareSize + squareSize / 2.0);
            }

            if (A == 0)
                return 0;
            return Math.Round(sum / A, 3);
        }
    }
}