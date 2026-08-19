

#region Session 4 
//Console.WriteLine("Hello, World!");
//Console.Write("Enter your full name: ");
//string fullName = Console.ReadLine(); // Enter
////1. String Concatenation
//Console.WriteLine("Hi, " + fullName + "!");

////2. String Interpolation
//Console.WriteLine($"Hi, {fullName}!");

////Escape Sequences
//Console.WriteLine("Egypt\nKuwait\nOman"); // new line
//Console.WriteLine("Egypt\tKuwait\tOman"); // tab

//// tab -> Tabular Formatting
//Console.WriteLine("Id\tName\tAge\n1\tAhmed\t37\n2\tOmar\t29\n3\tMostafa\t42");
//Console.WriteLine("Ahmed said: \"Good morning\""); //Ahmed said: "Good morning"
//Console.WriteLine("\\");
//Console.WriteLine("\u2190");
//Console.WriteLine("\u2191");
//Console.WriteLine("\u2192");
//Console.WriteLine("\u2193");

//Console.WriteLine("K:\\Projects\\Reports\\JulyReport.pdf");

////3. Verbatim String
//Console.WriteLine(@"K:\Projects\Reports\JulyReport.pdf");

////4. Raw String
//string rawStringPath = """
//    K:\Projects\Reports\JulyReport.pdf
//    """;
//Console.WriteLine("rawStringPath: " + rawStringPath);

////==============================================================================


//while (true)
//{
//    Console.Write("\nEnter your score: ");
//    float score = Convert.ToSingle(Console.ReadLine());

//    if (score >= 95)
//    {
//        Console.WriteLine("Excellence Gift: 5000 EGP.");
//    }

//    if (score >= 50)
//    {
//        Console.WriteLine("Passed");
//    }
//    else
//    {
//        Console.WriteLine("Failed");
//    }
//}
////==============================================================================


////UTC -> Universal Time Coordinate -> GMT
//Console.WriteLine("DateTime.UtcNow\t\t: " + DateTime.UtcNow);
//Console.WriteLine("DateTime.Now\t\t: " + DateTime.Now);
//Console.WriteLine("DateTime.Now.Hour\t: " + DateTime.Now.Hour);

////int currentHour = DateTime.Now.Hour;
//for (int i = 0; i < 10; i++)
//{
//    Console.Write("\nEnter current hour: ");
//    int currentHour = Convert.ToInt32(Console.ReadLine());
//    if (currentHour >= 5 && currentHour < 13)
//    {
//        Console.WriteLine("Good morning!");
//    }
//    else if (currentHour >= 13 && currentHour < 20)
//    {
//        Console.WriteLine("Good afternoon!");
//    }
//    else
//    {
//        Console.WriteLine("Good evening!");
//    }
//}

////==============================================================================

//// Ternary Conditional Operator ?:
//for (; ; )
//{
//    Console.Write("\nEnter your score: ");
//    float score = Convert.ToSingle(Console.ReadLine());

//    string studentStatus = score >= 50 ? "Passed" : "Failed";

//    Console.WriteLine("studentStatus: " + studentStatus);

//    string studentGrade = score >= 90 ? "Perfect" :
//                          score >= 80 ? "Very Good" :
//                          score >= 65 ? "Good" :
//                          score >= 50 ? "Passed" :
//                          score >= 40 ? "Poor" : "Very Poor";

//    Console.WriteLine("studentGrade: " + studentGrade);
//}

////==============================================================================


//DateTime hiringDateTime = new DateTime(1995, 12, 23, 20, 35, 49);

//Console.WriteLine(nameof(hiringDateTime) + "\t\t\t: " + hiringDateTime);
//Console.WriteLine(nameof(hiringDateTime) + ".ToString()\t\t: " + hiringDateTime.ToString());
//Console.WriteLine(nameof(hiringDateTime) + ".ToLongDateString()\t: " + hiringDateTime.ToLongDateString());
//Console.WriteLine(nameof(hiringDateTime) + ".ToShortDateString()\t: " + hiringDateTime.ToShortDateString());
//Console.WriteLine(nameof(hiringDateTime) + ".ToLongTimeString()\t: " + hiringDateTime.ToLongTimeString());
//Console.WriteLine(nameof(hiringDateTime) + ".ToShortTimeString()\t: " + hiringDateTime.ToShortTimeString());
#endregion

#region Session 5
//using System.Globalization;

////1-Date

//DateTime joiningDateTime = new DateTime(1995, 7, 9, 8, 5, 6);
////Format Specifiers
//Console.WriteLine("joiningDateTime.ToString(\"d/M/yy\")\t\t: " + joiningDateTime.ToString("d/M/yy"));
//Console.WriteLine("joiningDateTime.ToString(\"dd/MM/yyyy\")\t\t: " + joiningDateTime.ToString("dd/MM/yyyy"));

