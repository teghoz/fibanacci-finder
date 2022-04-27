// See https://aka.ms/new-console-template for more information
Console.WriteLine($@"GetFibanacciAtIndex: {GetFibanacciAtIndex(10)}");
Console.WriteLine($@"PrintFibanacciString: {PrintFibanacciString(10)}");
Console.ReadLine();

static int Fibanacci(int index)
{
    if (index < 0) { return 0; }
    if (index == 1) { return 0; }
    if (index == 2) { return 1; }

    return Fibanacci(index - 1) + Fibanacci(index - 2);
}

static int GetFibanacciAtIndex(int index) 
{
    return Fibanacci(index); 
}

static List<int> PrintFibanacciListNumbers(int index)
{
    List<int> numbers = new List<int>();

    if (index < 0) { numbers.Add(0); }
    if (index == 1) { numbers.Add(0); }
    if (index == 2) { numbers.Add(1); }
    numbers.Add(Fibanacci(index));
    return numbers;
}

static string PrintFibanacciString(int index)
{
    List<int> numbers = new List<int>();

    for (int i = 0; i < index; i++)
    {
        if (i <= 0) { numbers.Add(0); }
        if (i == 1) { numbers.Add(1); }

        if(i >= 2)
        {
            var number = (numbers[i - 1] + numbers[i - 2]);
            numbers.Add(number);
        }
    }

    return string.Join(", ", numbers);
}
