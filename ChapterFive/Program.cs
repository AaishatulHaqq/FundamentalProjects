ExchangeIntegers();

Console.Write("Enter First Number : ");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Second Number : ");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Third Number : ");
int number3 = int.Parse(Console.ReadLine()!);
GetProduct(number1, number2, number3);

Console.Write("Enter First Integer : ");
int firstInteger = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Second Integer : ");
int secondInteger = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter Third Integer : ");
int thirdInteger = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(FindBiggest(firstInteger, secondInteger, thirdInteger));
SortDescending();

Console.Write("Enter digit : ");
int digit = int.Parse(Console.ReadLine()!);
ShowDigitAsWord(digit);

Console.Write("Input the value of a : ");
int a =int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Input the value of b : ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Input the value of c : ");
int c = int.Parse(Console.ReadLine()!);
GetCoefficients(a, b, c);

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
ChooseVariable();
FindSubsetWithSumZero();

Console.Write("Enter score : ");
int score = int.Parse(Console.ReadLine()!);
PrintTotalScore(score);

void ExchangeIntegers()
{
    Console.Write("Enter First Number : ");
    int firstNumber = int.Parse(Console.ReadLine()!);
    int oldFirstNumber = firstNumber;
    Console.Write("Enter Second Number : ");
    int secondNumber = int.Parse(Console.ReadLine()!);
    if (firstNumber > secondNumber)
    {
        firstNumber = secondNumber;
        secondNumber = oldFirstNumber;
        Console.Write($"The new value of the first number is {firstNumber} and the new value of the second number is {secondNumber}");
    }
    Console.WriteLine();
}

void GetProduct(int number1, int number2, int number3)
{
    if (number1 * number2 * number3 < 0)
    {
        Console.WriteLine("-");
    }
    if (number1 * number2 * number3 == 0)
    {
        Console.WriteLine("0");
    }
    if (number1 * number2 * number3 > 0)
    {
        Console.WriteLine("+");
    }
    Console.WriteLine();
}

int FindBiggest(int firstInteger, int secondInteger, int thirdInteger)
{
    int biggest;
    if (firstInteger > secondInteger && firstInteger > thirdInteger)
    {
        biggest = firstInteger;
    }
    else
    {
        if (secondInteger > firstInteger && secondInteger > thirdInteger)
        {
            biggest = secondInteger;
        }
        else
        {
            biggest = thirdInteger;
        }
    }
    return biggest;
}

void SortDescending()
{
    Console.Write("Enter First Real Number : ");
    int firstRealNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Second Real Number : ");
    int secondRealNumber = int.Parse(Console.ReadLine()!);
    Console.Write("Enter Third Real Number : ");
    int thirdRealNumber = int.Parse(Console.ReadLine()!);
    if (firstRealNumber > secondRealNumber && firstRealNumber > thirdRealNumber)
    {
        if (secondRealNumber > thirdRealNumber)
        {
            Console.Write($"The numbers in descending order is {firstRealNumber}, {secondRealNumber}, {thirdRealNumber}");
        }
        else
        {
            Console.Write($"The numbers in descending order is {firstRealNumber}, {thirdRealNumber}, {secondRealNumber}");
        }
    }
    else
    {
        if (secondRealNumber > firstRealNumber && secondRealNumber > thirdRealNumber)
        {
            if (firstRealNumber > thirdRealNumber)
            {
                Console.Write($"The numbers in descending order is {secondRealNumber}, {firstRealNumber}, {thirdRealNumber}");
            }
        else
        {
            Console.Write($"The numbers in descending order is {secondRealNumber}, {thirdRealNumber}, {firstRealNumber}");
        }
        } 
       if (thirdRealNumber > secondRealNumber && thirdRealNumber > firstRealNumber)
       {
          if (secondRealNumber > firstRealNumber)
          {
              Console.Write($"The numbers in descending order is {thirdRealNumber}, {secondRealNumber}, {firstRealNumber}");
          }
          else
          {
              Console.Write($"The numbers in descending order is {thirdRealNumber}, {firstRealNumber}, {secondRealNumber}");
          }
       }
    }
    Console.WriteLine();
}

void ShowDigitAsWord(int digit)
{
   var result = digit switch
    {
        0 => "Zero",
        1 => "One",
        2 => "Two",
        3 => "Three",
        4 => "Four",
        5 => "Five",
        6 => "Six",
        7 => "Seven",
        8 => "Eight",
        9 => "Nine",
        _ => "Invalid Input",   
    };
    Console.WriteLine(result);
    Console.WriteLine();
}

