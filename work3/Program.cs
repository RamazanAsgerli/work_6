namespace work3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr = { "Aslan", "Anar", "Vaqif" };
            BasHerf(arr);
        }

        public static void BasHerf(string[] arr)
        {
            char herf = 'A';
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i][0] == herf)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
    }
}
