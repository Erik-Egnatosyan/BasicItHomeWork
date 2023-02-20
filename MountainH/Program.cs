namespace MountainH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            test();
        }
        public static void test()
        {
            int[] mountainHS = new int[8];
            int max = 0;
            while (true)
            {
                for (int i = 0; i < 8; i++)
                {
                    max = 0;
                    int mountainH = int.Parse(Console.ReadLine());
                    mountainHS[i] = mountainH;
                    if (mountainHS[i] > max)
                    {
                        max = mountainHS[i];
                    }
                    Console.WriteLine(max);
                }
            }
        }
    }
}