namespace work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = { "Ramazan", "Niyaz", "Rehman" };
            string[] arr2 = { "Niyaz", "Elnur", "Elmin" };
            Eyni(arr1, arr2);
        }

        public static void Eyni(string[] arr1, string[] arr2)
        {
            
            for (int i = 0; i < arr1.Length; i++)
            {
                for(int j = 0;i < arr2.Length; i++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write(arr1[i]);
                    }
                }
            }
        }
    }
}