//Console.WriteLine("joiningDateTime.ToString(\"dd/MM/yyyy h:m:s t\")\t\t: " + joiningDateTime.ToString("dd/MM/yyyy h:m:s t"));
//Console.WriteLine("joiningDateTime.ToString(\"dd/MM/yyyy hh:mm:ss tt\")\t: " + joiningDateTime.ToString("dd/MM/yyyy hh:mm:ss tt"));

//DateTime joiningDateTime2 = new DateTime(1995, 7, 9, 18, 5, 6);
//Console.WriteLine("joiningDateTime2.ToString(\"dd/MM/yyyy H:m:s t\")\t\t: " + joiningDateTime2.ToString("dd/MM/yyyy H:m:s t"));
//Console.WriteLine("joiningDateTime2.ToString(\"dd/MM/yyyy HH:mm:ss tt\")\t: " + joiningDateTime2.ToString("dd/MM/yyyy HH:mm:ss tt"));

////N -> Number
//float firstNo = 2.579f;
//Console.WriteLine("\nfirstNo: " + firstNo);
//Console.WriteLine("firstNo.ToString(\"N0\")\t: " + firstNo.ToString("N0"));
//Console.WriteLine("firstNo.ToString(\"N1\")\t: " + firstNo.ToString("N1"));
//Console.WriteLine("firstNo.ToString(\"N2\")\t: " + firstNo.ToString("N2"));
//Console.WriteLine("firstNo.ToString(\"N3\")\t: " + firstNo.ToString("N3"));
//Console.WriteLine("firstNo.ToString(\"N4\")\t: " + firstNo.ToString("N4"));
//Console.WriteLine("firstNo.ToString(\"N\")\t: " + firstNo.ToString("N"));

////C -> Currency
//Console.WriteLine("\nfirstNo.ToString(\"C0\")\t: " + firstNo.ToString("C0"));
//Console.WriteLine("firstNo.ToString(\"C1\")\t: " + firstNo.ToString("C1"));
//Console.WriteLine("firstNo.ToString(\"C2\")\t: " + firstNo.ToString("C2"));
//Console.WriteLine("firstNo.ToString(\"C3\")\t: " + firstNo.ToString("C3"));
//Console.WriteLine("firstNo.ToString(\"C4\")\t: " + firstNo.ToString("C4"));
//Console.WriteLine("firstNo.ToString(\"C\")\t: " + firstNo.ToString("C"));

////Culture Name -> locale code -> ar-EG  ar-KW  en-US  en-GB
//Console.WriteLine("\nar-EG: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("ar-EG")));
//Console.WriteLine("ar-KW: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("ar-KW")));
//Console.WriteLine("en-US: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-US")));
//Console.WriteLine("en-GB: " + firstNo.ToString("C2", CultureInfo.CreateSpecificCulture("en-GB")));

////P -> Percentage
//float secondNo = 0.579f;
//Console.WriteLine("\nsecondNo: " + secondNo);
//Console.WriteLine("secondNo.ToString(\"P0\")\t: " + secondNo.ToString("P0"));
//Console.WriteLine("secondNo.ToString(\"P1\")\t: " + secondNo.ToString("P1"));
//Console.WriteLine("secondNo.ToString(\"P2\")\t: " + secondNo.ToString("P2"));
//Console.WriteLine("secondNo.ToString(\"P\")\t: " + secondNo.ToString("P"));


//==============================================================================


////2-Multiple Initialization and Iterators/Steppers
//for (int i = 0, j = 10; i + j <= 20; i++, j++)
//{
//    Console.WriteLine("i+j: " + i + " + " + j + " = " + (i + j));
//}

////Nested Loop/Iteration
//for (int i = 1; i <= 12; i++)
//{
//    Console.WriteLine("\nMultiplication Table " + i + ":");
//    for (int j = 1; j <= 12; j++)
//    {
//        Console.WriteLine(i + " * " + j + " = " + (i * j));
//    }
//}

//string allProducts = string.Empty;
//Console.WriteLine("Enter a product name then press Enter (When finished enter done):");

//for (string userInput = string.Empty; userInput != "done";)
//{
//    userInput = Console.ReadLine();

//    if (userInput != "done")
//    {
//        allProducts += "\n- " + userInput;
//    }
//}
//Console.WriteLine("\nAll Products: " + allProducts);

//string allProductsBreak = string.Empty;
//Console.WriteLine("\nEnter a product name then press Enter (When finished enter done):");

//for (string userInput = string.Empty; ;)
//{
//    userInput = Console.ReadLine();

//    if (userInput == "done") break; //stop the loop/iteration

//    allProductsBreak += "\n- " + userInput;
//}

//Console.WriteLine("\nAll Products (Break): " + allProductsBreak);

//string allProductsInitial = string.Empty;
//Console.WriteLine("\nEnter a product name then press Enter (When finished enter done):");

//for (string userInput = Console.ReadLine(); userInput != "done";)
//{
//    allProductsInitial += "\n- " + userInput;
//    userInput = Console.ReadLine();
//}

//Console.WriteLine("\nAll Products (Initialization): " + allProductsInitial);

