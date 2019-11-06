using System;
using System.Collections.Generic;

namespace HW4
{
    class Invoice
    {

        int InvNum; // invoice number
        string nvDate = "";//invoice date (a stringlike “10/10/2019”)

        int total; // sum of the prices of all items in the invoice (must be updated whenever an item added/removed from the invoice)
    
        public void newInvoceEntry(InvoiceEntry invoice)
        {
            
        }


        public Invoice( int invoiceNumber, string invoiceDate)
        {
            InvNum = invoiceNumber;
            nvDate = invoiceDate;
        } 

        public int addInvEntry(int item, int ReqQuantity)
        {}

        public removeInvEntry( lineNumber )
        {}

        public updateTotal( newValue)
        {}

        public updateLineNumbers()
        {}

        public printInvoice()
        {}
    
    }
}