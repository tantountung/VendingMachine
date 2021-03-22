using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    /*These classes should all inherit form the same abstract class, to get 
      * the methods they have in common. This base class is the type 
      * the vending machine itself should look for.
      * 
      * 
      */
    public class Chips : Product, IVending
    {
        string info = "500 calories";
        int price = 25;
        string instruction = "Spicy products";
        string name = "Chips";

        public Chips(string name, string info, int price) : base(name, info, price)
        { }

        public Chips(string instruction) : base(instruction)
        { }

        public override Product Use(string instruction)
        {
            return base.Use(instruction);
        }

        public override Product Examine(string name, string info, int price)
        {
            return base.Examine("1.", name, info, price);
        }

    }
}
