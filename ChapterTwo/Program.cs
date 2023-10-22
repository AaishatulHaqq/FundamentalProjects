PrintNumbersWithAppropriateDataType();
AssignAppropriateType();
Console.Write("Enter A Number : ");
double numberA = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Another Number : ");
double numberB = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(CompareTwoRealNumbers(numberA, numberB));
PrintHexadecimalNumber();
AssignValueToACharacter();
ConfirmGender();
ConcatenateTwoStringsAndConvertToObect();
ConcatenateTwoStrings();
PrintHeart();
PrintIsoscelesTriangle();
PrintEmployeeData();
SwapNumbers();

void PrintNumbersWithAppropriateDataType()
{
  sbyte number1 = -123;
  sbyte number2 = -10;
  byte number3 = 52;
  byte number4 = 34;
  byte number5 = 128;
  ushort number6 = 1999;
  ushort number7 = 50000;
  short number8 = -17800;
  ushort number9 = 12380;
  uint number10 = 2341762;
  int number11 = -6540000;
  ulong number12 = 23407003450;
  long number13 = 65282936838719;
          
  Console.Write($"{number1}, {number2}, {number3}, {number4}, {number5}, {number6}, {number7}, {number8}, {number9}, {number10}, {number11}, {number12}, {number13}");
  Console.WriteLine();
} 

void AssignAppropriateType()
{
    float firstNo = 5.0f;
    float secondNo = -5.01f;
    float thirdNo = 12.345f;
    decimal fourthNo = 8923.1234857m;
    double fifthNo = 3456.091124875956542151256683467d;
    Console.Write($"{firstNo}, {secondNo}, {thirdNo}, {fourthNo}, {fifthNo}");
    Console.WriteLine();
}

bool CompareTwoRealNumbers(double number1, double number2)
{
    bool equality = Math.Abs(number1 - number2) < 0.000001;
    return equality;
}

void PrintHexadecimalNumber()
{
    int hexadecimalNumber = 0x100;
    Console.Write(hexadecimalNumber);
    Console.WriteLine();
}

void AssignValueToACharacter()
{
    char character = '\u0072';
    Console.Write(character);
    Console.WriteLine();
}

void ConfirmGender()
{
    bool isMale = false;
    Console.Write(isMale);
    Console.WriteLine();
}

void ConcatenateTwoStringsAndConvertToObect()
{
    string firstString = "Hello ";
    string secondString = "World";
    string concatenation = String.Concat(firstString, secondString);
    object output = concatenation;
    Console.Write(output);
    Console.WriteLine();
}

void ConcatenateTwoStrings()
{
    string firstWord = "Hello ";
    string secondWord = "World";
    object concatenate = String.Concat(firstWord, secondWord);
    string result = concatenate.ToString()!;
    Console.Write(result);
    Console.WriteLine();
}

void PrintHeart()
{
    Console.WriteLine("  0        0 ");
    Console.WriteLine("0   0    0   0");
    Console.WriteLine(" 0   0  0   0");
    Console.WriteLine("  0   00   0");
    Console.WriteLine("   0      0 ");
    Console.WriteLine("    0    0  ");
    Console.WriteLine("     0  0   ");
    Console.WriteLine("      00   ");
    Console.WriteLine();
}

void PrintIsoscelesTriangle()
{
    Console.WriteLine("    © ");
    Console.WriteLine("   © © ");
    Console.WriteLine("  ©   © ");
    Console.WriteLine(" ©     © ");
    Console.WriteLine(" ©©©©©©©© ");
    Console.WriteLine();
}

void PrintEmployeeData()
{
    Console.Write("Enter Your First Name : ");
    string firstName = Console.ReadLine()!;
    Console.WriteLine();
    Console.Write("Enter Your Last Name: ");
    string lastName = Console.ReadLine()!;
    Console.WriteLine();
    Console.Write("Enter Your Age : ");
    byte age = byte.Parse(Console.ReadLine()!);
    Console.WriteLine();
    Console.Write("Gender : ");
    char gender = Convert.ToChar(Console.ReadLine()!);
    Console.WriteLine("Enter Your ID : ");
    int iD = int.Parse(Console.ReadLine()!);
    int initialNo = 27560000;
    for(int i = 0; i <= 27569999; i++)
    {
        iD = i;
        i = initialNo;
     if (iD >= 27560000 && iD <= 27569999)
       {
          Console.Write(iD);
          break;
       }
                    
      initialNo++;
      iD++;
    }
    Console.WriteLine();
}

void SwapNumbers()
{
    int fNo = 5;
    int sNo = 10;
    int oldFNo = fNo;
    fNo = sNo;
    sNo = oldFNo;
    Console.WriteLine($"The First Number is : {fNo}");
    Console.WriteLine($"The second Number is : {sNo}");
}