namespace CalculatorWithSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator(14, '4', 3);
        }
        public static void Calculator(double FirstNum, char Symbol, double SecondNum)
        {
            switch (Symbol)
            {
                case '-':
                {
                    Console.WriteLine($"{FirstNum} - {SecondNum} = {FirstNum - SecondNum}");
                    break;
                }
                case '+':
                {
                    Console.WriteLine($"{FirstNum} + {SecondNum} = {FirstNum + SecondNum}");
                    break;
                }
                case '*':
                {
                    Console.WriteLine($"{FirstNum} * {SecondNum} = {FirstNum * SecondNum}");
                    break;
                }
                case '/':
                {
                    Console.WriteLine($"{FirstNum} / {SecondNum} = {FirstNum / SecondNum}");
                    break;
                }
                default:
                {
                    Console.WriteLine("Invalid Input");
                    break;
                }
            }
        }
    }
}