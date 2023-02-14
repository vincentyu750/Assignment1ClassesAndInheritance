using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1ClassesAndInheritance
{
    class Vacuum : Appliance
    {

        private string grade;
        private int voltage;

        public Vacuum(long aItemNumber, string aBrand, int aQuantity, double aWattage, string aColor, double aPrice, string aGrade, int aVoltage) : base(aItemNumber, aBrand, aQuantity, aWattage, aColor, aPrice)
        {
            //Capital Are the getter methods
            this.ItemNumber = aItemNumber;
            this.Brand = aBrand;
            this.Quantity = aQuantity;
            this.Wattage = aWattage;
            this.Color = aColor;
            this.Price = aPrice;

            //Vacuum Exclusive Attributes
            this.grade = aGrade;
            this.voltage = aVoltage;
        }

        public override string ToString()
        {
            return ("Item Number: " + ItemNumber + "\n" +
                    "Brand: " + Brand + "\n" +
                    "Quantity: " + Quantity + "\n" +
                    "Wattage: " + Wattage + "\n" +
                    "Color: " + Color + "\n" +
                    "Price: " + Price + "\n" +
                    "Grade: " + grade + "\n" +
                    "Voltage: " + voltage + "\n");

        }
    }
}
