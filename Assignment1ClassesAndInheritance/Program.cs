using System.Reflection;

namespace Assignment1ClassesAndInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dummy appliance
            Appliance main = new Appliance(111111111, "brand", 1, 1.0, "color", 1.0);
            Refrigerator mainFridge = new Refrigerator(111111111, "brand", 1, 1.0, "color", 1.0, "1", 1, 1);
            Vacuum mainVac = new Vacuum(111111111, "brand", 1, 1.0, "color", 1.0, "1", "1");
            Microwave mainMicro = new Microwave(111111111, "brand", 1, 1.0, "color", 1.0, 1.0, "1");
            Dishwasher mainWasher = new Dishwasher(111111111, "brand", 1, 1.0, "color", 1.0, "1", "1");


            //Creating the list of appliances based off of the text file
            List<Appliance> list = new List<Appliance>();
            List<Refrigerator> rList = new List<Refrigerator>();
            List<Vacuum> vList = new List<Vacuum>();
            List<Microwave> mList = new List<Microwave>();
            List<Dishwasher> dList = new List<Dishwasher>();

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
                    string dNumberOfDoors = applianceData[6];
                    int dHeight = int.Parse(applianceData[7]);
                    int dWidth = int.Parse(applianceData[8]);

                    Refrigerator fridge = new Refrigerator(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dNumberOfDoors, dHeight, dWidth);

                    list.Add(fridge);
                    rList.Add(fridge);

                }
                if (applianceData[0][0].Equals('2'))
                {
                    //if the first digit is Vacuum then 

                    //getting other Vacuum attributes
                    string dGrade = applianceData[6];
                    string dVoltage = applianceData[7];

                    Vacuum vac = new Vacuum(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dGrade, dVoltage);

                    list.Add(vac);
                    vList.Add(vac);

                }
                if (applianceData[0][0].Equals('3'))
                {
                    //if the first digit is Microwave then 

                    //getting other Microwave attributes
                    double dCapacity = double.Parse(applianceData[6]);
                    string dRoomType = applianceData[7];

                    Microwave mirco = new Microwave(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dCapacity, dRoomType);

                    list.Add(mirco);
                    mList.Add(mirco);
                }
                if (applianceData[0][0].Equals('4') || applianceData[0][0].Equals('5'))
                {
                    //if the first digit is Dishwasher then 

                    //getting other Dishwasher attributes
                    string dFinish = applianceData[6];
                    string dSound = applianceData[7];

                    Dishwasher washer = new Dishwasher(dItemNumber, dBrand, dQuantity, dWattage, dColor, dPrice, dFinish, dSound);

                    list.Add(washer);
                    dList.Add(washer);
                }
            }


            //Menu loop
            bool menuLoop = true;

            while (menuLoop)
            {
                //Creating Main Message
                Console.WriteLine("Welcome to Modern Appliances!\n" +
                                  "How May We Assist You?\n" +
                                  "1 - Check out Appliance\n" +
                                  "2 - Find appliances by brand\n" +
                                  "3 - Display appliances by type\n" +
                                  "4 - Produce random appliance list\n" +
                                  "5 - Save & exit\n");

                //Getting user menu input
                int menuInput = Convert.ToInt32(Console.ReadLine());

                switch (menuInput)
                {
                    //If they choose to checkout an appliance
                    case 1:
                        main.checkoutAppliance(list);
                        break;
                    //If they choose to find appliance by brand
                    case 2:
                        main.findApplianceByBrand(list);
                        break;
                    //Display appliances by type
                    case 3:
                        //Appliance message
                        Console.WriteLine("Appliance Types\n" +
                                          "1 - Refrigerators\n" +
                                          "2 - Vacuums\n" +
                                          "3 - Microwaves\n" +
                                          "4 - Dishwashers\n" +
                                          "Enter Type of appliance:");

                        //Asking for type of appliance
                        int applianceInput = Convert.ToInt32(Console.ReadLine());

                        switch (applianceInput)
                        {
                            //Refrigerator
                            case 1:
                                Console.WriteLine("Enter number of doors: 2 (double door), 3 (three doors) or 4 (four doors):\n");
                                string doorInput = Console.ReadLine();
                                mainFridge.findApplianceByDoor(rList, doorInput);
                                break;

                            //Vacuum
                            case 2:
                                Console.WriteLine("Enter battery voltage value. 18 V (low) or 24 V (high):");
                                string voltInput = Console.ReadLine();
                                mainVac.findApplianceByVoltage(vList, voltInput);
                                break;

                            //Microwaves
                            case 3:
                                Console.WriteLine("Room where the microwave will be installed: K (kitchen) or W (work site):");
                                string roomInput = Console.ReadLine();
                                mainMicro.findApplianceByRoom(mList, roomInput);
                                break;

                            //Dishwasher
                            case 4:
                                Console.WriteLine("Enter the sound rating of the dishwasher: Qt (Quietest), Qr (Quieter), Qu(Quiet) or M (Moderate):");
                                string soundInput = Console.ReadLine();
                                mainWasher.findApplianceBySound(dList, soundInput);
                                break;
                        }
                        break;
                    //Produce random appliance list
                    case 4:
                        Console.WriteLine("Enter number of appliances:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < amount; i++)
                        {
                            //Generating random id number from 100000000 - 599999999 (only possible item numbers)
                            var random = new Random();
                            long newItemNumber = random.Next(100000000, 599999999);

                            //Generating a random brand from the already made brands
                            string[] brands = { "Bosch", "Tefal", "Hoover", "Black & Decker", "Miele", "Philips", "Kenwood", "Russell Hobbs", "Dyson", "Vax" };
                            int brandIndex = random.Next(brands.Length);
                            string newBrand = brands[brandIndex];

                            //Generating a random Quantity from 1-100
                            int newQuantity = random.Next(1, 100);

                            //Generating random wattage 1-4500 and has to end in 0
                            double newWattage = random.Next(1, 450) * 10;

                            //Generating random color from color selection
                            string[] colors = { "grey", "black", "white", "bronze", "silver" };
                            int colorIndex = random.Next(colors.Length);
                            string newColor = colors[colorIndex];

                            //Generating a random price for the appliance from 99-2990
                            double newPrice = random.Next(99, 2990);

                            long checkingNewItemNumber = newItemNumber;
                            //Checks what type of appliance it is
                            while (checkingNewItemNumber >= 10)
                            {
                                checkingNewItemNumber = (checkingNewItemNumber - (checkingNewItemNumber % 10)) / 10;

                            }

                            //If its a Refrigerator
                            if (checkingNewItemNumber == 1)
                            {
                                //Generate Refrigerator Attributes
                                string[] doors = { "2", "3", "4" };
                                int doorIndex = random.Next(doors.Length);
                                string newDoors = doors[doorIndex];

                                //Generating height and width from 10-50
                                int newHeight = random.Next(10, 50);
                                int newWidth = random.Next(10, 50);

                                //Creating Refrigerator Object and adding to list
                                Refrigerator newRefrigerator = new Refrigerator(newItemNumber, newBrand, newQuantity, newWattage, newColor, newPrice, newDoors, newHeight, newWidth);

                                //Displaying new object
                                Console.WriteLine(newRefrigerator.ToString());

                                list.Add(newRefrigerator);
                                rList.Add(newRefrigerator);
                            }
                            //If its a Vacuum
                            if (checkingNewItemNumber == 2)
                            {
                                //Generate Vacuum Attributes
                                string[] grades = {"Residential","Commercial"};
                                int gradeIndex = random.Next(grades.Length);
                                string newGrade = grades[gradeIndex];

                                string[] voltages = { "18", "24" };
                                int voltageIndex = random.Next(voltages.Length);
                                string newVoltage = voltages[voltageIndex];

                                //Creating new Vacuum Object and adding to list
                                Vacuum newVacuum = new Vacuum(newItemNumber, newBrand, newQuantity, newWattage, newColor, newPrice, newGrade, newVoltage);

                                //Displaying new object
                                Console.WriteLine(newVacuum.ToString());

                                list.Add(newVacuum);
                                vList.Add(newVacuum);   
                            }
                            //If its a Microwave
                            if (checkingNewItemNumber == 3)
                            {
                                //Generate Microwave Attributes
                                //Capacity will be from 1-2 with decimals
                                double newCapacity = random.Next(10, 20) / 10;

                                string[] roomTypes = { "K", "W" };
                                int roomTypeIndex = random.Next(roomTypes.Length);
                                string newRoomType = roomTypes[roomTypeIndex];

                                //Creating new Microwave Object and adding to list
                                Microwave newMicrowave = new Microwave(newItemNumber, newBrand, newQuantity, newWattage, newColor, newPrice, newCapacity, newRoomType);

                                //Displaying new object
                                Console.WriteLine(newMicrowave.ToString());

                                list.Add(newMicrowave);
                                mList.Add(newMicrowave);
                            }
                            //If its a Dishwasher
                            if (checkingNewItemNumber == 4 || checkingNewItemNumber == 5)
                            {
                                //Generate Dishwasher Attributes
                                string[] features = { "Clean with Steam", "Finger Print Resistant", "Third Rack"};
                                int featureIndex = random.Next(features.Length);
                                string newFeature = features[featureIndex];

                                string[] sounds = { "Qt", "Qr", "Qu", "M" };
                                int soundIndex = random.Next(sounds.Length);
                                string newSound = sounds[soundIndex];

                                //Creating new Dishwasher Object and adding to list
                                Dishwasher newDishwasher = new Dishwasher(newItemNumber, newBrand, newQuantity, newWattage, newColor, newPrice, newFeature, newSound);

                                //Displaying new object
                                Console.WriteLine(newDishwasher.ToString());

                                list.Add(newDishwasher);
                                dList.Add(newDishwasher);
                            }

                        }
                        break;
                    //Save and Exit the program
                    case 5:
                        Console.WriteLine("Saving and Exiting The Program");

                        //Writing list to file 
                        //Clearing the file before hand
                        File.WriteAllText(path, String.Empty);

                        //Creating list of string from list of objects
                        List<string> listOfAppliances = new List<string>();

                        for (int i = 0; i < list.Count; i++)
                        {
                            string line = list[i].ToString();
                            line = line.Replace("Item Number: ", "");
                            line = line.Replace("Brand: ","");
                            line = line.Replace("Quantity: ", "");
                            line = line.Replace("Wattage: ", "");
                            line = line.Replace("Color: ", "");
                            line = line.Replace("Price: ", "");
                            line = line.Replace("Number Of Doors: ", "");
                            line = line.Replace("Height: ", "");
                            line = line.Replace("Width: ", "");
                            line = line.Replace("Grade: ", "");
                            line = line.Replace("Voltage: ", "");
                            line = line.Replace("Feature: ", "");
                            line = line.Replace("Sound: ", "");
                            line = line.Replace("Capacity: ", "");
                            line = line.Replace("Room Type: ", "");
                            line = line.Replace("\n", ";");
                            line = line.Replace("double doors", "2");
                            line = line.Replace("three doors", "3");
                            line = line.Replace("four doors", "4");
                            line = line.Replace("Low", "18");
                            line = line.Replace("High", "24");
                            line = line.Replace("Quietest", "Qt");
                            line = line.Replace("Quieter", "Qr");
                            line = line.Replace("Quiet", "Qu");
                            line = line.Replace("Moderate", "M");
                            line = line.Replace("kitchen", "K");
                            line = line.Replace("work site", "W");
                            listOfAppliances.Add(line);
                        }

                        File.WriteAllLines(path, listOfAppliances);

                        menuLoop = false;
                        break;
                }
            }





        }

    }

}