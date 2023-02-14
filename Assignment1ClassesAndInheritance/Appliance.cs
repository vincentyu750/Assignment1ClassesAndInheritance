using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    //Appliance Class 
    class Appliance
    {
        private long itemNumber;
        private string brand;
        private int quantity;
        private double wattage;
        private string color;
        private double price;

        //Class Constructor
        public Appliance(long aItemNumber,
                          string aBrand,
                          int aQuantity,
                          double aWattage,
                          string aColor,
                          double aPrice)
        {
            this.itemNumber = aItemNumber;
            this.brand = aBrand;
            this.quantity = aQuantity;
            this.wattage = aWattage;
            this.color = aColor;
            this.price = aPrice;
        }

        //Getters and Setters Methods
        public long ItemNumber { get { return itemNumber; } set { itemNumber = value; } }
        public string Brand { get { return brand; } set { brand = value; } }
        public int Quantity { get { return quantity;} set { quantity = value; } }
        public double Wattage { get { return wattage; } set { wattage = value; } }
        public string Color { get { return color; } set { color = value; } }
        public double Price { get { return price;} set { price = value; } }

        //Appliance Availability Method
        public void checkoutAppliance(List<Appliance> aList)
        {
            int counter = 2;

            //Asking user for number of appliance
            Console.WriteLine("Enter item number of an Appliance:");
            long inputLong = Convert.ToInt64(Console.ReadLine());
            for (int i = 0; i < aList.Count; i ++)
            {
                if (aList[i].ItemNumber == inputLong)
                {
                    Console.WriteLine("Appliance " + inputLong + " has been checked out.\n");
                    aList.RemoveAt(i);
                    counter = 1;
                    break;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine("No appliances found with that item number.\n");
            }
        }

        //Finding Appliances by Brand
        public void findApplianceByBrand (List<Appliance> aList)
        {
            //Asking user for number of appliance
            Console.WriteLine("Enter brand to search for:");
            string input = Console.ReadLine();
            Console.WriteLine("Matching Appliances:\n");
            foreach (Appliance appliance in aList)
            {
                if (appliance.Brand == input)
                {
                    Console.WriteLine(appliance.ToString());
                }
            }
        }

        //Formatting Appliance Data to File
        public string formatForFile()
        {
            return (ItemNumber + ";" +
                Brand + ";" +
                Quantity + ";" +
                Wattage + ";" +
                Color + ";" +
                Price + ";");
                
        }

        //Appliance ToString Method 
        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: "+ Brand + "\n" +
                    "Quantity: "+ Quantity + "\n" +
                    "Wattage: "+ Wattage + "\n" +
                    "Color: "+ Color + "\n" +
                    "Price: "+ Price + "\n");

        }
    }
}