//==============================================================================


////3- List<> (Resizable & Flexible)
//List<string> allProducts = new() { "SIS", "ERP", "HRMS" };
//allProducts.Add("CRM");
//allProducts.Add("HIS");

//List<string> juneNewProducts = new() { "Abc", "Def" };
//allProducts.AddRange(juneNewProducts);

//string[] julyNewProducts = { "Ghi", "Jkl" };
//allProducts.AddRange(julyNewProducts);

//Console.WriteLine("allProducts[2]: " + allProducts[2]); // HRMS
//allProducts[2] = "HRIS";
//Console.WriteLine("allProducts[2]: " + allProducts[2]); //HRIS

//Console.WriteLine("allProducts.Count: " + allProducts.Count);
//Console.WriteLine("allProducts.Count(): " + allProducts.Count());

//Console.WriteLine("\nfor (int i = 0; i < allProducts.Count; i++)");
//for (int i = 0; i < allProducts.Count; i++)
//{
//    Console.WriteLine(allProducts[i]);
//}

//Console.WriteLine("\nforeach (var product in allProducts)");
//foreach (var product in allProducts)
//{
//    Console.WriteLine(product);
//}

//==============================================================================


////4- Convert List to Array
//string[] productsArray = allProducts.ToArray();
//Console.WriteLine("\nfor (int i = 0; i < productsArray.Length; i++)");
//for (int i = 0; i < productsArray.Length; i++)
//{
//    Console.WriteLine(productsArray[i]);
//}

//Console.WriteLine("\nforeach (var product in productsArray)");
//foreach (var product in productsArray)
//{
//    Console.WriteLine(product);
//}

////Convert Array to List
//string[] continentsArray = { "Africa", "Asia", "Europe", "North America", "South America", "Antarctica" };
//List<string> continentsList = continentsArray.ToList();

//Console.WriteLine("\nfor (int i = 0;i < continentsList.Count; i++)");
//for (int i = 0; i < continentsList.Count; i++)
//{
//    Console.WriteLine(continentsList[i]);
//}

//Console.WriteLine("\nforeach (var product in continentsList)");
//foreach (var product in continentsList)
//{
//    Console.WriteLine(product);

//}

//==============================================================================


//4- Functions / Methods
//string CalculatePrice(decimal cost, decimal profitRatio)
//{
//    return (cost + cost * profitRatio / 100).ToString("C2");
//}

////Re-usability & Maintainability                         
//Console.WriteLine("CalculatePrice(3000.75m, 12.5m): " + CalculatePrice(3000.75m, 12.5m));

////Optional parameters (must appear after all required parameters)
//void PrintDetails(string fullName, string nationality = "Egyptian")
//{
//    Console.WriteLine($"\nFull Name\t: {fullName}\nNationality\t: {nationality}");
//}

//PrintDetails("Ahmed Osama Ali");
//PrintDetails("Wael Mahmoud Mostafa", "Kuwaiti");
//PrintDetails("Bahaa Ayman Saad", "Egyptian");

////Named Arguments
////PrintDetails("Libyan", "Hassan Othman");
//PrintDetails(nationality: "Libyan", fullName: "Hassan Othman");

//==============================================================================



//Expression-bodied Methods                  Function Arrow / Big Arrow
//using First;

//string CalculatePrice(decimal cost, decimal profitRatio) => (cost + cost * profitRatio / 100).ToString("C2");
//void GreetVisitor() => Console.WriteLine("Welcome to Pearly Soft!");

////Re-usability & Maintainability                         agruments
//Console.WriteLine("CalculatePrice(3000.75m, 12.5m): " + CalculatePrice(3000.75m, 12.5m));
//GreetVisitor();

////Some Common Built-in/Pre-defined String Methods:    C# -> Case-sensitive
//string iti = "Information Technology Institute";
//Console.WriteLine(
//    "\niti\t\t: " + iti +
//    "\niti.StartsWith('I')\t: " + iti.StartsWith('I') +
//    "\niti.StartsWith('i')\t: " + iti.StartsWith('i') +

//    "\niti.StartsWith(\"In\")\t: " + iti.StartsWith("In") +
//    "\niti.StartsWith(\"Tech\")\t: " + iti.StartsWith("Tech") +

//    "\niti.EndsWith(\"te\")\t: " + iti.EndsWith("te") +
//    "\niti.EndsWith(\"gy\")\t: " + iti.EndsWith("gy") +

//    "\niti.Contains(\"Tech\")\t: " + iti.Contains("Tech") +
//    "\niti.Contains(\"cs\")\t: " + iti.Contains("cs") +

//    "\niti.IndexOf('o')\t: " + iti.IndexOf('o') +
//    "\niti.IndexOf('z')\t: " + iti.IndexOf('z') +

//    "\niti.IndexOf(\"ti\")\t: " + iti.IndexOf("ti") +
//    "\niti.IndexOf(\"web\")\t: " + iti.IndexOf("web") +

