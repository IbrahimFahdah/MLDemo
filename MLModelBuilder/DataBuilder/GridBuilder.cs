using System;
using System.Collections.Generic;

namespace MLBuild.DataBuilder
{
    public class GridBuilder
    {
        Random RND = new Random();

        public List<Square> Create(int r, int c, int size, double ratio)
        {
            var tmp = new List<Square>();
            for (var i = 0; i < r; i++)
            {
                for (var j = 0; j < c; j++)
                {
                    tmp.Add(new Square()
                    {
                        Id = i * r + j * c,
                        A = size * RND.NextDouble() * ratio,
                        Col = j,
                        Row = i,
                    });
                }
            }

            foreach (var x in tmp)
            {
                x.IsFull = RND.NextDouble() > ratio;
                x.A = Math.Round(x.IsFull ? x.A : 0, 3);
            }

            return tmp;
        }
    }
}