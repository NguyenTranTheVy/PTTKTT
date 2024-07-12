namespace Tìm_kiếm_nhị_phân
{
    internal class Program
    {
        static int BinarySearch(int[] array, int left, int right, int key)
        {
            if (right >= left)
            {
                int mid = left + (right - left) / 2;

                if (array[mid] == key)
                    return mid;

                if (array[mid] > key)
                    return BinarySearch(array, left, mid - 1, key);

                return BinarySearch(array, mid + 1, right, key);
            }

            return -1;
        }
        static void Main()
        {
            int[] a = { 2, 3, 4, 10, 40 };
            int n = a.Length;
            int key = 10;
            int result = BinarySearch(a, 0, n - 1, key);

            if (result != -1)
                Console.WriteLine("Phần tử " + key + " được tìm thấy tại chỉ số " + result);
            else
                Console.WriteLine("Phần tử " + key + " không có trong mảng");
        }
    }

}
