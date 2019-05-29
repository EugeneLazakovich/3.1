using System;

namespace _3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int money = 380;
            if (money < 0)
            {
                Console.WriteLine("Wrong!");
            }
            else
            {
                switch (money / 100)
                {
                    case 0:
                    case 1:
                    case 2:
                        Console.WriteLine("Your discount 0%");
                        Console.WriteLine("Total to pay: " + money);
                        break;
                    case 3:
                        Console.WriteLine("Your discount 3%");
                        Console.WriteLine("Total to pay: " + (money * 0.97));
                        break;
                    case 4:
                        Console.WriteLine("Your discount 5%");
                        Console.WriteLine("Total to pay: " + (money * 0.95));
                        break;
                    default:
                        Console.WriteLine("Your discount 7%");
                        Console.WriteLine("Total to pay: " + (money * 0.93));
                        break;
                }
            }
        }
    }
}
