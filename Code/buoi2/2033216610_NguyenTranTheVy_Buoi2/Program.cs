namespace _2033216610_NguyenTranTheVy_Buoi2
{
    using System;

    class Program
    {
        static int timKiemNhinPhan(int[] mang, int n, int key)
        {
            int left = 0; 
            int right = n - 1; 
            while (left <= right)
            {
                int mid = (left + right) / 2; 
                if (mang[mid] == key)
                {
                    return mid;
                }
                if (key < mang[mid])
                {
                    right = mid - 1;
                }
                else
                {
                    left = mid + 1;
                }
            }
            return -1;
        }

        static void Main(string[] args)
        {
            int[] mang = { 10, 20, 30, 40, 50 };
            int n = mang.Length; 
            int key = 40; 
            int result = timKiemNhinPhan(mang, n, key);
            if (result != -1)
            {
                Console.WriteLine("Phần tử được tìm thấy ở vị trí: " + result);
            }
            else
            {
                Console.WriteLine("Phần tử không có trong mảng");
            }
        }
    }
}