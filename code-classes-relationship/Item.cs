using System;
using System.Collections.Generic;

namespace HW4
{
    class Item
    {
        int ID; //int number represents the Id of theitem
        string Description; //string describes the item e.g. "Groceries #5"
        public float avallableQty; //loat (decimal) number represents the available Quantity (must always be greater than or equal 0, so you need to verify before any attempt to change it)
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
            float NewavallableQty; 
            //Need to verify we have inventory before changing the value
            if(avallableQty>=0){
                // PassedValue can be positive, negative or zero:
                // Math.Sign() returns the following:
                // -1 for negative numbers
                // 1 for positive numbers
                // 0 for Zero
                // ref: https://docs.microsoft.com/en-us/dotnet/api/system.math.sign?redirectedfrom=MSDN&view=netframework-4.8#overloads
                int PosOrNeg = Math.Sign(PassedValue);
                Console.WriteLine($"POS or NEG?: {PosOrNeg.ToString()}");
                if(PosOrNeg == 1){
                    NewavallableQty = avallableQty - PassedValue;
                    Console.WriteLine($"NEW QNTY: {NewavallableQty.ToString()}\nAVAL QNTY: {avallableQty.ToString()}\nPASSED VALUE: {PassedValue.ToString()}"); 
                    PosOrNeg = Math.Sign(NewavallableQty);
                    Console.WriteLine($"POS or NEG? AGAIN: {PosOrNeg.ToString()}");
                    if(PosOrNeg == -1){
                        return PosOrNeg;
                    }
                    else{
                        avallableQty = NewavallableQty;
                        return avallableQty;
                    }
                }
                if(PosOrNeg == -1){
                    NewavallableQty = avallableQty + PassedValue;
                     Console.WriteLine($"NEW QNTY: {NewavallableQty.ToString()}\nAVAL QNTY: {avallableQty.ToString()}\nPASSED VALUE: {PassedValue.ToString()}"); 
                    PosOrNeg = Math.Sign(NewavallableQty);
                    if(PosOrNeg == -1){
                        return PosOrNeg;
                    }
                    else{
                        return NewavallableQty;
                    }
                }
                //NewavallableQty = avallableQty + PassedValue;
                // Check to see if we have enough in inventory: 
                //if(NewavallableQty >=0){
                    //return NewavallableQty;
                //}
                // return  if we don't have enough in inventory? would need error handling within the Invoice; 
                return 0;
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