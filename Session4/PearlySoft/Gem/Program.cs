
Console.WriteLine("Hello, World!");
Console.Write("Enter your full name: ");
string fullName = Console.ReadLine(); // Enter
//1. String Concatenation
Console.WriteLine("Hi, " + fullName + "!");

//2. String Interpolation
Console.WriteLine($"Hi, {fullName}!");

//Escape Sequences
Console.WriteLine("Egypt\nKuwait\nOman"); // new line
Console.WriteLine("Egypt\tKuwait\tOman"); // tab

// tab -> Tabular Formatting
Console.WriteLine("Id\tName\tAge\n1\tAhmed\t37\n2\tOmar\t29\n3\tMostafa\t42");
Console.WriteLine("Ahmed said: \"Good morning\""); //Ahmed said: "Good morning"
Console.WriteLine("\\");
Console.WriteLine("\u2190");
Console.WriteLine("\u2191");
Console.WriteLine("\u2192");
Console.WriteLine("\u2193");

Console.WriteLine("K:\\Projects\\Reports\\JulyReport.pdf");

//3. Verbatim String
Console.WriteLine(@"K:\Projects\Reports\JulyReport.pdf");

//4. Raw String
string rawStringPath = """
    K:\Projects\Reports\JulyReport.pdf
    """;
Console.WriteLine("rawStringPath: " + rawStringPath);

//==============================================================================


while (true)
{
    Console.Write("\nEnter your score: ");
    float score = Convert.ToSingle(Console.ReadLine());

    if (score >= 95)
    {
        Console.WriteLine("Excellence Gift: 5000 EGP.");
    }

    if (score >= 50)
    {
        Console.WriteLine("Passed");
    }
    else
    {
        Console.WriteLine("Failed");
    }
}
//==============================================================================


//UTC -> Universal Time Coordinate -> GMT
Console.WriteLine("DateTime.UtcNow\t\t: " + DateTime.UtcNow);
Console.WriteLine("DateTime.Now\t\t: " + DateTime.Now);
Console.WriteLine("DateTime.Now.Hour\t: " + DateTime.Now.Hour);

//int currentHour = DateTime.Now.Hour;
for (int i = 0; i < 10; i++)
{
    Console.Write("\nEnter current hour: ");
    int currentHour = Convert.ToInt32(Console.ReadLine());
    if (currentHour >= 5 && currentHour < 13)
    {
        Console.WriteLine("Good morning!");
    }
    else if (currentHour >= 13 && currentHour < 20)
    {
        Console.WriteLine("Good afternoon!");
    }
    else
    {
        Console.WriteLine("Good evening!");
    }
}

//==============================================================================

// Ternary Conditional Operator ?:
for (; ; )
{
    Console.Write("\nEnter your score: ");
    float score = Convert.ToSingle(Console.ReadLine());

    string studentStatus = score >= 50 ? "Passed" : "Failed";

    Console.WriteLine("studentStatus: " + studentStatus);

    string studentGrade = score >= 90 ? "Perfect" :
                          score >= 80 ? "Very Good" :
                          score >= 65 ? "Good" :
                          score >= 50 ? "Passed" :
                          score >= 40 ? "Poor" : "Very Poor";

    Console.WriteLine("studentGrade: " + studentGrade);
}

//==============================================================================


DateTime hiringDateTime = new DateTime(1995, 12, 23, 20, 35, 49);

Console.WriteLine(nameof(hiringDateTime) + "\t\t\t: " + hiringDateTime);
Console.WriteLine(nameof(hiringDateTime) + ".ToString()\t\t: " + hiringDateTime.ToString());
Console.WriteLine(nameof(hiringDateTime) + ".ToLongDateString()\t: " + hiringDateTime.ToLongDateString());
Console.WriteLine(nameof(hiringDateTime) + ".ToShortDateString()\t: " + hiringDateTime.ToShortDateString());
Console.WriteLine(nameof(hiringDateTime) + ".ToLongTimeString()\t: " + hiringDateTime.ToLongTimeString());
Console.WriteLine(nameof(hiringDateTime) + ".ToShortTimeString()\t: " + hiringDateTime.ToShortTimeString());