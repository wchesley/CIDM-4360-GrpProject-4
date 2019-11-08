using System;
using System.Collections.Generic;

namespace HW4
{
    class InvoiceEntry
    {
       
        int LineNo; //a sequence number shows the line of the item in the invoice,
        int Qnty; // an int number shows the number of itemunits sold in that line
        
        Item AddedItem;

        private int reqQuantity;

        public InvoiceEntry(int Lnumber, int Quantity, Item additem  )
        {
            LineNo = Lnumber;
            Qnty = Quantity;
            AddedItem = additem;
        }



        public int getLineNumber()
        {
            return LineNo;
        }

        public void setLineNumber(int LineNumber){
             LineNo = LineNumber;
        }

        public int getQnty()
        {
            return Qnty;
        }

        public Item GetItem()
        {
            return AddedItem;
        }


    }
}