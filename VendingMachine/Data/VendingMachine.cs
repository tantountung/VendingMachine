using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine.Data
{
    public class VendingMachine: IVending
    {
        IVending DisplayAll();
        { return; }


    public MoneyPool()
    {
        int[] money = new int[] { 1, 5, 10, 20, 50, 100, 500, 1000 };
        Console.WriteLine("Do you want to add money?\nPlease press 1 for adding money or 2 to start purchasing or no 3 for exit");
        int userInputMoney = Convert.ToInt32(Console.ReadLine());

        while (userInputMoney = 1)
        {
            AddingMoney();
            int accumulation = AddingMoney(inputMoney)+accumulation;

            Console.WriteLine("Your money pool is: {0}", accumulation);
            MoneyPool();
        }

        if (userInputMoney = 2)
        {
            Purchase();
            MoneyLeft();
            MoneyPool();
        }
        if (userInputMoney = 3)
        {
            
            Exit();
        }
        else
        {
            Console.WriteLine("Invalid input"    );
            MoneyPool();        
        }
    }
    
}