void GetCoefficients(int a, int b, int c)
{
    double discriminant = b * b - 4 * a * c;
    double firstRoot;
    double secondRoot;
    if (discriminant == 0)
    {
        Console.WriteLine("Both roots are equal");
        firstRoot = -b / (2 * a);
        secondRoot = firstRoot;
        Console.WriteLine($"First  Root = {firstRoot}");
        Console.WriteLine($"Second Root = {secondRoot}");
    }
    else if (discriminant > 0)
	{
	    Console.WriteLine("Both roots are real and different");
        firstRoot = (-b + Math.Sqrt(discriminant)) / (2 * a);
	    secondRoot = (-b - Math.Sqrt(discriminant)) / (2 * a);
        Console.WriteLine($"First  Root = {firstRoot}");
	    Console.WriteLine($"Second Root = {secondRoot}");
	}
	else
    {
	    Console.Write("Roots are imaginary");
    }
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

void ChooseVariable()
{
    Console.Write("Enter 1 for int, 2 for double and 3 for string \nEnter Number : ");
    int variable = int.Parse(Console.ReadLine()!);
          
          switch (variable)
         {
           case 1 :
           Console.Write("Enter Input For Variable int : ");
           int intVariable = int.Parse(Console.ReadLine()!);
           Console.WriteLine(++intVariable);
           break;
           case 2 :
           Console.WriteLine("Enter Input For Variable double : ");
           double doubleVariable = double.Parse(Console.ReadLine()!);
           Console.WriteLine(++doubleVariable);
           break;
           case 3 :
           Console.Write("Enter Input For Variable string : ");
           string stringVariable = Console.ReadLine()!;
           Console.WriteLine($"{stringVariable}*");
           break;
           default :
           Console.WriteLine("Invalid variable!");
           break;
         }
         Console.WriteLine();
}

void FindSubsetWithSumZero()
{
        Console.Write("Enter First Number : ");
         int num1 = int.Parse(Console.ReadLine()!);
         Console.Write("Enter Second Number : ");
         int num2 = int.Parse(Console.ReadLine()!);
         Console.Write("Enter Third Number : ");
         int num3 = int.Parse(Console.ReadLine()!);
         Console.Write("Enter Fourth Number : ");
         int num4 = int.Parse(Console.ReadLine()!);
         Console.Write("Enter Fifth Number : ");
         int num5 = int.Parse(Console.ReadLine()!);
         if (num1 + num2 == 0)
         {
            Console.WriteLine($"{num1 + num2}");
         }
         if (num1 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num3}"); 
         }
         if (num1 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num4}");
         }
         if (num1 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num5}");
         }
         if (num2 + num3 == 0)
         {
            Console.WriteLine($"{num2 + num3}");
         }
         if (num2 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num4}");
         }
         if (num2 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num5}");
         }
         if (num3 + num4 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if (num3 + num5 == 0)
         {
            Console.WriteLine($"{num3 + num5}");
         }
         if (num4 + num5 == 0)
         {
            Console.WriteLine($"{num4 + num5}");
         }
         if (num1 + num2 + num3 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num3}");
         }
         if (num1 + num2 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num4}");
         }
         if (num1 + num2 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num2 + num5}");
         }
         if (num1 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num4}");
         }
         if (num1 + num3 + num5 == 0)
         {
            Console.WriteLine($"{num1 + num3 + num5}");
         }
         if (num2 + num3 + num4 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         if (num2 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num4 + num5}");
         }
         if (num3 + num4 + num5 == 0)
         {
            Console.WriteLine($"{num2 + num3 + num4}");
         }
         Console.WriteLine();
}

void PrintTotalScore(int score)
{
    var result = score switch 
         {
            1 => $"The final score is {score * 10}",
            2 => $"The final score is {score * 10}",
            3 => $"The final score is {score * 10}",
            4 => $"The final score is {score * 100}",
            5 => $"The final score is {score * 100}",
            6 => $"The final score is {score * 100}",
            7 => $"The final score is {score * 1000}",
            8 => $"The final score is {score * 1000}",
            9 => $"The final score is {score * 1000}",
            _ => "It's either you failed or an invalid score has been inputed",
        };
         Console.WriteLine(result);
}



