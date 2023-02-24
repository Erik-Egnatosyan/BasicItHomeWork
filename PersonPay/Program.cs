namespace PersonPay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            workBenefits(10000, out a);
            valantureCheck(10000, a, b, out c);
        }
        public static void workBenefits(int salary, out int a)
        {
            Console.WriteLine("Do you work for a company that benefits from IT tax benefits? Yes / No");
            while (true)
            {
                string doWork = Console.ReadLine();
                if (doWork == "Yes")
                {
                    a = (salary / 100) * 10;
                    break;
                }
                else if (doWork == "No")
                {
                    a = (salary / 100) * 10;
                    break;
                }
                else
                    Console.WriteLine("Wrong Input. Try again...");
            }
        }
        public static void valantureCheck(int salary, int a, int b, out int c)
        {
            Console.WriteLine("Pls choose the option with input the option number:\n#1 -> YES Voluntary Joined after 07/2018\n#2 -> YES, mandatory or voluntary joined before 07/2018\n#3 -> NO, I'm not a participant");
            int valant = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (valant == 1 || valant == 2)
                {
                    b = (salary / 100) * 5;
                    break;
                }
                else if (valant == 3)
                {
                    b = 0;
                    break;
                }
                else
                    Console.WriteLine("Wrong Input. Try again..");
            }
            c = (salary / 100) * 15;
            Console.WriteLine($"Your clear salary is {salary - a - b - c} and your all salary is {salary + a + b + c}");
        }
    }
}