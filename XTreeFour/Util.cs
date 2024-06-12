
namespace XTreeFour
{
    public class Util
    {
        private static Random rnd = new Random();

        public static void Print(List<int> list)
        {
            foreach (var value in list)
            {
                Console.Write(value);
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        public static bool IsSorted(List<int> list)
        {
            for (int i = 1; i < list.Count; i++) 
            {
                if (list[i - 1] > list[i])
                {
                    return false;
                }
            }
            return true;
        }

        public static List<int>  RandomList(int n) 
        {
            List<int> list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                list.Add(rnd.Next());
            }
            return list;
        }
    }
}
