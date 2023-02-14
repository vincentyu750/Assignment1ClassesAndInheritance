using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    class Dishwasher : Appliance
    {
        private string feature;
        private string sound; 

        //Class Constructor
        public Dishwasher(long aItemNumber, string aBrand, int aQuantity, double aWattage, string aColor, double aPrice, string aFeature, string aSound) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
        {
            //Capital Are the getter methods
            this.ItemNumber = aItemNumber;
            this.Brand = aBrand;
            this.Quantity = aQuantity;
            this.Wattage = aWattage;
            this.Color = aColor;
            this.Price = aPrice;

            //Dishwasher Exclustive Attributes
            this.feature = aFeature;
            this.sound = aSound;
        }

        public string Sound 
        { 
            get 
            {
                if (sound == "Qt")
                {
                    sound = "Quietest";
                }
                if (sound == "Qr")
                {
                    sound = "Quieter";
                }
                if (sound == "Qu")
                {
                    sound = "Quiet";
                }
                if (sound == "M")
                {
                    sound = "Moderate";
                }
                return sound; 
            } 
        }

        public void findApplianceBySound(List<Dishwasher> vList, string input)
        {
            foreach (Dishwasher dishwasher in vList)
            {
                if (dishwasher.sound == input)
                {
                    Console.WriteLine(dishwasher.ToString());
                }
            }
        }

        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: " + Brand + "\n" +
                    "Quantity: " + Quantity + "\n" +
                    "Wattage: " + Wattage + "\n" +
                    "Color: " + Color + "\n" +
                    "Price: " + Price + "\n" +
                    "Feature: " + feature + "\n" +
                    "Sound: " + Sound + "\n");

        }


    }
}
