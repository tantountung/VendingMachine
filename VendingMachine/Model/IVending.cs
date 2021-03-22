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
        public int MoneyPool()
        {
            int[] money = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000};

            Console.WriteLine("Please enter coins.\nOnly coin of 1, 5, 10, 20, 50, 100, 500, 1000 kr are accepted");

            int inputMoney = Convert.ToInt32(Console.ReadLine());

            if (inputMoney = money )
            {
                Console.WriteLine("Your money deposit now is: {0}", inputMoney);

            }

            else
            {
                Console.WriteLine("Invalid coins\nPlease enter valid coin/s");
                Money1();
            }

            return;


        }


    }
}
