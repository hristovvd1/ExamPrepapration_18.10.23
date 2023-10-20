using System.Collections.Generic;
using System;

namespace _05.BombNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArrayString = command.Split();
                int commandArrayFirst = (int.Parse(commandArrayString[1]));
                int commandArraySecond = (int.Parse(commandArrayString[2]));

                if (commandArrayString[0] == "Shoot")
                {
                    if (IsValidIndex(commandArrayFirst, targets))
                    {
                        targets[commandArrayFirst] -= commandArraySecond;

                        if (targets[commandArrayFirst] <= 0)
                        {
                            targets.RemoveAt(commandArrayFirst);
                        }
                    }
                }

                else if (commandArrayString[0] == "Add")
                {
                    if (IsValidIndex(commandArrayFirst, targets))
                    {
                        targets.Insert(commandArrayFirst, commandArraySecond);
                    }

                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                }

                else if (commandArrayString[0] == "Strike")
                {
                    if (IsValidIndex(commandArrayFirst, targets) && IsValidIndex(commandArrayFirst + commandArraySecond, targets) && IsValidIndex(commandArrayFirst - commandArraySecond, targets))
                    {
                        for (int i = 1; i <= commandArraySecond; i++)
                        {
                            targets.RemoveAt(commandArrayFirst + i);
                        }

                        targets.RemoveAt(commandArrayFirst);

                        for (int i = 1; i <= commandArraySecond; i++)
                        {
                            targets.RemoveAt(commandArrayFirst - i);
                        }
                    }

                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }

            Console.WriteLine(string.Join("|", targets));
        }

        static bool IsValidIndex(int commandArrayFirst, List<int> targets)
        {
            return commandArrayFirst >= 0 && commandArrayFirst <= targets.Count;
        }
    }
}
/*
52 74 23 44 96 110
Shoot 5 10
Shoot 1 80
Strike 2 1
Add 22 3
End

1 2 3 4 5
Strike 0 1
End
*/
