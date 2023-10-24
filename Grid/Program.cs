namespace Grid
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
            Console.BufferWidth = 1024;
            Grid<char> grid = new(File.ReadAllLines(Directory.GetCurrentDirectory() + "\\input.txt"));
            Console.WriteLine(grid.GetShortestPath('S', 'E', Barrier));
        }

        public static bool Barrier(char charOne, char charTwo)
        {
            if(charOne == 'S')
            {
                return false;
            }

            if(charTwo == 'E')
            {
                return charOne != 'z';
            }

            return charOne - charTwo < -1;
        }
    }
}