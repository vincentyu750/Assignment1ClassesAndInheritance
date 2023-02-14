using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    class Refrigerator : Appliance
    {
        private int numberOfDoors;
        private int height;
        private int width;
        public Refrigerator(long aItemNumber, string aBrand, int aQuantity, double aWattage, string aColor, double aPrice, int aNumberOfDoors, int aHeight, int aWidth) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
        {
            //Capital Are the getter methods
            this.ItemNumber = aItemNumber;
            this.Brand = aBrand;
            this.Quantity = aQuantity;
            this.Wattage = aWattage;
            this.Color = aColor;
            this.Price = aPrice;

            //Refrigerator Exclusive Attributes
            this.numberOfDoors = aNumberOfDoors;
            this.height = aHeight;
            this.width = aWidth;
        }
        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: " + Brand + "\n" +
                    "Quantity: " + Quantity + "\n" +
                    "Wattage: " + Wattage + "\n" +
                    "Color: " + Color + "\n" +
                    "Price: " + Price + "\n" +
                    "Number Of Doors: " + numberOfDoors + "\n" +
                    "Height: " + height + "\n" +
                    "Width: " + width + "\n");

        }
    }
}