//    "\niti.LastIndexOf('o')\t: " + iti.LastIndexOf('o') +
//    "\niti.LastIndexOf('z')\t: " + iti.LastIndexOf('z') +

//    "\niti.LastIndexOf(\"ti\")\t: " + iti.LastIndexOf("ti") +
//    "\niti.LastIndexOf(\"web\")\t: " + iti.LastIndexOf("web"));



#endregion

#region Session 6

// 1.String.IsNullOrEmpty() & String.IsNullOrWhiteSpace()

//string strNull = null;
//string strEmpty = string.Empty;
//string strSpaces = "         ";
//string strCSharp = "C#";

//Console.WriteLine(
//    "\nstring.IsNullOrEmpty(strNull)\t\t: " + string.IsNullOrEmpty(strNull) +
//    "\nstring.IsNullOrEmpty(strEmpty)\t\t: " + string.IsNullOrEmpty(strEmpty) +
//    "\nstring.IsNullOrEmpty(strSpaces)\t\t: " + string.IsNullOrEmpty(strSpaces) +
//    "\nstring.IsNullOrEmpty(strSpaces.Trim())\t: " + string.IsNullOrEmpty(strSpaces.Trim()) +
//    "\nstring.IsNullOrEmpty(strCSharp)\t\t: " + string.IsNullOrEmpty(strCSharp));

////IsNullOrWhiteSpace -> IsNullOrEmptyOrWhiteSpace
//Console.WriteLine(
//    "\nstring.IsNullOrWhiteSpace(strNull)\t\t: " + string.IsNullOrWhiteSpace(strNull) +
//    "\nstring.IsNullOrWhiteSpace(strEmpty)\t\t: " + string.IsNullOrWhiteSpace(strEmpty) +
//    "\nstring.IsNullOrWhiteSpace(strSpaces)\t\t: " + string.IsNullOrWhiteSpace(strSpaces) +
//    "\nstring.IsNullOrWhiteSpace(strCSharp)\t\t: " + string.IsNullOrWhiteSpace(strCSharp));


//==============================================================================


//2. System.IO.Directory

//string[] logicalDrives = Directory.GetLogicalDrives();
//Console.WriteLine(nameof(logicalDrives) + ":");
//for (int i = 0; i < logicalDrives.Length; i++)
//{
//    Console.WriteLine(logicalDrives[i]);
//}

//Directory.CreateDirectory("D:\\Projects");
//Directory.CreateDirectory("D:\\Projects\\2026");
//Directory.CreateDirectory("D:\\Projects\\2026\\Winter");
//Directory.CreateDirectory("D:\\Projects\\2026\\Spring");
//Directory.CreateDirectory("D:\\Projects\\2026\\Summer");
//Directory.CreateDirectory("D:\\Projects\\2026\\Autumn");

//Console.WriteLine("Directory.Exists(\"D:\\\\Projects\\\\2026\\\\Winter\"): " + Directory.Exists("D:\\Projects\\2026\\Winter"));
//Console.WriteLine("Directory.Exists(\"D:\\\\Projects\\\\2026\\\\Fall\"): " + Directory.Exists("D:\\Projects\\2026\\Fall"));

//string[] projects2026SubDirectories = Directory.GetDirectories("D:\\Projects\\2026");
//Console.WriteLine("\n" + nameof(projects2026SubDirectories) + ":");
//for (int i = 0; i < projects2026SubDirectories.Length; i++)
//{
//    Console.WriteLine(projects2026SubDirectories[i]);
//}


//Directory.SetCreationTime("D:\\Projects\\2026\\Spring", new DateTime(2019, 10, 28, 17, 39, 52));
//DateTime springCreationTime = Directory.GetCreationTime("D:\\Projects\\2026\\Spring");
//Console.WriteLine(nameof(springCreationTime) + ":" + springCreationTime);


//==============================================================================

//3. System.IO.File

//File.Create(@"D:\Projects\2026\FirstLetter.png").Dispose();

//byte[] imageABytes = File.ReadAllBytes(@"D:\Misc Files\A.png");
//foreach (var item in imageABytes)
//{
//    Console.Write(item + " - ");
//}

//File.WriteAllBytes(@"D:\Projects\2026\FirstLetter.png", imageABytes);

//FileStream fileStreamNewImageSecondLetter = new FileStream(@"D:\Projects\2026\SecondLetter.png", FileMode.Create);
//FileStream fileStreamOriginalImageB = new FileStream(@"D:\Misc Files\B.png", FileMode.Open);

//fileStreamOriginalImageB.CopyTo(fileStreamNewImageSecondLetter);
//fileStreamNewImageSecondLetter.Dispose();

//File.Copy(@"D:\Misc Files\C.docx", @"D:\Projects\2026\C.docx");
//File.Move(@"D:\Misc Files\A.pdf", @"D:\Projects\2026\A.pdf");
//File.Delete(@"D:\Misc Files\E.png");

