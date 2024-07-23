namespace nhanhaisolon
{
    internal class Program
    {
        public static long Big_Number_Multi(long X, long Y, int n)
        {
            long m1, m2, m3, A, B, C, D;
            long s; 

            
            s = Sign(X) * Sign(Y);

           
            X = Math.Abs(X);
            Y = Math.Abs(Y);

          
            if (n == 1)
                return X * Y * s;
            else
            {
               
                A = Left(X, n / 2);  
                B = Right(X, n / 2); 
                C = Left(Y, n / 2);  
                D = Right(Y, n / 2); 

                
                m1 = Big_Number_Multi(A, C, n / 2);       
                m2 = Big_Number_Multi(A - B, D - C, n / 2); 
                m3 = Big_Number_Multi(B, D, n / 2);        

              
                return s * (m1 * (long)Math.Pow(10, n) + (m1 + m2 + m3) * (long)Math.Pow(10, n / 2) + m3);
            }
        }

       
        private static long Sign(long num)
        {
            if (num > 0) return 1;
            if (num < 0) return -1;
            return 0;
        }

      
        private static long Left(long num, int digits)
        {
            return num / (long)Math.Pow(10, digits);
        }

        
        private static long Right(long num, int digits)
        {
            return num % (long)Math.Pow(10, digits);
        }
        static void Main(string[] args)
        {
            long X = 12345678;
        long Y = 87654321;
        int n = 8; 

        long ketQua = Big_Number_Multi(X, Y, n);
        Console.WriteLine($"Kết quả của {X} nhân với {Y} là: {ketQua}");
        }
    }
}