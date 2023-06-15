namespace DND_Review1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 8, 5, 1, 7, 6, 4, 3 };
            for (int index = array.Length-1 ; index >= 0; index--)
            {
                if (array[index]%2 != 0)
                {
                    Console.WriteLine(array[index]);
                    break;
                }
            }
        }
    }
}