//Console.WriteLine("File.Exists(@\"D:\\Misc Files\\E.png\"): " + File.Exists(@"D:\Misc Files\E.png"));


//==============================================================================\

//4.System.IO.Path
//Console.WriteLine("Path.GetDirectoryName(@\"D:\\Projects\\2026\\FirstLetter.png\")\t\t: " +
//    Path.GetDirectoryName(@"D:\Projects\2026\FirstLetter.png"));

//Console.WriteLine("Path.GetFileName(@\"D:\\Projects\\2026\\FirstLetter.png\")\t\t: " +
//    Path.GetFileName(@"D:\Projects\2026\FirstLetter.png"));

//Console.WriteLine("Path.GetFileNameWithoutExtension(@\"D:\\Projects\\2026\\FirstLetter.png\")\t: " +
//    Path.GetFileNameWithoutExtension(@"D:\Projects\2026\FirstLetter.png"));

//Console.WriteLine("Path.GetExtension(@\"D:\\Projects\\2026\\FirstLetter.png\")\t\t: " +
//    Path.GetExtension(@"D:\Projects\2026\FirstLetter.png"));

//Console.WriteLine();
//string logicalDrive = "D:";
//string directory = "Schedules";
//string subDirectory = "Dev Courses";
//string fileName = "Web Dev Course 149.xlsx";

//string fullPathConcatenation = logicalDrive + "\\" + directory + "\\" + subDirectory + "\\" + fileName;
//Console.WriteLine(nameof(fullPathConcatenation) + "\t: " + fullPathConcatenation);

//string fullPathInterpolation = $"{logicalDrive}\\{directory}\\{subDirectory}\\{fileName}";
//Console.WriteLine(nameof(fullPathInterpolation) + "\t: " + fullPathInterpolation);

//string fullPathCombine = Path.Combine(logicalDrive, directory, subDirectory, fileName);
//Console.WriteLine(nameof(fullPathCombine) + "\t\t: " + fullPathCombine);

//==============================================================================

//4.Array Parameter
//double SumUsingArrayParameter(double[] numbers)
//{
//    double sum = 0;

//    foreach (var item in numbers)
//        sum += item;

//    return sum;
//}
//double[] student27Scores = { 30.5, 29, 40.2, 35 };
//double student27TotalScore = SumUsingArrayParameter(student27Scores);
//Console.WriteLine(nameof(student27TotalScore) + "\t:" + student27TotalScore);

////params Keyword
//double SumUsingParamsKeyword(params double[] numbers)
//{
//    double sum = 0;

//    foreach (var item in numbers)
//        sum += item;

//    return sum;
//}

//double student28Scores = SumUsingParamsKeyword(29.5, 32, 25.2, 15.3, 20, 30);
//Console.WriteLine(nameof(student28Scores) + "\t: " + student28Scores);


//==============================================================================



//5. OOP (Object-oriented Programming)
//using First ;
//namespace First
//{
//    class Abc { }
//    class Def
//    {
//        Abc abc1;
//    }
//}

//namespace Second
//{
//    class Ghi
//    {
//        //Without using First; -> The type or namespace name 'Def' could not be found (are you missing a using directive or an assembly reference?)
//        Def def1;
//    }
//    class Jkl { }
//    class Abc { }
//}

//namespace First
//{
//    class Mno { }
//    class Abc { }
//}


//using Gem;

//old Methode Encabulation
//string student = "Ahmed Osama";
//Console.WriteLine("student\t\t\t: " + student);
//Console.WriteLine("student.ToUpper()\t: " + student.ToUpper()); //AHMED OSAMA
//Console.WriteLine("student.ToLower()\t: " + student.ToLower()); //ahmed osama

//Vehicle vehicle2 = new Vehicle();
//vehicle2.SetColor("Brown");
//Console.WriteLine("\nvehicle2.GetColor()\t: " + vehicle2.GetColor());

//Vehicle vehicle3 = new Vehicle();
//vehicle3.SetColor("Yellow"); //Yellow is not allowed.
//Console.WriteLine("vehicle3.GetColor()\t: " + vehicle3.GetColor());



//New Methode Encabulation
//Console.WriteLine();

//Vehicle vehicle4 = new Vehicle();
//vehicle4.Color = "Brown";
//Console.WriteLine("vehicle4.Color\t: " + vehicle4.Color);

//Console.WriteLine();

//Vehicle vehicle5 = new Vehicle();
//vehicle5.Color = "Yellow";
//Console.WriteLine("vehicle5.Color\t: " + vehicle5.Color);


#endregion

#region Session 7
//using Gem;
//Vehicle vehicle6 = new Vehicle();
//// Dot Notation
//// . -> Member Access Operator
//vehicle6.Model = "Tornado";
//vehicle6.Color = "White";
//vehicle6.Width = 1.75;
//vehicle6.Length = 2.35;
//vehicle6.Height = 1.64;
//vehicle6.MaxSpeed = 480;
//vehicle6.Engine = "SM 250";

