using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public abstract class Display
    {
        public string Message
        { get; set; }


        public int Price
        { get; set; }

        public string Info
        { get; set; }

        //public Display(string message, int price, string info)
        //{
        //    Message = message;
        //    Price = price;
        //    Info = info;
        //}

        //public override string ToString()
        //{
        //    return $"";
        //}
    }
}
