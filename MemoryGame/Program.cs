namespace MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine()
                .Split()
                .ToList();

            int moves = 0;
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArray = command.Split();
                int commandArrayIndex1 = (int.Parse(commandArray[0]));
                int commandArrayIndex2 = (int.Parse(commandArray[1]));

                moves++;

                if (commandArrayIndex1 == commandArrayIndex2 || commandArrayIndex1 < 0 || commandArrayIndex1 >= elements.Count || commandArrayIndex2 < 0 || commandArrayIndex2 >= elements.Count)
                {
                    int middleIndex = elements.Count / 2;

                    string newSymbol = $"-{moves}a";

                    elements.Insert(middleIndex, newSymbol);
                    elements.Insert(middleIndex, newSymbol);

                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }

                else if (elements[commandArrayIndex1] == elements[commandArrayIndex2])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {elements[commandArrayIndex1]}!");

                    if (commandArrayIndex1 < commandArrayIndex2)
                    {
                        elements.RemoveAt(commandArrayIndex2);
                        elements.RemoveAt(commandArrayIndex1);
                    }

                    else if (commandArrayIndex2 < commandArrayIndex1)
                    {
                        elements.RemoveAt(commandArrayIndex1);
                        elements.RemoveAt(commandArrayIndex2);
                    }

                    if (elements.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                }

                else if (elements[commandArrayIndex1] != elements[commandArrayIndex2])
                {
                    Console.WriteLine("Try again!");
                }
            }

            if (elements.Count > 0)
            {
                Console.WriteLine($"Sorry you lose :(");
                Console.WriteLine(string.Join(" ", elements));
            }
        }
    }
}
/*
a 2 4 a 2 4
0 3
0 2
0 1
0 1
end

a 2 4 a 2 4
4 0
0 2
0 1
0 1
end

1 1 2 2 3 3 4 4 5 5
1 0
-1 0
1 0
1 0
1 0
end
*/