//Console.WriteLine("\n[[[vehicle6.ShowSpecifications()]]]");
//vehicle6.ShowSpecifications();

//Console.WriteLine("\n[[[vehicle6.ShowSpecifications(\"full\")]]]");
//vehicle6.ShowSpecifications("full");

//Console.WriteLine("\n[[[vehicle6.ShowSpecifications(\"brief\")]]]");
//vehicle6.ShowSpecifications("brief");
//===========================================================================================

//Vehicle vehicle7 = new Vehicle("Lion", "Green");
//Vehicle vehicle7 = new("Lion", "Green");
//Console.WriteLine("[[[vehicle7.ShowSpecifications()]]]");
//vehicle7.ShowSpecifications("brief");

//Vehicle vehicle8 = new("Thunder", "Beige", 190.5, 265.2, 168.5);
//Console.WriteLine("\n[[[vehicle8.ShowSpecifications()]]]");
//vehicle8.ShowSpecifications(); //Paremeterless overload

//Vehicle vehicle9 = new("Stars", "Silver", 188.2, 250.4, 170.2, 420, "TX 500");
//Console.WriteLine("\n[[[vehicle9.ShowSpecifications(\"full\")]]]");
//vehicle9.ShowSpecifications("full");

//===========================================================================================

////Vehicle vehicle9 = new Vehicle()
//Vehicle vehicle9 = new()
//{
//    Model = "Leopard",
//    Color = "Black",
//    Width = 175.3,
//    Length = 250.5,
//    Height = 165.2,
//    MaxSpeed = 460,
//    Engine = "TR 250"
//};

//Console.WriteLine("vehicle9.ShowSpecifications(\"full\")");
//vehicle9.ShowSpecifications("full");

//===========================================================================================


//Truck truck1 = new("Tiger", "Brown", 280.5, 600, 300.25, 270, "NT 25", 72);

//Console.WriteLine("[[[truck1.ShowSpecifications(\"full\")]]]");
//string truck1Specifications = truck1.ShowSpecifications("full");
//Console.WriteLine(truck1Specifications);


//Vehicle vehicle10 = new Vehicle();

//===========================================================================================

//MultiTrailerTruck multiTrailerTruck1 = new("Falcon", "Black", 280.5,
//    600, 300.25, 270, "NT 25", 72, 3);

//string multiTrailerTruck1Specifications =
//    multiTrailerTruck1.ShowSpecifications("full");

//Console.WriteLine("[[[multiTrailerTruck1.ShowSpecifications(\"full\")]]]");
//Console.WriteLine(multiTrailerTruck1Specifications);


#endregion

#region Session 8
//using Gem;

//ProductDescriptionCard productA32DescriptionCard =
//    new ProductDescriptionCard("A32", 7, "Blue");

//productA32DescriptionCard.PrintCard();

//===========================================================================================

////Record
//using Gem;

//Department dept1 = new Department(1010, "TM", "Top Management",
//    275000.25m);

//Console.WriteLine($"Id\t\t: {dept1.Id}\nName\t\t: {dept1.Name}" +
//    $"\nDescription\t: {dept1.Description}\nBudget\t\t: " +
//    $"{dept1.Budget}");

//===========================================================================================

//using Gem;

//Customer customer1 = new()
//{
//    Id = 1001,
//    Name = "Nile Hospitals",
//    Email = "info@NileHospitals.com",
//    Address = "Cairo, 48 Alnasr st.",
//    PhoneNo = "010020030044"
//};

//Console.WriteLine(
//    $"Id\t: {customer1.Id}" +
//    $"\nName\t: {customer1.Name}" +
//    $"\nEmail\t: {customer1.Email}" +
//    $"\nAddress\t: {customer1.Address}" +
//    $"\nPhoneNo\t: {customer1.PhoneNo}"
//);

//===========================================================================================

//using Gem;

//Ghi ghi3 = new Ghi()
//{
//    Id = 1040,
//    Name = "X 20", //private set property
//    Description = "Mno Tablet", //read-only property
//    Price = 1500.75m //Init-only property
//};
//===========================================================================================

////'this' keyword
//using Gem;

//Jkl jkl1 = new("GT71", 15);
//Console.WriteLine("\n[[[Jkl jkl1 = new(\"GT71\", 15);]]]");
//jkl1.Print();
//jkl1.Test("AV42", 39);
//Console.WriteLine("\n[[[jkl1.Test(\"AV42\", 39);]]]");
//jkl1.Print();

//===========================================================================================

//static
//1. static members
//MultiTrailerTruck multiTrailerTruck1 = new MultiTrailerTruck();
//multiTrailerTruck1.NumberOfTrailers = 72;

//MultiTrailerTruck.firstTimeTruck = new DateTime(1970, 11, 24);
//Console.WriteLine("\nMultiTrailerTruck.firstTimeTruck: " +
//                  MultiTrailerTruck.firstTimeTruck);

