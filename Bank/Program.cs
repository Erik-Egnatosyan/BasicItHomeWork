namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KakoytoBank kakoytoBank = new KakoytoBank();
            Console.WriteLine(kakoytoBank.Choice(1,5000));
            kakoytoBank.Hashiv(124514);
        }
    }
}