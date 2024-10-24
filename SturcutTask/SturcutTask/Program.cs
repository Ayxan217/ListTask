using System.Runtime.InteropServices;

namespace SturcutTask
{
    internal class Program
    {
        static void Main(string[] args)
        {

            CustomList<int> list = new CustomList<int>(8, 1, 2, 3, 4, 5, 6, 12, 34, 7);
            
            list.Add(145);
            list.Containts(5);
            list.AddRange(42, 19);
            list.RemoveRange(8, 5, 34);
            list.Remove(1);
         

            list.Sum();
            Console.WriteLine(list.ToString());




        }
    }
}
