namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            Console.WriteLine(human.IsValid("ErikEgnato6syan"));
            Console.WriteLine(human.IsValid("Erik", "Egnatosyan"));
        }
    }
}