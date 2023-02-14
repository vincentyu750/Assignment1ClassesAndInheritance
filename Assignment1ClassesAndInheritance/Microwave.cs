using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    class Microwave : Appliance
    {
        private double capacity;
        private string roomType;
        public Microwave(long aItemNumber, string aBrand, int aQuantity, double aWattage, string aColor, double aPrice, double aCapacity, string aRoomType) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
        {
            //Capital Are the getter methods
            this.ItemNumber = aItemNumber;
            this.Brand = aBrand;
            this.Quantity = aQuantity;
            this.Wattage = aWattage;
            this.Color = aColor;
            this.Price = aPrice;

            //Microwave Exclusive Attributes
            this.capacity = aCapacity;
            this.roomType = aRoomType;
        }

        public string RoomType
        {
            get
            {
                if (roomType == "K")
                {
                    roomType = "kitchen";
                }
                if (roomType == "W")
                {
                    roomType = "work site";
                }

                return roomType;
            }
        }

        public void findApplianceByRoom(List<Microwave> vList, string input)
        {
            foreach (Microwave microwave in vList)
            {
                if (microwave.roomType == input)
                {
                    Console.WriteLine(microwave.ToString());
                }
            }
        }

        public string mFormatForFile()
        {
            return this.ItemNumber + ";" +
                this.Brand + ";" +
                this.Quantity + ";" +
                this.Wattage + ";" +
                this.Color + ";" +
                this.Price + ";" +
                this.capacity + ";" +
                this.roomType + ";";
        }

        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: " + Brand + "\n" +
                    "Quantity: " + Quantity + "\n" +
                    "Wattage: " + Wattage + "\n" +
                    "Color: " + Color + "\n" +
                    "Price: " + Price + "\n" +
                    "Capacity: " + capacity + "\n" +
                    "Room Type: " + RoomType + "\n");

        }
    }
}
