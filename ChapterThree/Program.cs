CheckNumberIsOddOrEven();
Console.Write("Enter A Number : ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(CheckIntegerIsDivisibleByFiveAndSeven(number));
ConfirmThirdDigitIsSeven();
CheckThirdBitIsZeroOrOne();

Console.Write("Enter a : ");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter b : ");
double b = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter h : ");
double h = double.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(GetAreaOfTrapezoid(a, b, h));
Console.WriteLine();

Console.Write("Enter length : ");
double length = double.Parse(Console.ReadLine()!);
Console.Write("Enter breadth : ");
double breadth = double.Parse(Console.ReadLine()!);
GetAreaAndPerimeterOfARectangle(length, breadth);
CalculateWeightOfManOnMoon();
CheckPointInCircle();
CheckPointInCircleAndOutsideRectangle();
RearrangeFigure();
PrintValueOnPositionP();

Console.Write("Enter v : ");
int v = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.Write("Enter positionP : ");
int positionP = int.Parse(Console.ReadLine()!);
Console.WriteLine(CheckBitOnPositionPIsOne(v, positionP));

Console.Write("Enter nNumber : ");
int nNumber = int.Parse(Console.ReadLine()!);
ChangeValue(nNumber);
CheckPrimeNumbers();

void CheckNumberIsOddOrEven()
{
    Console.Write("Enter An Integer : ");
    int integer = int.Parse(Console.ReadLine()!);
    if(integer % 2 == 0)
    {
       Console.WriteLine("This integer is even!");
    }
    else
    {
      Console.WriteLine("This integer is odd!");
    }
    Console.WriteLine();
}

bool CheckIntegerIsDivisibleByFiveAndSeven(int number)
{
    bool isDivisible = true;
    if (isDivisible && number % (5*7) == 0)
    {
      Console.WriteLine("This number is divisible by 5 and  7");
    }
    else
    {
      Console.WriteLine("This number is not divisible by 5 and 7");
    }
    return isDivisible;
}

void ConfirmThirdDigitIsSeven()
{
    Console.Write("Enter Number : ");
    int figure = int.Parse(Console.ReadLine()!);
    int division = figure / 100;
    int thirdDigit = division % 10;
    if(thirdDigit == 7)
    {
        Console.WriteLine($"The third digit of {figure} is 7");
    }
    else
    {
        Console.WriteLine($"The third digit of {figure} is not 7");
    }
    Console.WriteLine();
}

void CheckThirdBitIsZeroOrOne()
{
    Console.Write("Enter an integer : ");
    int number= int.Parse(Console.ReadLine()!);
    bool thirdBit = (number & 8) != 0;
    Console.WriteLine(thirdBit);
    Console.WriteLine();
}

double GetAreaOfTrapezoid(double a, double b, double h)
{
    double areaOfTrapezoid = (a + b) * h/2;
    return areaOfTrapezoid;
}

void GetAreaAndPerimeterOfARectangle(double length, double breadth)
{
    double perimeter = 2 * (length + breadth);
    double area = length * breadth;
    Console.WriteLine($"The area of the rectangle is {area} and the perimeter is {perimeter}");
}

void CalculateWeightOfManOnMoon()
{
    Console.WriteLine("Question 7 ");
    Console.Write("Enter the weight of a man on earth : ");
    double earthWeight = double.Parse(Console.ReadLine()!);
    double moonWeight = 17d/100 * earthWeight;
    Console.Write($"The weight of the man on the moon is : {moonWeight}");
    Console.WriteLine();
}

void CheckPointInCircle()
{
    Console.Write("Enter x : ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Enter y : ");
    int y = int.Parse(Console.ReadLine()!);
    double result = (x * x) + (y * y);
    double sqrtResult = Math.Sqrt(result);
    if (sqrtResult <= 5)
    {
        Console.WriteLine("It is within the circle");
    }
    else
    {
        Console.WriteLine("It is not within the circle");
    }
    Console.WriteLine();
}

void CheckPointInCircleAndOutsideRectangle()
{
    Console.WriteLine("Enter Value For x1 : ");
    int x1 = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Enter Value For y1 : ");
    int y1 = int.Parse(Console.ReadLine()!);
    Console.Write("Enter x : ");
    int x = int.Parse(Console.ReadLine()!);
    Console.Write("Enter y : ");
    int y = int.Parse(Console.ReadLine()!);
    bool insideOfCircle = (x1 * x1) + (y1 * y1) <= 25;
    bool outOfRectangle = (x < -1 && x > 5) && (y < 1 && y > 5);
    if (insideOfCircle && outOfRectangle) 
    {
        Console.WriteLine("It is within the circle and out of the rectangle");
    }
    else
    {
        Console.WriteLine("It is not within the circle and in the rectangle");
    }
    Console.WriteLine();
}

void RearrangeFigure()
{
    Console.Write("Enter a four digit number: ");
    string figure = Console.ReadLine()!;  
    int first = Convert.ToInt32(figure[0].ToString());
    int second = Convert.ToInt32(figure[1].ToString());
    int third = Convert.ToInt32(figure[2].ToString());
    int fourth = Convert.ToInt32(figure[3].ToString());

    Console.WriteLine($"Calculates the sum of the digits: {first + second + third + fourth}");
    Console.WriteLine($"Prints on the console the number in reversed order: {fourth}{third}{second}{first}");
    Console.WriteLine($"Puts the last digit in the first position: {fourth}{first}{second}{third}");
    Console.WriteLine($"Exchanges the second and the third digit: {first}{third}{second}{fourth}");
    Console.WriteLine();
}

void PrintValueOnPositionP()
{
    Console.Write("Enter n : ");
    int n = int.Parse(Console.ReadLine()!);
    Console.Write("Enter p : ");
    int p = int.Parse(Console.ReadLine()!);
    int counter = 1;
    int shiftLeft = counter << p;
    Console.WriteLine((n & shiftLeft) != 0 ? "Third bit is 1" : "Third bit is 0"); 
    Console.WriteLine();
}

bool CheckBitOnPositionPIsOne(int v, int p)
{
    int shiftToTheLeft = 1 << p;
    bool isOne = (v & shiftToTheLeft) != 0 ? true : false;
    return isOne;
}

void ChangeValue(int number)
{
    int valueV = 0;
    int pPosition = int.Parse(Console.ReadLine()!);
    number = (valueV == 0) ? number = number & (~(1 << pPosition)) : number = number | (1 << pPosition);
    Console.WriteLine(number);
    Console.WriteLine();
}

void CheckPrimeNumbers()
{
    Console.WriteLine(" Question 14 ");
    Console.Write("Enter A Number Between 1 and 100 : ");
    int number = int.Parse(Console.ReadLine()!);
    int numberSquareRoot = (int) Math.Sqrt(number);
    int divisor = 2;
    bool prime = true;
    while (prime && (divisor <= numberSquareRoot))
    {
        if (number % divisor != 0)
        {
             prime = true;
             Console.WriteLine($"{number} is a prime number");
        }
        else
        {
             prime = false;
             Console.WriteLine($"{number} is not a prime number");
        }
        divisor++;
    }
     Console.WriteLine();
}