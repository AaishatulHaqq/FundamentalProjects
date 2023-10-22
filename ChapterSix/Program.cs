/*Write a program that calculates N!/K! for given N and K (1<K<N).*/

Console.Write("Enter N: ");
int nNumber = int.Parse(Console.ReadLine()!);
Console.WriteLine(PrintNumber(nNumber));

Console.Write("Enter N: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetNumberNotDivisibleByFiveAndSeven(number));

Console.Write("Enter The Numbers Of Integers To Be Inputed : ");
int noOfIntegers = int.Parse(Console.ReadLine()!); 
Console.WriteLine(PrintSmallestAndLargestIntegers(noOfIntegers));

PrintAllCards();
PrintFibonacciNumbers();

Console.WriteLine("Enter the value of N:");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Enter the value of K:");
int k = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetFactorial(n, k));
Console.WriteLine(CalculateFactorialNK(n, k));

Console.WriteLine("Enter the value of N:");
int nNo = int.Parse(Console.ReadLine()!);
Console.WriteLine(GetCatalanNumber(nNo));

int PrintNumber(int number)
{
    for(int i = 1; i <= number; i++)
    {
       Console.WriteLine($"{i} ");
    }
    return number;
}

int GetNumberNotDivisibleByFiveAndSeven(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if (i % (3 * 7) != 0)
        {
            Console.Write($"{i} ");
        }
    }
     return n;
}

int PrintSmallestAndLargestIntegers(int noOfIntegers)
{
    int smallest = 0;
    int largest = 0;
    for (int i = 0; i < noOfIntegers; i++)
    {
       Console.Write("Enter Number : ");
       int inputNumbers = int.Parse(Console.ReadLine()!);
      if (i == 0) 
      {
         smallest = largest = inputNumbers;
      }
     else
      {
         if (smallest > inputNumbers) 
         {
            smallest = inputNumbers;
         }
        if (largest < inputNumbers) 
        {
            largest = inputNumbers;
        }           
      }                
    }
     Console.WriteLine($"The smallest integer is {smallest} and the largest is {largest}");
     return noOfIntegers;
 }
 
 void PrintAllCards()
    {
        string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
        string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                Console.WriteLine($"{value} of {suit}");
            }
        }
    }

void PrintFibonacciNumbers()
{
     int firstNumber = 0;
     int secondNumber = 1;
     Console.Write("Enter Number : ");
     int fibonacciNumber = int.Parse(Console.ReadLine()!);
     Console.Write($" {firstNumber}, {secondNumber},");
     int sum = 1;

     for (int i = 2; i < fibonacciNumber; i++)
     {
        int thirdNumber = firstNumber + secondNumber;
        Console.Write($"{thirdNumber}, ");
        firstNumber = secondNumber;
        secondNumber = thirdNumber;
        sum += thirdNumber;
    }
    Console.WriteLine($"The sum is : {sum}");
}

int GetFactorial(int n, int k)
{
    if (k > n)
        {
            throw new ArgumentException("K must be less than or equal to N.");
        }
    
        int nFactorial = 1;
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
        }
        int kFactorial = 1;
        for (int i = 1; i <= k; i++)
        {
            kFactorial *= i;
        }
       int result = nFactorial / kFactorial;

    return result;
}
    
int CalculateFactorialNK(int n, int k)
{
    if (k > n)
    {
        throw new ArgumentException("K must be less than or equal to N.");
    }

    int nFactorial = 1;

    for (int i = 1; i <= n; i++)
    {
        nFactorial *= i;
    }

    int kFactorial = 1;

    for (int i = 1; i <= k; i++)
    {
            kFactorial *= i;
    }
    int nkFactorial = 1;
    for (int i = 1; i <= n - k; i++)
    {
        nkFactorial *= i;
    }
    
    int result = nFactorial * kFactorial / nkFactorial;
    return result;
}

 int GetCatalanNumber(int n)
{
    
    if (n < 0)
    {
        throw new ArgumentException("n must be non-negative.");
    }
   
    int numerator = 1;
    for (int i = 1; i <= 2 * n; i++)
    {
        numerator *= i;
    }

    int denominator = 1;
    for (int i = 1; i <= n + 1; i++)
    {
        denominator *= i;
    }

    int catalanNumber = numerator / denominator;
    return catalanNumber;
}

