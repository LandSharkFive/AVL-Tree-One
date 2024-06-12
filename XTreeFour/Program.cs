namespace XTreeFour
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Util.RandomList(100);

            var a = new Tree();
            a.AddRange(list);
            Display(a);

            var RemoveList = new List<int>();
            int n = list.Count - (list.Count / 5);
            for (int i = 0; i < n; i++) 
            { 
                RemoveList.Add(list[i]);
            }

            a.RemoveRange(RemoveList);
            Display(a);
            a.Clear();
        }

        private static void Display(Tree a)
        {
            Console.WriteLine("Height " + a.Height());
            Console.WriteLine("Balance " + a.GetOverload());
            Console.WriteLine("Sorted " + Util.IsSorted(a.ToList()));
            Util.Print(a.ToList());
            Console.WriteLine();
        }
    }
}
