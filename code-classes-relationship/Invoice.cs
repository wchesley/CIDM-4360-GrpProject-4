using System;
using System.Collections.Generic;
using System.Linq;

namespace HW4
{
    class Invoice
    {

        int InvNum; // invoice number
        string nvDate = "";//invoice date (a stringlike “10/10/2019”)

        public static float total;  // sum of the prices of all items in the invoice (must be updated whenever an item added/removed from the invoice    

        List<InvoiceEntry> LineItems = new List<InvoiceEntry>();
        private static List<Item> invoiceList = new List<Item>();

        public Invoice(int invoiceNumber, string invoiceDate)
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
            // List<List>.IndexOf() should return 0 based index of the item we are searching for
            // for logical reasons I added 1 so our lineitems don't start at 0: 
            // ref: https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.indexof?view=netframework-4.8 
            updateTotal(item.UnitPrice);
            InvoiceEntry LineItem = new InvoiceEntry(item, invoiceList.IndexOf(item) + 1, ReqQuantity);

            //check to see if we have enough in inventory, 
            float itemInInventory = item.updateAvlblQty(ReqQuantity);
            if (itemInInventory != -1)
            {
                //we have enough in inventory; update the avallable quantity: 
                item.avallableQty = item.avallableQty - ReqQuantity;
                //updateTotal(ReqQuantity); 
                return true;
            }
            return false;
        }

        public bool removeInvEntry(int lineNumber)
        {
            try
            {
                updateTotal(-invoiceList[lineNumber].UnitPrice);
                // zero based index :/
                invoiceList.RemoveAt(lineNumber - 1);
                return true;
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"ERROR:{e}");
                return false;
            }
        }

        private static float updateTotal(float newValue)
        {
            //again assume newValue can be positive or negative: 
            return total += newValue;
        }

        private static void updateLineNumbers()
        {
            //using a list will auto update our line numbers? maybe...
        }

        public void printInvoice()
        {
            Console.WriteLine($"\nInvoice No:{InvNum}  Created on: {nvDate} Total:{total}");
            foreach (var items in invoiceList)
            {
                // zero based index again, in hind sight, now that it may be too late: list was not really the way to handle what was requested of us here: 
                Console.WriteLine($"Line: {invoiceList.IndexOf(items) + 1} Desc: {items.Description}");
            }
        }


    }
}
