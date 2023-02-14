using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    class Refrigerator : Appliance
    {
        private string numberOfDoors;
        private int height;
        private int width;
        public Refrigerator(long aItemNumber, string aBrand, int aQuantity, double aWattage, string aColor, double aPrice, string aNumberOfDoors, int aHeight, int aWidth) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
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

        public string NumberOfDoors
        {
            get
            {
                if (numberOfDoors == "2")
                {
                    numberOfDoors = "double doors";
                }
                if (numberOfDoors == "3")
                {
                    numberOfDoors = "three doors";
                }
                if (numberOfDoors == "4")
                {
                    numberOfDoors = "four doors";
                }
                return numberOfDoors;
            }
        }

        public void findApplianceByDoor(List<Refrigerator> rList, string input)
        {
            foreach (Refrigerator refrigerator in rList)
            {
                if (refrigerator.numberOfDoors == input)
                {
                    Console.WriteLine(refrigerator.ToString());
                }
            }
        }

        public string rFormatForFile()
        {
            return this.ItemNumber + ";" +
                this.Brand + ";" +
                this.Quantity + ";" +
                this.Wattage + ";" +
                this.Color + ";" +
                this.Price + ";" +
                this.numberOfDoors + ";" +
                this.height + ";" +
                this.width + ";";
        }

        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: " + Brand + "\n" +
                    "Quantity: " + Quantity + "\n" +
                    "Wattage: " + Wattage + "\n" +
                    "Color: " + Color + "\n" +
                    "Price: " + Price + "\n" +
                    "Number Of Doors: " + NumberOfDoors + "\n" +
                    "Height: " + height + "\n" +
                    "Width: " + width + "\n");

        }
    }
}
