namespace work2
{
    internal class Program
    {
        
            static void Main(string[] args)
            {
                int[] n = { 12, 2, 3 };
                Arr(n);
            }

            public static void Arr(int[] n)
            {
                int product = 1;
                for (int i = 0; i < n.Length; i++)
                {
                    product *= n[i];
                }
                Console.WriteLine(product);
            }
        
    }
}
