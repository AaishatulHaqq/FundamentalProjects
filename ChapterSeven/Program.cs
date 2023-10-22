PrintArrayOfNumbers();
CompareTwoArrays();
CompareArrayLexicographically();

void PrintArrayOfNumbers()
{
    int[] myArray = new int[20];
    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = i * 5;
    }

    foreach (int element in myArray)
    {
       Console.WriteLine(element);
    }
    Console.WriteLine();
}

void CompareTwoArrays()
{
    Console.Write("Enter Length Of The First Array : ");
    int firstArrayLength = int.Parse(Console.ReadLine()!);
    int [] firstArrayIntegers = new int [firstArrayLength];
    int p;
    for(p = 0; p < firstArrayLength; p++)   
    {
        Console.Write("Enter Element[{0}] = ", p);
        firstArrayIntegers[p] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
    Console.WriteLine("******************");
    Console.Write("Enter Length Of Second Array : ");
    int secondArrayLength = int.Parse(Console.ReadLine()!);
    int [] secondArrayIntegers = new int [secondArrayLength];
    int q;
    for(q = 0; q < secondArrayLength; q++)
    {
        Console.Write("Enter Element[{0}] = ", q);
        secondArrayIntegers[q] = int.Parse(Console.ReadLine()!);
    }
    Console.WriteLine();
           
    if(firstArrayLength == secondArrayLength)
    {
        if(firstArrayIntegers[p] == secondArrayIntegers[q])
        {
            Console.WriteLine("The two arrays are equal");
        }
        if(firstArrayIntegers[p] != secondArrayIntegers[q])
        {
            Console.WriteLine("The two arrays are not equal");
        }
    }
        else
        {
            Console.WriteLine("The two arrays are not equal");
        }
    Console.WriteLine();
}

void CompareArrayLexicographically()
{
    char [] alphabets1 = new char [9] {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I'};
    char [] alphabets2 = new char [10] {'Z', 'Y', 'X', 'W', 'V', 'U', 'T', 'S', 'R', 'Q'};
    bool alphabetsEqual = false;
    if (alphabets1.Length < alphabets2.Length)
    {
        Console.WriteLine("First array is lexicographically first.");
    }

    else if (alphabets1.Length > alphabets2.Length)
    {
        Console.WriteLine("Second array is lexicographically first.");
    }
    else
    {
        for (int i = 0; i < alphabets1.Length; i++)
        {
            if (alphabets1[i] < alphabets2[i])
            {
                Console.WriteLine("First array is lexicographically first.");
                alphabetsEqual = false;
                break;
            }
            if (alphabets1[i] > alphabets2[i])
            {
                Console.WriteLine("Second array is lexicographically first.");
                alphabetsEqual = false;
                break;
            }
        }
        if (!alphabetsEqual)
        {
            Console.WriteLine("Arrays are lexicographicaly equal.");
        }
    }
    Console.WriteLine();
}