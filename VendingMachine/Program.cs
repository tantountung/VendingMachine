using System;
using VendingMachine.Model;


namespace VendingMachine
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome!");


            while (true)
            {
                Console.WriteLine("Please enter your choice:");
                Console.WriteLine("1. Display products");
                Console.WriteLine("2. Purchase");
                Console.WriteLine("3. Finish");
                int input = Convert.ToInt32(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        VendingMachine(DisplayAll());
                        break;
                    case 2:
                        VendingMachine(MoneyPool());
                        VendingMachine(DisplayAll());
                        Purchase;
                        //in here, there will be refund money or loop to start again
                        break;
                    case 3:
                        Console.WriteLine("Thank you and have a good day!");
                        Main();
                        break;
                    default:
                        return;
                }

            }
        }
        //public DisplayAll()//showing products, prices, and info
        //{
        //    //Console.WriteLine("1. Chips\n9 sek\n200 calories");
        //    //Console.WriteLine("2. Cola\n12 sek\n100 calories");
        //    //Console.WriteLine("3. Candy\n3 sek\n50 calories");

        //}

        //public static void Money1()
        //{
        //    Console.WriteLine("Please enter coins.\nOnly coin of 1, 5, 10, 20, 50, 100, 500, 1000 kr are accepted");

        //    int inputMoney = Convert.ToInt32(Console.ReadLine());

        //    if (inputMoney == 1 || inputMoney == 5 || inputMoney == 10 || inputMoney == 20 || inputMoney == 50 || inputMoney == 100 || inputMoney == 500 || inputMoney == 1000)
        //    {
        //        Console.WriteLine("Your money deposit now is: {0}", inputMoney);

        //    }

        //    else
        //    {
        //        Console.WriteLine("Invalid coins\nPlease enter valid coin/s");
        //        Money1();
        //    }

        //    return;

        //}
        public static void Display2()
        {
            Console.WriteLine("1. Chocolate\n9 sek\n200 calories");
            Console.WriteLine("2. Cola\n12 sek\n100 calories");
            Console.WriteLine("3. Candy\n3 sek\n50 calories");

            Console.WriteLine("Which number do you want to buy?");
            int selectProduct = Convert.ToInt32(Console.ReadLine());

            if (selectProduct == 1)
            {

            }

        }
    }
}

