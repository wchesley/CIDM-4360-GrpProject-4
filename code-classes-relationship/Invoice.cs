using System;
using System.Collections.Generic;
using System.Linq;

namespace HW4
{
    class Invoice
    {

        int InvNum; // invoice number
        string nvDate = "";//invoice date (a stringlike “10/10/2019”)

        public int total  {
            get{
                return total;
            }
            set{
               Invoice.updateTotal(total); 
            }
        } // sum of the prices of all items in the invoice (must be updated whenever an item added/removed from the invoice)
        public void newInvoiceEntry(List<Item> item)
        {

        }


        public Invoice( int invoiceNumber, string invoiceDate)
        {
            InvNum = invoiceNumber;
            nvDate = invoiceDate;
        } 

        ///<summary>
        ///Creates a new invoice entry (InvoiceEntry object ) and add it to the invoice.  
        ///It first calculates the new entry’s line number, then use the new line number together with the passed (item) object 
        ///and the requested quantity (ReqQuantity) to call the InvoiceEntry Constructor to create the new InvoiceEntry object. 
        ///Finally, adds the object to the invoice.  This method must use the passed item object to check the 
        ///requested quantity against the item’s available quantity before creating and adding the new entry. 
        ///It also must update the item’s available quantity based on the requested quantity if quantity verification is passed.
        ///</summary>
        public void addInvEntry(Item item, int ReqQuantity)
        {
            InvoiceEntry LineItem = new InvoiceEntry(item, 5, ReqQuantity);
            //check to see if we have enough in inventory, 
            //if so update the remaining available quantity
            if(item.updateAvlblQty(ReqQuantity) != -1 || item.updateAvlblQty(ReqQuantity) != 0)
            {
                item.avallableQty = ReqQuantity - item.avallableQty;
            }
        }

        public void removeInvEntry(int lineNumber )
        {
            invoiceList.RemoveAt(lineNumber);
        }

        public static int updateTotal(int newValue)
        {
            return newValue; 
        }

        private static void updateLineNumbers()
        {

        }

        public void printInvoice()
        {
            Console.WriteLine($"Invoice No:{InvNum}\nCreated on:{nvDate}\nTotal:{total}"); 
        }
        
    
    }
}