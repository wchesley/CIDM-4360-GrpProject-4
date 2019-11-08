using System;
using System.Collections.Generic;

namespace HW4
{
    class Invoice
    {

        int InvNum; // invoice number
        string nvDate = "";//invoice date (a stringlike “10/10/2019”)
        int lineNO = 0;
        
        
         public int total  {
            get{
                return total;
            }
            set{
               Invoice.updateTotal(total); 
            }
        } // sum of the prices of all items in the invoice (must be updated whenever an item added/removed from the invoice    
       List<Item> invoiceList = new List<Item>(); 
       List<InvoiceEntry> LineItems = new List<InvoiceEntry>();
        public void newInvoiceEntry(List<Item> item)
        {
            //should take the whole item object and added it to the invoice. 
            for(int i=0;i>=item.Count;i++)
            {
                invoiceList.Add(item[i]); 
            }
        }


        public Invoice( int invoiceNumber, string invoiceDate)
        {
            InvNum = invoiceNumber;
            nvDate = invoiceDate;
        } 

        // public float addInvEntry(Item Ad, int ReqQuantity)
        // {
        //     if (item.avallableQty > ReqQuantity){         
        //         InvoiceEntry invoice = new InvoiceEntry(item, ReqQuantity);
        //         item.avallableQty = item.avallableQty - ReqQuantity;
        //     }
        //     return item.avallableQty;
        // }

        public void removeInvEntry(int lineNumber )
        {
            invoiceList.RemoveAt(lineNumber);
        }

        public static float updateTotal(float newValue)
        {             
            Invoice.updateTotal(newValue); 
            return newValue; 
        }

        public void updateLineNumbers()
        {
             int Cntr = 1; // 
            foreach(InvoiceEntry e in LineItems)
            {
                e.setLineNumber(Cntr);
                Cntr++;
            }   
        }

        public void printInvoice()
        {

        }
        private void setLineNumber(int newLineNumber)
        {

        }
    
    }
}