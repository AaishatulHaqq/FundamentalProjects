Console.Write("Enter First Number : ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Second Number : ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Third Number : ");
int number3 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
PrintSum(number1, number2, number3);
PrintAreaAndPerimeterOfCircle();
ReadCompanyInformation();
PrintNumberInVirtualColumns();
GetNumbersDivisibleByFiveInARange();
GetGreaterNumber();
GetSum();
AddNumbers();
PrintFibonacciSequence();

Console.WriteLine("Number 1 : ");
double firstNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number 2 : ");
double secondNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number 3 : ");
double thirdNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number 4 :");
double fourthNo = int.Parse(Console.ReadLine()!);
Console.WriteLine("Number 5 : ");
double fifthNo = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintGreatestNumber(firstNo, secondNo, thirdNo, fourthNo, fifthNo));
GetSumWithPrecision();


int PrintSum(int number1, int number2, int number3)
{
    int sum = number1 + number2 + number3;
    return sum;
}

void PrintAreaAndPerimeterOfCircle()
{
    Console.Write("Enter the radius of the circle : ");
    float radius = float.Parse(Console.ReadLine()!);
    double areaOfCircle = (double) Math.PI * radius * radius;
    double convertTo2Dp = Math.Round(areaOfCircle, 2);
    double perimeterOfCircle = (double) 2 * Math.PI * radius;
    double convertToDp2 = Math.Round(perimeterOfCircle, 2);
    Console.Write($"The area of the circle is {convertTo2Dp} and the perimeter is {convertToDp2}");
    Console.WriteLine();
}

void ReadCompanyInformation()
{
    Console.WriteLine(" Question 3 ");
    Console.Write("Enter Company Name : ");
    string companyName = Console.ReadLine()!;
    Console.Write("Enter address : ");
    string address = Console.ReadLine()!;
    Console.Write("Enter Phone Number : ");
    long phoneNumber = long.Parse(Console.ReadLine()!);
    Console.Write("Enter fax Number : ");
    int faxNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Enter website : ");
    string website = Console.ReadLine()!;
    Console.Write("Enter Manager's First Name : ");
    string managerFirstName = Console.ReadLine()!;
    Console.Write("Enter Manager's Surname : ");
    string managerSurname = Console.ReadLine()!;
    Console.Write("Enter Manager's Phone Number : ");
    long managerPhoneNumber = long.Parse(Console.ReadLine()!); 
    Console.WriteLine($"{companyName} is situated in {address}.For enquiries, call us on {phoneNumber} or send a letter to us through {faxNumber}. For more information about our company, go on {website}. Holding the managerial position is {managerFirstName} {managerSurname} and can be reached through {managerPhoneNumber}");
    Console.WriteLine();
}

void PrintNumberInVirtualColumns()
{
    Console.Write("Enter a Number : ");
    int hexNum = int.Parse(Console.ReadLine()!);
    Console.Write("Enter a fractional number : ");
    double fractNo = double.Parse(Console.ReadLine()!);
    Console.Write("Enter a negative fractional number : ");
    double negativeFractNo = double.Parse(Console.ReadLine()!);
    Console.WriteLine("|{0, -10:x}|", hexNum);
    Console.WriteLine("|{0, -10:f4}|", fractNo);
    Console.WriteLine("|{0, -10:f4}|", negativeFractNo);
    Console.WriteLine();
}

void GetNumbersDivisibleByFiveInARange()
{
    Console.Write("Enter First Number : ");
    int number1 = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Second Number : ");
    int number2 = int.Parse(Console.ReadLine()!);
    for (int i = number1; i <= number2; i++)
    {
        if(i % 5 == 0)
        {
            Console.Write($"{i},");
        }
         }
    Console.WriteLine();
}

void GetGreaterNumber()
{
    Console.Write("Enter First Number : ");
    int firstNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Second Number : ");
    int secondNumber = int.Parse(Console.ReadLine()!);
    int greaterNumber = Math.Max(firstNumber, secondNumber);
    Console.WriteLine($"The greater number is {greaterNumber}");
    Console.WriteLine();
}

void GetSum()
{
    int sum = 0;
    int counter = 0;
    while (counter <= 4)
    {
        Console.Write("Enter A Number : ");
        string input = Console.ReadLine()!;
        int x;
        bool isInteger = int.TryParse(input , out x);
        if (!isInteger)
        {
            counter--;
            Console.Write("Invalid input! ");
        }
       sum += x;
       counter++;
    }
    Console.WriteLine($"The sum of the numbers is :{sum}");
    Console.WriteLine();
}

double PrintGreatestNumber(double firstNo, double secondNo, double thirdNo, double fourthNo, double fifthNo)
{
    double greatestNumber = 0;
    if ((firstNo >= secondNo) && (firstNo >= thirdNo) && (firstNo >= fourthNo) && (firstNo >= fifthNo))
         {
            greatestNumber += firstNo;
         }
         if ((secondNo >= firstNo) && (secondNo >= thirdNo) && (secondNo >= fourthNo) && (secondNo >= fifthNo))
         {
            greatestNumber += secondNo;
         }
         if ((thirdNo >= firstNo) && (thirdNo >= secondNo) && (thirdNo >= fourthNo) && (thirdNo >= fifthNo))
         {
            greatestNumber += thirdNo;
         }
         if ((fourthNo >= firstNo) && (fourthNo >= secondNo) && (fourthNo >= thirdNo) && (fourthNo >= fifthNo))
         {
            greatestNumber += fourthNo;
         }
         if ((fifthNo >= firstNo) && (fifthNo >= secondNo) && (fifthNo >= thirdNo) && (fifthNo >= fourthNo))
         {
            greatestNumber += fifthNo;
         }
         return greatestNumber;
}

void AddNumbers()
{
    Console.Write("Enter An Integer : ");
    int integer = int.Parse(Console.ReadLine()!);
    int counter = 0;
    int sum = 0;
    Console.Write("Enter Number Of Numbers To Be Inputed: ");
    int numberOfNos = int.Parse(Console.ReadLine()!);
    while(counter < numberOfNos)
    {
        Console.Write("Enter An Integer : ");
        int otherIntegers = int.Parse(Console.ReadLine()!);
        sum += otherIntegers;
        counter++;
    }
        sum += integer;
        Console.WriteLine($"The sum all together is = {sum}");
        Console.WriteLine();
}

void PrintFibonacciSequence()
{
    int firstElement = 0;
    int secondElement = 1;
    int thirdElement;
    Console.Write($"{firstElement},");
    Console.Write($"{secondElement},");
    for(int i = 2; i <= 100; i++)
    {
       thirdElement = firstElement + secondElement;
       Console.Write($"{thirdElement},");
       firstElement = secondElement;
       secondElement = thirdElement;
    }
    Console.WriteLine();
}

void GetSumWithPrecision()
{
    Console.Write("Enter Length : ");
    double length = double.Parse(Console.ReadLine()!);
    double sum = 1.0d;
    for(int i = 2; i <= length; i++)
    {
        if (i % 2 == 0)
        {
            sum += (1.0 / i);
        }

        else if (i % 2 != 0)
        {
            sum += ( 1.0 / -i);
        }
    }
    double roundUpTo3DecimalPlaces = (double) Math.Round(sum, 3);
    Console.WriteLine(roundUpTo3DecimalPlaces);
    Console.WriteLine();
}