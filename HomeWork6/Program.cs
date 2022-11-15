

while(true)
{
    Console.Write("Enter Program's number: ");
    string n1 = Console.ReadLine();

    if (n1 == "q" || n1 == "Q")
    {
        break;
    }


    switch (n1)
    {
        case "1":
            Console.WriteLine($"Task {n1}");
            Console.Write($"Enter first number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write($"Enter second number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{Task1(start,number)}");
            break;
        case "2":
            Console.WriteLine($"Task {n1}");
            Console.Write($"Enter number: ");
            int numberPiramid = int.Parse(Console.ReadLine());
            Task2(numberPiramid);
            break;
        case "3":
            Console.WriteLine($"Task {n1}");
            Console.Write($"Enter number: ");
            int starNumber = int.Parse(Console.ReadLine());
            Task3(starNumber);
            break;
        case "4":
            Console.WriteLine($"Task {n1}");
            Console.Write($"Enter number: ");
            int LineNumber = int.Parse(Console.ReadLine());
            Task4(LineNumber);
            break;
        default:
            Console.WriteLine($"Program {n1} does not exist");
            break;
    }
}
Console.WriteLine("This is the End of the Program. Bye!!!");




int Task1(int start , int number)
{
    int sum = 0;
    for (int i = start; number > 0; i++)
    {
        if (i % 3 == 0 && i % 2 != 0)
        {
            Console.Write($"{i} ");
            number--;
            sum += i;
        }
    }
    return sum;
}

void Task2(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1; j <= i; j++)
        {
            Console.Write($"{j}");
        }
        Console.WriteLine();
    }
}

void Task3(int number)
{
    for (int i = 1; i <= number; i++)
    {
        for (int j = 1 ; j <= (number - i) ; j++)
        {
            Console.Write($" ");
        }
        for (int k = 1; k <= i; k++)
        {
            Console.Write($"* ");
        }
        Console.WriteLine();
    }
}

void Task4(int number)
{
    int count = 0;
    int i = 1;
    while (count < number)
    {
        if (i % 2 == 0)
        {
            i++;
            continue;
        }

        for (int j = 1; j <= (number - i + count); j++)
        {
            Console.Write($" ");
        }

        for (int k = 1; k <= i; k++)
        {
            Console.Write($"*");
        }
        count++;
        i++;
        Console.WriteLine();

    }
}