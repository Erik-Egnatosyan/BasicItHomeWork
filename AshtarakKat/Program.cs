namespace AshtarakKat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Milk milk = new Milk();
            Console.WriteLine("Choose what do you wont!\n#1Smetan\n#2Matsun\n#3Tvarog");
            int choose = Convert.ToInt32(Console.ReadLine());
            switch (choose)
            {
                case 1:
                    {
                        choose = milk.f1();
                        break;
                    }
                case 2:
                    {
                        choose = milk.f2();
                        break;
                    }
                case 3:
                    {
                        choose = milk.f3();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Try again");
                        break;
                    }
            }
            Console.WriteLine("How many do you wont?");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your bill is {count * choose}");
        }
    }
}