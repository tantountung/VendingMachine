using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine.Model
{
    /*
      The common methods should include at least:
         ▪ Examine, to show the product’s price and info
         ▪ Use, to put the product to use once it has been purchased 
             (output a string message how to use the product)
       */
    public abstract class Product
    {
        public string Info { get; set; }
        public int Price { get; set; }
        public string Instruction { get; set; }
        public string Name { get; set; }

        public Product(string name, string info, int price )
        {
            this.Info = info;
            this.Price = price;
            this.Name = name;
        }

        public Product(string instruction)
        {
            this.Instruction = instruction;
        }

        public Product Use(string instruction)
        {
            Console.WriteLine("Warning: {0}", instruction);

        }

        public Product Examine(string name, string info, int price)
        {
            Console.WriteLine("{0}, This product contains: {1}, and price is {2}", name, info, price);
        }
    }
}
