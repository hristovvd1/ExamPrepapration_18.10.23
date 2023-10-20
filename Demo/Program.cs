namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bomb = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList(); //1 2 2 4 2 2 2 9

            int number = bomb[0]; // 9 bomb number
            int power = bomb[1]; // power 3

            while (list.Contains(number)) // 9
            {
                int index = list.IndexOf(number); // 5ti indeks

                int leftIndex = Math.Max(0, index - power); // 0, 2
                int RightIndex = Math.Min(list.Count - 1, index + power); // 6, 8

                int range = RightIndex - leftIndex + 1;

                list.RemoveRange(leftIndex, range);
            }

            Console.WriteLine(list.Sum());
        }
    }
}
