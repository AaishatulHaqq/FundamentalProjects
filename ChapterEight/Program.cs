ConvertToBinary();
ConvertToDecimalAndHexadecimal();
ConvertDecimalToBinary();
ConvertBinaryToDecimal();
ConvertDecimalToHexadecimal();
ConvertHexadecimalToDecimal();
ConvertHexadecimalToBinary();
ConvertHexadecimalToBinaryAndDecimal();
ConvertBinaryToHexadecimal();
ConvertBinaryToDecimalWithHornerScheme();
ConvertRomanDigitsToArabic();

void ConvertToBinary()
{
    int firstNumber = 151;
    string decimalNumber1 = firstNumber.ToString();
    int binaryValue1 = Convert.ToInt32(decimalNumber1, 10);
    string convertToBinary1 = Convert.ToString(binaryValue1, 2);
    Console.WriteLine($"The equivalent Binary Value of {firstNumber} is : {convertToBinary1}");
    int secondNumber = 35;
    string decimalNumber2 = secondNumber.ToString();
    int binaryValue2 = Convert.ToInt32(decimalNumber2, 10);
    string convertToBinary2 = Convert.ToString(binaryValue2, 2);
    Console.WriteLine($"The equivalent Binary Value of {secondNumber} is : {convertToBinary2}");
    int thirdNumber = 43;
    string decimalNumber3 = thirdNumber.ToString();
    int binaryValue3 = Convert.ToInt32(decimalNumber3, 10);
    string convertToBinary3 = Convert.ToString(binaryValue3, 2);
    Console.WriteLine($"The equivalent Binary Value of {thirdNumber} is : {convertToBinary3}");
    int fourthNumber = 251;
    string decimalNumber4 = fourthNumber.ToString();
    int binaryValue4 = Convert.ToInt32(decimalNumber4, 10);
    string convertToBinary4 = Convert.ToString(binaryValue4, 2);
    Console.WriteLine($"The equivalent Binary Value of {fourthNumber} is : {convertToBinary4}");
    int fifthNumber = 1023;
    string decimalNumber5 = fifthNumber.ToString();
    int binaryValue5 = Convert.ToInt32(decimalNumber5, 10);
    string convertToBinary5 = Convert.ToString(binaryValue5, 2);
    Console.WriteLine($"The equivalent Binary Value of {fifthNumber} is : {convertToBinary5}");
    int sixthNumber = 1024;
    string decimalNumber6 = sixthNumber.ToString();
    int binaryValue6 = Convert.ToInt32(decimalNumber6, 10);
    string convertToBinary6 = Convert.ToString(binaryValue6, 2);
    Console.WriteLine($"The equivalent Binary Value of {sixthNumber} is : {convertToBinary6}");
    Console.WriteLine();
}

void ConvertToDecimalAndHexadecimal()
{
    long binaryNumber = 1111010110011110;
    string numberInBinary = binaryNumber.ToString();
    long inBinary =  Convert.ToInt64(numberInBinary, 2);
    string toDecimal = Convert.ToString(inBinary, 10);
    string hexadecimalString = Convert.ToString(Convert.ToInt32(numberInBinary, 2), 16);
    Console.WriteLine($"1111010110011110 to decimal is {toDecimal} and to hexadecimal is {hexadecimalString}");
}

void ConvertHexadecimalToBinaryAndDecimal()
{
    string[] hexadecimalNumbers = { "FA", "2A3E", "FFFF", "5A0E9" };
    foreach (string hexadecimalNumber in hexadecimalNumbers)
    {
        int decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
        string binaryNumber = Convert.ToString(decimalNumber, 2);
        Console.WriteLine($"{hexadecimalNumber} in hexadecimal is {decimalNumber} in decimal and {binaryNumber} in binary.");
    }
    Console.WriteLine();
}

void ConvertDecimalToBinary()
{
    Console.Write("Enter A Decimal Number : ");
    string decimalNumber = Console.ReadLine()!;
    int binaryValue = Convert.ToInt32(decimalNumber, 10);
    string binaryConvert = Convert.ToString(binaryValue, 2);
    Console.WriteLine($"It's equivalent Binary Value is : {binaryConvert}");
    Console.WriteLine();
}

void ConvertBinaryToDecimal()
{
    Console.Write("Enter A Binary Number : ");
    string binaryNumber = Console.ReadLine()!;
    int decimalValue = Convert.ToInt32(binaryNumber, 2);
    Console.WriteLine($"Its Decimal Number is equivalent to : {decimalValue}");
    Console.WriteLine();
}

void ConvertDecimalToHexadecimal()
{
    int decimalNumber = int.Parse(Console.ReadLine()!);
    string hexadecimalString = Convert.ToString(decimalNumber, 16);
    Console.WriteLine(hexadecimalString);
}

void ConvertHexadecimalToDecimal()
{
   string hexadecimalNumber = Console.ReadLine()!;
   int decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
   Console.WriteLine(decimalNumber);
}

void ConvertHexadecimalToBinary()
{
    string hexadecimalNumber = Console.ReadLine()!;
    int decimalNumber = Convert.ToInt32(hexadecimalNumber, 16);
    string binaryNumber = Convert.ToString(decimalNumber, 2);
    Console.WriteLine(binaryNumber);
    Console.WriteLine();
}

void ConvertBinaryToHexadecimal()
{
    string binaryNumber = Console.ReadLine()!;
    int decimalNumber = Convert.ToInt32(binaryNumber, 2);
    string hexadecimalNumber = Convert.ToString(decimalNumber, 16);
    Console.WriteLine($"The conversion of {binaryNumber} in binary is {hexadecimalNumber} in hexadecimal");
    Console.WriteLine();
}

void ConvertBinaryToDecimalWithHornerScheme()
{
    string binaryNumber = Console.ReadLine()!;
    int decimalNumber = 0;
    for (int i = binaryNumber.Length - 1; i >= 0; i--)
    {
        decimalNumber += decimalNumber * 2 + (binaryNumber[i] - '0');
    }
    Console.WriteLine(decimalNumber);
    Console.WriteLine();
}

void ConvertRomanDigitsToArabic()
{
    string romanNumber = "MCMXCIV";
    int arabicNumber = 0;
    for (int i = 0; i < romanNumber.Length; i++)
    {
        switch (romanNumber[i])
        {
            case 'M':
                arabicNumber += 1000;
                break;
            case 'D':
                arabicNumber += 500;
                break;
            case 'C':
                arabicNumber += 100;
                break;
            case 'L':
                arabicNumber += 50;
                break;
            case 'X':
                arabicNumber += 10;
                break;
            case 'V':
                arabicNumber += 5;
                break;
            case 'I':
                arabicNumber += 1;
                break;
        }
    }
    
    Console.WriteLine(arabicNumber);    
}