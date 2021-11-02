namespace MLBuild.DataBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            new MLDataBuilder().CreateData(@"data.txt");
        }
    }
}
