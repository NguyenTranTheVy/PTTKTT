namespace Tính_tổng_của_các_phần_tử_trong_mảng_a_có_n_số_nguyên
{
    internal class Program
    {
        static void Main(string[] args)
        {
   
                int[] a = { 1, 2, 3, 4, 5 };
                int n = a.Length;
                int sum = 0;

                for (int i = 0; i < n; i++)
                {
                    sum += a[i];
                }

                Console.WriteLine("Tổng các phần tử trong mảng: " + sum);
            
        }

    }
}
