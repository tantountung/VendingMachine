using System;
using System.Collections.Generic;
using System.Text;
using VendingMachine.Model;

namespace VendingMachine
{
    public class Chocolate : Display
    {
        Chocolate chocolate = new Chocolate();
        public Chocolate(string message, int price, string info) : base(message, price, info)
        {
        //    message = "Plastic wrappen should not be eaten";
        //    price = 9;
        //    info = "Calorie = 200 kal";

        //    return;
        //}
        
    }
}
