using System;
using System.Collections.Generic;

namespace HW4
{
    class Item
    {
        public int ID; //int number represents the Id of theitem
        public string Description; //string describes the item e.g. "Groceries #5"
        public float avallableQty; //loat (decimal) number represents the available Quantity (must always be greater than or equal 0, so you need to verify before any attempt to change it)
        public float UnitPrice; //item’s unitPrice.

        public  Item(int id, string description, float price, float avaliQuan)
        {
            ID = id;
            Description = description;
            avallableQty = avaliQuan;
            UnitPrice = price;
        }

        public float updateAvlblQty( float PassedValue)
        {
            float NewavallableQty; 
            //Need to verify we have inventory before changing the value
            if(avallableQty >= 0){
                NewavallableQty = avallableQty - PassedValue;
                
                //new available quantity is greater than 0 and not negative: 
                if(NewavallableQty >= 0 && Math.Sign(NewavallableQty) != -1){
                    return NewavallableQty;
                }
                else return -1;
            }
            else return -1;
             
            
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