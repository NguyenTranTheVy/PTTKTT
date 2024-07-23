namespace Sắp_xếp_QuickSort
{
    internal class Program
    {

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(ref array[i], ref array[j]);
                }
            }

            Swap(ref array[i + 1], ref array[high]);
            return i + 1;
        }

        static void QuickSort(int[] array, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(array, low, high);

                QuickSort(array, low, pi - 1);
                QuickSort(array, pi + 1, high);
            }  
        }
        

        static void Main()
        {
            int[] a = { 10, 7, 8, 9, 1, 5 };
            int n = a.Length;

            QuickSort(a, 0, n - 1);

            Console.WriteLine("Mảng sau khi sắp xếp QuickSort:");
            Console.WriteLine(string.Join(" ", a));



        }  


    }
    

}
