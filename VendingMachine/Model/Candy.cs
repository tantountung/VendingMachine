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
    public class Candy : Product, IVending
    {
        string info = "200 calories";
        int price = 9;
        string instruction = "Plastic wrapper not to be eaten";
        string name = "Candy";

        public Candy(string name, string info, int price) : base(name, info, price)
        { }

        public Candy(string instruction) : base(instruction)
        { }

        public override Product Use(string instruction)
        {
            return base.Use(instruction);
        }

        public override Product Examine(string name, string info, int price)
        {
            return base.Examine("2.", name, info, price);
        }

    }
}
