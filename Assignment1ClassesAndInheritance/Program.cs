namespace Assignment1ClassesAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Modern Appliances!\n" +
                              "How May We Assist You?\n" +
                              "1 - Check out Appliance\n" +
                              "2 - Find appliances by brand\n" +
                              "3 - Display appliances by type\n" +
                              "4 - PRoduce random appliance list\n" +
                              "5 - Save & exit");
        }

        /*
         * Method method
         * ask user for the item number
         * then checks through the list of the item is available
         * if the item is available 
         * then it calls the function (isAvailable)
         * call the method for checkout
         * tell user
         * @param
         * @return 
         */

        public void checkoutAppliance()
        {
            Console.WriteLine("Enter the item number: ");

            //enter the item number
            //checking if item is available 
        }

        public void displayRefrigeratorAppliance()
        {
            Console.WriteLine("How many doors: ")

            foreach (Appliance appliance in this.appliances)
            {
                if (appliance is Refrigerator)
                {
                    Refrigerator frige = (Refrigerator)appliance;
                }
            }
        }
    }
}