//MultiTrailerTruck.Manufacturer = "Sunrise";
//Console.WriteLine("\nMultiTrailerTruck.Manufacturer: " +
//                  MultiTrailerTruck.Manufacturer);

//===========================================================================================

//static class
//using Gem;

////Cannot declare a variable of static type 'Utility'
//Utility utility1;

////Cannot create an instance of the static class 'Utility'
//utility1 = new Utility();


////محمود ناصر محمد خليل 
//Utility.HeadOfficeAddress = "Giza, 19 Alzohoor st.";
//Console.WriteLine("Utility.HeadOfficeAddress: " +
//                  Utility.HeadOfficeAddress);

//Utility.GreetUser("Osama Omar");

//===========================================================================================


//Extension Methods
//using Gem;

//string iti = "Information Technology Institue";
//iti.WriteToConsoleInParentheses();

//decimal julySales = 275000.25m;
//Console.WriteLine("julySales.FormatAsEgyptianCurrency()\t: " + julySales.FormatAsEgyptianCurrency());
//Console.WriteLine("julySales.FormatAsBritishCurrency()\t: " + julySales.FormatAsBritishCurrency());

//DateTime firstApplicantBirthDate = new DateTime(2008, 8, 15);
//Console.WriteLine("firstApplicantBirthDate.IsAllowedHiringBirthDate()\t: " +
//                  firstApplicantBirthDate.IsAllowedHiringBirthDate());

//DateTime secondApplicantBirthDate = new DateTime(2008, 9, 25);
//Console.WriteLine("secondApplicantBirthDate.IsAllowedHiringBirthDate()\t: " +
//                  secondApplicantBirthDate.IsAllowedHiringBirthDate());

//===========================================================================================

#endregion

#region Session 9
using Gem;
//محمود ناصر محمد خليل 
//int firstNo = 18;
//Console.WriteLine("firstNo.ToString()\t\t: " + firstNo.ToString());
//Console.WriteLine("firstNo.GetType()\t\t: " + firstNo.GetType());

//int[] week1Production = { 7, 5, 9, 4, 5 };
//Console.WriteLine("week1Production.ToString()\t: " + week1Production.ToString());

//Car car1 = new Car();
//Console.WriteLine("car1.ToString()\t\t\t: " + car1.ToString());

//Customer customer1 = new()
//{
//    Id = 1001,
//    Name = "Nile Hospitals",
//    Email = "info@NileHospitals.com",
//    Address = "Cairo, 48 Alnasr st.",
//    PhoneNo = "010020030044"
//};

//Console.WriteLine("\n[[[customer1.ToString()]]]");
//Console.WriteLine(customer1.ToString());

//===========================================================================================


//Anonymous Object
//var train1 = new { Model = "MT 17", Classification = "VIP", Coaches = 15 };
//Console.WriteLine($"(((train1)))\nModel\t\t: {train1.Model}\nClassification\t: {train1.Classification}\nCoaches\t\t: {train1.Coaches}");

//Console.WriteLine("\ntrain1.GetType(): " + train1.GetType());


//===========================================================================================


//int city1Population = 920_000;
//city1Population = null;

//Nullable<int> city2Population = 750_000;
//city2Population = null;

//int? city3Population = 830_000;
//city3Population = null;

//===========================================================================================

//WeekDay today = WeekDay.Wednesday;
//Console.WriteLine("\n((((WeekDay enum))))" +
//                  "\ntoday.GetType()\t\t: " + today.GetType() +
//                  "\ntoday\t\t\t: " + today +
//                  "\n(byte)today\t\t: " + (byte)today +
//                  "\nConvert.ToByte(today)\t: " + Convert.ToByte(today) +
//                  "\n(WeekDay)3\t\t: " + (WeekDay)3);

//PrimaryColor writingColor = PrimaryColor.Blue;
//Console.WriteLine("\n((((WritingColor enum))))" +
//                  "\nwritingColor.GetType()\t\t: " + writingColor.GetType() +
//                  "\nwritingColor\t\t\t: " + writingColor +
//                  "\n(int)writingColor\t\t: " + (int)writingColor +
//                  "\nConvert.ToInt32(writingColor)\t: " + Convert.ToInt32(writingColor) +
//                  "\n(PrimaryColor)1\t\t: " + (PrimaryColor)1);

//void Move(Direction direction)
//{
//if (direction == Direction.Left) Console.WriteLine("\u2190");
//else if (direction == Direction.Up) Console.WriteLine("\u2191");
//else if (direction == Direction.Right) Console.WriteLine("\u2192");
//else if (direction == Direction.Down) Console.WriteLine("\u2193");
//}

//Console.Write("\nMove(Direction.Left): ");
//Move(Direction.Left);
//Console.Write("Move(Direction.Up): ");
//Move(Direction.Up);

////enum (enumeration)
//enum WeekDay : byte { Sunday = 1, Monday = 2, Tuesday = 3, Wednesday = 4, Thursday = 5, Friday = 6, Saturday = 7 }
//enum PrimaryColor { Red, Green, Blue }
//enum Direction { Up, Down, Left, Right }
//Exception Handling

