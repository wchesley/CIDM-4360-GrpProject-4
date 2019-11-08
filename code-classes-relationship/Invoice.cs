using System;
using System.Collections.Generic;
using System.Linq;

namespace HW4
{
    class Invoice
    {

        int InvNum; // invoice number
        string nvDate = "";//invoice date (a stringlike “10/10/2019”)
        private static List<Item> invoiceList = new List<Item>(); 

        public static float total  {
            get{
                return total;
            }
            set{
                
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
        public bool addInvEntry(Item item, int ReqQuantity)
        {   
            invoiceList.Add(item);
            //List<List>.IndexOf() should return 0 based index of the item we are searching for
            //for logical reasons I added 1 so our lineitems don't start at 0: 
            // ref: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?view=netframework-4.8 
            InvoiceEntry LineItem = new InvoiceEntry(item, invoiceList.IndexOf(item)+1, ReqQuantity);

            //check to see if we have enough in inventory, 
            float itemInInventory = item.updateAvlblQty(ReqQuantity);
            if(itemInInventory != -1)
            {
                //we have enough in inventory; update the avallable quantity: 
                item.avallableQty = item.avallableQty - ReqQuantity;
                //updateTotal(ReqQuantity); 
                return true;
            }
            return false; 
        }

        public bool removeInvEntry(int lineNumber )
        {
            try{
            invoiceList.RemoveAt(lineNumber);
            return true;
            }
            catch(IndexOutOfRangeException e){
                Console.WriteLine($"ERROR:{e}");
                return false;
            }
        }

        private static float updateTotal(float newValue)
        {
            //again assume newValue can be positive or negative: 
            return total = total + newValue;
        }

        private static void updateLineNumbers()
        {
            //using a list will auto update our line numbers? maybe...
        }

        public void printInvoice()
        {
            Console.WriteLine($"Invoice No:{InvNum}\nCreated on:{nvDate}\nTotal:{total}"); 
        }
        
    
    }
}