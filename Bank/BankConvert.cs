using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankConvert
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
            int[] num2 = new int[num];
            for (int i = 0; num > 0; i++)
            {
                int digit = num % 10;
                num /= 10;
                num2[i] = digit;
            }
            Console.WriteLine($"Du unes {num2[0]} hazar, {num2[1]} haryur, {num2[2]}0, {num2[3]} ");
        }
    }
}
