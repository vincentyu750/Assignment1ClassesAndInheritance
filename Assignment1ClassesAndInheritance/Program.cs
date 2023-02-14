using System.Reflection;

namespace Assignment1ClassesAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating Main Message
            Console.WriteLine("Welcome to Modern Appliances!\n" +
                              "How May We Assist You?\n" +
                              "1 - Check out Appliance\n" +
                              "2 - Find appliances by brand\n" +
                              "3 - Display appliances by type\n" +
                              "4 - PRoduce random appliance list\n" +
                              "5 - Save & exit\n");

            
            //Creating the list of appliances based off of the text file
            List<Appliance> list = new List<Appliance>();
            list = fileToList();


            foreach (Appliance appliance in list)
            {
                Console.WriteLine(appliance.ToString());
            }
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



        /*
         * fileToList
         * Runs through the file to add contents to the list in terms 
         * of their respective appliance
         * @param
         * @return list<Appliance>
         */
        public static List<Appliance> fileToList()
        {
            //Creating empty list of appliances
            List<Appliance> applianceListMain = new List<Appliance>();

            //Making path for the appliances.txt file
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"appliances.txt");

            //Parsing through the file adding each appliance to a list
            foreach (string line in File.ReadLines(path))
            {
                //Taking each line and spliting into a list of strings for creating the appliances
                string[] applianceData = line.Split(';');

                //Values of the Appliances
                long dItemNumber = long.Parse(applianceData[0]);
                string dBrand = applianceData[1];
                int dQuantity = int.Parse(applianceData[2]);
                double dWattage = double.Parse(applianceData[3]);
                string dColor = applianceData[4];
                double dPrice = double.Parse(applianceData[5]);

                //Checks what type of appliance it is by its first character in string
                if (applianceData[0][0].Equals('1'))
                {
                    //if the first digit is refrigerator then 

                    //getting other refrigerator attributes
                    int dNumberOfDoors = int.Parse(applianceData[6]);
                    int dHeight = int.Parse(applianceData[7]);
                    int dWidth = int.Parse(applianceData[8]);

                    Refrigerator fridge = new Refrigerator(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dNumberOfDoors, dHeight, dWidth);

                    applianceListMain.Add(fridge);

                }
                if (applianceData[0][0].Equals('2'))
                {
                    //if the first digit is Vacuum then 

                    //getting other Vacuum attributes
                    string dGrade = applianceData[6];
                    int dVoltage = int.Parse(applianceData[7]);

                    Vacuum vac = new Vacuum(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dGrade, dVoltage);

                    applianceListMain.Add(vac);

                }
                if (applianceData[0][0].Equals('3'))
                {
                    //if the first digit is Microwave then 

                    //getting other Microwave attributes
                    double dCapacity = double.Parse(applianceData[6]);
                    string dRoomType = applianceData[7];

                    Microwave mirco = new Microwave(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dCapacity, dRoomType);

                    applianceListMain.Add(mirco);
                }
                if (applianceData[0][0].Equals('4') || applianceData[0][0].Equals('5'))
                {
                    //if the first digit is Dishwasher then 

                    //getting other Dishwasher attributes
                    string dFinish = applianceData[6];
                    string dSound = applianceData[7];

                    Dishwasher washer = new Dishwasher(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dFinish, dSound);

                    applianceListMain.Add(washer);
                }
            }
            return applianceListMain;
        }
    }
}