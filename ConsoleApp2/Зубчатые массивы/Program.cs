namespace Зубчатые_массивы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[5][];
            arr[0]=new int[2];
            arr[1]=new int[3];
            arr[2]=new int[4];
            arr[3]=new int[5];
            arr[4]=new int[6];

            Random random = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = random.Next(100);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}