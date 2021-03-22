using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Data;

namespace VendingMachine.Model
{
    interface IVending
    {
        //method for show all
        //public Product GetCola 
        //{
        //    get
        //    {
        //        return GetCola;
        //    }
        //    set
        //    {
        //        GetCola = Cola(Examine());
        //    }
        //}

        //public string GetCola;
        //public string GetCandy;
        //public string GetChips;

        public Product DisplayAll()
        {
            Chips(Examine());
            Candy(Examine());
            Cola(Examine());
        }
        public int AddingMoney()
        {
            Console.WriteLine("Please enter coins.\nOnly coin of 1, 5, 10, 20, 50, 100, 500, 1000 kr are accepted");

            int inputMoney = Convert.ToInt32(Console.ReadLine());

            if (inputMoney == 1 || inputMoney == 5 || inputMoney == 10 || inputMoney == 20 || inputMoney == 50 || inputMoney == 100 || inputMoney == 500 || inputMoney == 1000)
            {
                Console.WriteLine("You deposit: {0}", inputMoney);
                return inputMoney;
            }

            else
            {
                Console.WriteLine("Invalid coins\nPlease enter valid coin/s");
                return AddingMoney();
            }




        }

        public static Purchase()
        {
            Console.WriteLine("Please enter your choice of product:");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    {
                        if (accumulation > Chips.price)
                        {
                            //machine vent out the related product
                            Chips(Use());
                            return MoneyLeftChips();
                        }
                        else
                        {
                            Console.WriteLine("Money is not enough, please top up");
                            return MoneyPool();
                        }
                    }
                    break;

                case 2:
                    {
                        if (accumulation > Candy.price)
                        {
                            //machine vent out the related product
                            Candy(Use());
                            return MoneyLeftCandy();
                        }
                        else
                        {
                            Console.WriteLine("Money is not enough, please top up");
                            return MoneyPool();
                        }
                    }
                    break;

                case 3:
                    {
                        if (accumulation > Cola.price)
                        {
                            //machine vent out the related product
                            Cola(Use());
                            return MoneyLeftCola();
                        }
                        else
                        {
                            Console.WriteLine("Money is not enough, please top up");
                            return MoneyPool();
                        }

                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    Purchase();
                    break;


            }
        }
        public MoneyLeftChips()
        {
            Console.WriteLine("Remaining money:" + (accumulation - Chips.price));
            accumulation = accumulation - Chips.price;
        }
        public MoneyLeftCandy()
        {
            Console.WriteLine("Remaining money:" + (accumulation - Candy.price));
            accumulation = accumulation - Candy.price;
        }
        public MoneyLeftCola()
        {
            Console.WriteLine("Remaining money:" + (accumulation - Cola.price));
            accumulation = accumulation - Cola.price;
        }

        public Exit()
        {

        }
    }

}
