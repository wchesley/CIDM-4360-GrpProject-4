using System;
using System.Collections.Generic;

namespace HW4
{
    class InvoiceEntry
    {
        InvoiceEntry invoice;
        int LineNo; //a sequence number shows the line of the item in the invoice,
        int Qnty; // an int number shows the number of itemunits sold in that line


        public int getLineNumber()
        {
            return LineNo;
        }

        public int setLineNumber( int lineNum)
        {
            LineNo = lineNum;
            return lineNum;
        }

        public int getQnty()
        {
            return Qnty;
        }
    }
}