//===========================================================================================

////Exampe 2: Required finally
//bool CheckApplicantData()
//{
//    try
//    {
//        //Code to open server connection
//        Console.WriteLine("\nServer connection opened.");

//        Console.Write("Enter your birth year: ");
//        int birthYear = Convert.ToInt32(Console.ReadLine());

//        //Code to send the birth year to server
//        Console.WriteLine("Data sent to server successfully");
//        return true;
//    }
//    catch (FormatException)
//    {
//        Console.WriteLine("Enter a valid numeric birth year.");
//        return false;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//        return false;
//    }
//    finally
//    {
//        //Code to close the server connection
//        Console.WriteLine("Server connection closed.");
//    }
//}

//for (; ; )
//{
//    CheckApplicantData();
//}

//===========================================================================================

//Delegate
//                    Expression-bodied method   Big Arrow / Function Arrow

//string Add(double firstNo, double secondNo) => (firstNo + secondNo).ToString("N2");
//string Subtract(double firstNo, double secondNo) => (firstNo - secondNo).ToString("N2");
//string Multiply(double firstNo, double secondNo) => (firstNo * secondNo).ToString("N2");
//string Divide(double firstNo, double secondNo) => (firstNo / secondNo).ToString("N2");

//double no1 = 10, no2 = 2;
//CalculateTwoNumbers calculateTwoNumbers = Add;
//Console.WriteLine("calculateTwoNumbers(no1, no2) [Add]\t\t: " + calculateTwoNumbers(no1, no2));

//calculateTwoNumbers = Subtract;
//Console.WriteLine("calculateTwoNumbers(no1, no2) [Subtract]\t: " + calculateTwoNumbers(no1, no2));

//calculateTwoNumbers = Multiply;
//Console.WriteLine("calculateTwoNumbers(no1, no2) [Multiply]\t: " + calculateTwoNumbers(no1, no2));

//calculateTwoNumbers = Divide;
//Console.WriteLine("calculateTwoNumbers(no1, no2) [Divide]\t\t: " + calculateTwoNumbers(no1, no2));

//Console.WriteLine("calculateTwoNumbers.GetType()\t\t: " + calculateTwoNumbers.GetType());
////Top-level statements must precede namespace and type declarations.

//delegate string CalculateTwoNumbers(double firstNo, double secondNo);

//===========================================================================================


////                    Expression-bodied method   Big Arrow / Function Arrow
//string Add(double firstNo, double secondNo) => (firstNo + secondNo).ToString("N2");
//string Subtract(double firstNo, double secondNo) => (firstNo - secondNo).ToString("N2");
//string Multiply(double firstNo, double secondNo) => (firstNo * secondNo).ToString("N2");
//string Divide(double firstNo, double secondNo) => (firstNo / secondNo).ToString("N2");

//void CalcAndPrint(double fNo, double sNo, CalculateTwoNumbers calc)
//{
//    Console.WriteLine("calc(fNo, sNo): " + calc(fNo, sNo));
//}

//CalcAndPrint(20, 5, Add);
//CalcAndPrint(20, 5, Subtract);
//CalcAndPrint(20, 5, Multiply);
//CalcAndPrint(20, 5, Divide);

////string Remainder(double firstNo, double secondNo) { return (firstNo % secondNo).ToString("N2"); };
////string Remainder(double firstNo, double secondNo) => (firstNo % secondNo).ToString("N2");
//Console.Write("CalcAndPrint(20, 6, delegate (double firstNo, double secondNo) { return (firstNo % secondNo).ToString(\"N2\"); }): ");
//CalcAndPrint(20, 6, delegate (double firstNo, double secondNo) { return (firstNo % secondNo).ToString("N2"); });

////                      //Lambda Expression        Lambda Arrow (goes to)
//Console.Write("CalcAndPrint(20, 6, (double firstNo, double secondNo) => (firstNo % secondNo).ToString(\"N2\")): ");
//CalcAndPrint(20, 6, (double firstNo, double secondNo) => (firstNo % secondNo).ToString("N2"));

//////Top-level statements must precede namespace and type declarations.
//delegate string CalculateTwoNumbers(double firstNo, double secondNo);

//===========================================================================================

//void GreetMorning(string user) => Console.WriteLine("Good morning, " + user);
//void GreetAfternoon(string user) => Console.WriteLine("Good afternoon, " + user);
//void GreetEvening(string user) => Console.WriteLine("Good evening, " + user);

//Greet greet = GreetMorning;
//greet += GreetAfternoon;
//greet += GreetEvening;

////GreetMorning("Hossam"); GreetAfternoon("Hossam"); GreetEvening("Hossam");
//greet("Hossam");

//Console.WriteLine();
//greet -= GreetAfternoon;

////GreetMorning("Hossam"); GreetEvening("Hossam");
//greet("Hossam");

//delegate void Greet(string user);

//===========================================================================================

#endregion