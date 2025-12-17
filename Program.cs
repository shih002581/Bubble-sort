namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 5, 4, 2};
            BubbleSort(arr);
            Console.WriteLine(string.Join(", ", arr));
        }
        static void BubbleSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                for (int j = 0; j < data.Length - 1 - i; j++) 
                {
                    if (data[j] > data[j + 1])
                    {
                        int temp = data[j];
                        data[j] = data[j + 1];
                        data[j+1] = temp;
                    }

                }
            }
        }
    }
}
