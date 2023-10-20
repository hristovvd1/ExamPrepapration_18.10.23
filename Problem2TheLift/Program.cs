namespace Problem2TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());

            List<int> lift = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            for (int i = 0; i < lift.Count; i++)
            {
                int currentWagon = lift[i];

                if (currentWagon < 4)
                {
                    int emptySeats = 4 - lift[i];
                    people -= emptySeats;
                    lift[i] = 4;

                    if (people < 0)
                    {
                        lift[i] = 4 - Math.Abs(people);
                        Console.WriteLine($"The lift has empty spots!\n{String.Join(' ', lift)}");
                        return;
                    }
                }
            }

            if (people > 0)
            {
                for (int i = 0; i < lift.Count; i++)
                {
                    if (lift[i] == 4)
                    {
                        Console.WriteLine($"There isn't enough space! {people} people in a queue!\n{String.Join(' ', lift)}");
                        return;
                    }
                }
            }

            else if (people == 0)
            {
                for (int i = 0; i < lift.Count; i++)
                {
                    if (lift[i] == 4)
                    {
                        Console.WriteLine(String.Join(' ', lift));
                        return;
                    }
                }
            }
        }
    }
}
