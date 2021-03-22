using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{/*These classes should all inherit form the same abstract class, to get 
     * the methods they have in common. This base class is the type 
     * the vending machine itself should look for.
     * 
     * 
     */
    public class Cola : Product, IVending
    {
        string info = "100 calories";
        int price = 12;
        string instruction = "Don't shake";
        string name = "Cola";
        public Cola(string name, string info, int price) : base(name, info, price)
        { }

        public Cola(string instruction) : base(instruction)
        { }

        public override Product Use(string instruction)
        {
            return base.Use(instruction);
        }

        public override Product Examine(string name, string info, int price)
        {
            return base.Examine("3."name, info, price);
        }

    }
}
