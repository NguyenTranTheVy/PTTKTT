namespace Sắp_xếp_MergeSort
{
    internal class Program
    {
        static void Merge(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;
            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[left + i];
            for (int i = 0; i < n2; i++)
                rightArray[i] = array[mid + 1 + i];

            int k = left;
            int j = 0, m = 0;

            while (j < n1 && m < n2)
            {
                if (leftArray[j] <= rightArray[m])
                {
                    array[k] = leftArray[j];
                    j++;
                }
                else
                {
                    array[k] = rightArray[m];
                    m++;
                }
                k++;
            }

            while (j < n1)
            {
                array[k] = leftArray[j];
                j++;
                k++;
            }

            while (m < n2)
            {
                array[k] = rightArray[m];
                m++;
                k++;
            }
        }
        static void MergeSort(int[] array, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;

                MergeSort(array, left, mid);
                MergeSort(array, mid + 1, right);

                Merge(array, left, mid, right);
            }
        }

        static void Main()
        {
            int[] a = { 12, 11, 13, 5, 6, 7 };
            int n = a.Length;

            MergeSort(a, 0, n - 1);

            Console.WriteLine("Mảng sau khi sắp xếp MergeSort:");
            Console.WriteLine(string.Join(" ", a));
        }
    }

}
