using System;
using System.Collections.Generic;

namespace HW4
{
    class Item
    {
        int ID; //int number represents the Id of theitem
        string Description; //string describes the item e.g. "Groceries #5"
        float avallableQty; //loat (decimal) number represents the available Quantity (must always be greater than or equal 0, so you need to verify before any attempt to change it)
        float UnitPrice; //item’s unitPrice.

        public  Item(int id, string description, float price, float avaliQuan)
        {
            ID = id;
            Description = description;
            avallableQty = avaliQuan;
            UnitPrice = price;

        }

        public float updateAvlblQty( float PassedValue)
        {
            //Need to verify we have inventory before changing the value
            if(avallableQty>=0){
                // PassedValue can be positive, negative or zero:
                float NewavallableQty = avallableQty + PassedValue;
                return NewavallableQty;
            }
            else{
                //Should return 0, if there is nothing in inventory. 
                return avallableQty; 
            }
             
            
        }
        public float getPrice()
        {
            return UnitPrice;
        }
        public string getItemDescription()
        {
            return Description;
        }
        public int getItemID()
        {
            return ID;
        }
        public void displayItem()
        {
           Console.WriteLine($" ID: {ID}, Description: {Description}, Price: {UnitPrice}, Available Quantity: {avallableQty}");

        }


    
    }
}