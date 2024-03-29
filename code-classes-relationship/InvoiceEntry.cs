using System;
using System.Collections.Generic;

namespace HW4
{
    class InvoiceEntry
    {
        int LineNo; //a sequence number shows the line of the item in the invoice,
        int Qnty; // an int number shows the number of itemunits sold in that line

        ///<summary>
        ///Use the new line number (lineNo) together with the passed (item) object 
        ///and the requested quantity (ReqQuantity) to call the InvoiceEntry Constructor to create the new InvoiceEntry object.
        ///</summary>
        public InvoiceEntry(Item item, int lineNo, int ReqQuantity)
        {
            LineNo = lineNo;
            Qnty = ReqQuantity;
        }

        public InvoiceEntry(int Lnumber, int Quantity)
        {
            LineNo = Lnumber;
            Qnty = Quantity;
        }

        public void setLineNumber(int newLineNumber)
        {
            LineNo = newLineNumber;
        }

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
