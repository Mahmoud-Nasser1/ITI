

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
string CalculatePrice(decimal cost, decimal profitRatio) => (cost + cost * profitRatio / 100).ToString("C2");
void GreetVisitor() => Console.WriteLine("Welcome to Pearly Soft!");

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