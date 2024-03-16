namespace work4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FibonacciArr(15);
        }
        public static void FibonacciArr(int n)
        {
            int[] Fibonacci = new int[n];
            Fibonacci[0] = 0;
            Fibonacci[1] = 1;
            for (int i = 2; i < Fibonacci.Length; i++)
            {
                Fibonacci[i] = Fibonacci[i - 1] + Fibonacci[i - 2];
                Console.Write(Fibonacci[i] + " ");
            }

        }
    }
}
