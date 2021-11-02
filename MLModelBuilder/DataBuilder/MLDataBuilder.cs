using System;
using System.IO;
using System.Linq;

namespace MLBuild.DataBuilder
{
    public class MLDataBuilder
    {
        public void CreateData(string fileName)
        {
            var RND = new Random();
            var builder = new GridBuilder();
            var gridRows = 10;
            var gridCols = 10;
            var squareSize = 1;

            for (var i = 0; i < 100000; i++)
            {
                var grid = builder.Create(gridRows, gridCols, squareSize, RND.NextDouble());
                var cx = Helper.CalcXc(grid, squareSize);
                if (cx == 0)
                    continue;

                var str = string.Join(",", grid.Select(x => x.IsFull ? x.A : 0)) + $",{cx}";
                File.AppendAllLines(fileName, new[] { str });
            }
        }
    }
}