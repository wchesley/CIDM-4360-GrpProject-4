using System;
using System.Collections.Generic;

namespace HW4
{
    class InvoiceEntry
    {
        List<Item> ItemObjects = new List<Item>();
        public InvoiceEntry(List<Item> item, int ReqQantity)
        {

        }

        public InvoiceEntry(Item item, int reqQuantity)
        {
            this.item = item;
            this.reqQuantity = reqQuantity;
        }

        int LineNo; //a sequence number shows the line of the item in the invoice,
        int Qnty; // an int number shows the number of itemunits sold in that line
        private Item item;
        private int reqQuantity;

        public int getLineNumber()
        {
            return LineNo;
        }

        

        public int getQnty()
        {
            return Qnty;
        }
    }
}