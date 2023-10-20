namespace _4.MixedUpLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> list2 = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            int listCount = 0;
            int listCount2 = 0;

            if (list2.Count < list1.Count)
            {
                listCount = list2.Count + list1.Count - 2;
            }

            else if (list1.Count < list2.Count)
            {
                listCount2 = list1.Count + list2.Count - 2;
            }

            List<int> listEmpty = new List<int>();
            List<int> listFinal = new List<int>();

            if (list1.Count < list2.Count)
            {
                for (int i = 0; i < listCount2; i += 2)
                {
                    listEmpty.Add(list1[0]);
                    list1.RemoveAt(0);
                    listEmpty.Add(list2[list2.Count - 1]);
                    list2.RemoveAt(list2.Count - 1);
                }

                if (list2[0] > list2[1])
                {
                    foreach (int element in listEmpty)
                    {
                        if (element > list2[1] && element < list2[0])
                        {
                            listFinal.Add(element);
                        }
                    }
                }

                else if (list2[1] > list2[0])
                {
                    foreach (int element in listEmpty)
                    {
                        if (element > list2[0] && element < list2[1])
                        {
                            listFinal.Add(element);
                        }
                    }
                }

                listFinal.Sort();
            }

            else if (list2.Count < list1.Count)
            {
                for (int i = 0; i < listCount; i += 2)
                {
                    listEmpty.Add(list1[0]);
                    list1.RemoveAt(0);
                    listEmpty.Add(list2[list2.Count - 1]);
                    list2.RemoveAt(list2.Count - 1);
                }

                if (list1[0] > list1[1])
                {
                    foreach (int element in listEmpty)
                    {
                        if (element > list1[1] && element < list1[0])
                        {
                            listFinal.Add(element);
                        }
                    }
                }

                else if (list1[1] > list1[0])
                {
                    foreach (int element in listEmpty)
                    {
                        if (element > list1[0] && element < list1[1])
                        {
                            listFinal.Add(element);
                        }
                    }
                }

                listFinal.Sort();
            }

            Console.WriteLine(string.Join(" ", listFinal));
        }
    }
}
/*
1 5 23 64 2 3 34 54 12
43 23 12 31 54 51 92

 */