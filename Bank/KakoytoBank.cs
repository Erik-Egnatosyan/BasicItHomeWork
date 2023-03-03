using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class KakoytoBank
    {
        const decimal dollar = 388.17M;
        const decimal euro = 412.51M;
        const decimal rub = 5.14M;
        public decimal Choice(int choice, decimal dram)
        {
            switch (choice)
            {
                case 1:
                    return dram / dollar;
                case 2:
                    return dram / euro;
                case 3:
                    return dram / rub;
                default:
                    Console.WriteLine("Not valid input");
                    break;
            }
            return 0;
        }
        public void Hashiv(int num)
        {
            while (num > 0)
            {
                int num1 = num % 10;
                Console.WriteLine(num1);
                num /= 10;
            }
        }
    }
}
