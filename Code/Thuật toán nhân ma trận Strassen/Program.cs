namespace Thuật_toán_nhân_ma_trận_Strassen
{
    internal class Program

    {
        static int[,] Add(int[,] A, int[,] B, int size)
        {
            int[,] result = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = A[i, j] + B[i, j];
                }
            }
            return result;
        }

        static int[,] Subtract(int[,] A, int[,] B, int size)
        {
            int[,] result = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    int v1 = A[i, j] - B[i, j];
                    int v = v1;
                    result[i, j] = v;
                }
            }
            return result;
        }

        static int[,] Strassen(int[,] A, int[,] B, int size)
        {
            if (size == 1)
            {
                return new int[,] { { A[0, 0] * B[0, 0] } };
            }

            int newSize = size / 2;
            int[,] a11 = new int[newSize, newSize];
            int[,] a12 = new int[newSize, newSize];
            int[,] a21 = new int[newSize, newSize];
            int[,] a22 = new int[newSize, newSize];
            int[,] b11 = new int[newSize, newSize];
            int[,] b12 = new int[newSize, newSize];
            int[,] b21 = new int[newSize, newSize];
            int[,] b22 = new int[newSize, newSize];

            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    a11[i, j] = A[i, j];
                    a12[i, j] = A[i, j + newSize];
                    a21[i, j] = A[i + newSize, j];
                    a22[i, j] = A[i + newSize, j + newSize];
                    b11[i, j] = B[i, j];
                    b12[i, j] = B[i, j + newSize];
                    b21[i, j] = B[i + newSize, j];
                    b22[i, j] = B[i + newSize, j + newSize];
                }
            }

            int[,] p1 = Strassen(a11, Subtract(b12, b22, newSize), newSize);
            int[,] p2 = Strassen(Add(a11, a12, newSize), b22, newSize);
            int[,] p3 = Strassen(Add(a21, a22, newSize), b11, newSize);
            int[,] p4 = Strassen(a22, Subtract(b21, b11, newSize), newSize);
            int[,] p5 = Strassen(Add(a11, a22, newSize), Add(b11, b22, newSize), newSize);
            int[,] p6 = Strassen(Subtract(a12, a22, newSize), Add(b21, b22, newSize), newSize);
            int[,] p7 = Strassen(Subtract(a11, a21, newSize), Add(b11, b12, newSize), newSize);

            int[,] c11 = Add(Subtract(Add(p5, p4, newSize), p2, newSize), p6, newSize);
            int[,] c12 = Add(p1, p2, newSize);
            int[,] c21 = Add(p3, p4, newSize);
            int[,] c22 = Subtract(Subtract(Add(p5, p1, newSize), p3, newSize), p7, newSize);

            int[,] result = new int[size, size];

            for (int i = 0; i < newSize; i++)
            {
                for (int j = 0; j < newSize; j++)
                {
                    result[i, j] = c11[i, j];
                    result[i, j + newSize] = c12[i, j];
                    result[i + newSize, j] = c21[i, j];
                    result[i + newSize, j + newSize] = c22[i, j];
                }
            }

            return result;
        }

        static void Main()
        {
            int[,] A = {
            {1, 2},
            {3, 4}
        };
            int[,] B = {
            {5, 6},
            {7, 8}
        };

            int size = 2;

            int[,] result = Strassen(A, B, size);

            Console.WriteLine("Kết quả của phép nhân ma trận:");
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(result[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        void PrintMatrix(int[,] matrix)
        {
            int size = matrix.GetLength(0);
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

    }


}
