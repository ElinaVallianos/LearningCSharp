int n1 = 0;
int n2 = 0;
int n3 = 0;

Console.Write("Enter Program's number: ");
n1 = int.Parse(Console.ReadLine());

switch (n1)
{
    case 1:
        Console.WriteLine($"Program {n1}");
        Console.WriteLine (Program1(n1, "First Program"));
        break;
    case 2:
        Console.WriteLine($"Program {n1}");
        Program2(n1, "Second Program");
        break;
    case 3:
        Console.WriteLine($"Program {n1}");
        Program3(n1);
        break;
    case 4:
        Console.WriteLine($"Program {n1}");
        Program4();
        break;
    case 5:
        Console.WriteLine($"Program {n1}");
        n1 = GetIntNumber();
        n2 = GetIntNumber();
        Program5(n1,n2);
        Console.WriteLine("Variant 1: ");
        Program6(n1,n2);
        break;
    default:
        Console.WriteLine($"Program {n1} does not exist");
        break;
}

//функция - именованный блок программы

string Program1(int programNumber , string name)
{
    return $"Program {programNumber}: {name}";
}

void    Program2(int programNumber, string name)
{
    Console.WriteLine($"Program {programNumber}: {name}");
}

void Program3(int number)
{
    switch (number)
    {
        case < 0:
            Console.WriteLine($"{number} < 0");
            break;
        case < 10:
            Console.WriteLine($"{number} < 10");
            break;
        case < 100:
            Console.WriteLine($"{number} < 100");
            break;
        default:
            Console.WriteLine($"{number} out of the range");
            break;
    }

    switch (number)
    {
        case < 0:
        case > 100:
            Console.WriteLine($"{number} out of the range");
            break;
        case < 10:
            Console.WriteLine($"0 < {number} < 10");
            break;
        default:
            Console.WriteLine($"10 < {number} < 100");
            break;
    }
}

void Program4()
{
    Console.WriteLine("Enter Three numbers: ");

    n1 = GetIntNumber();
    n2 = GetIntNumber();
    n3 = GetIntNumber();


    switch (n1)
    {
        case > 0 when n1 < n2 && n2 < n3:
            Console.WriteLine($"{n1} < {n2} < {n3}");
            break;
        case > 0 when n1 < n2 && n2 > n3:
            Console.WriteLine($"{n1} < {n2} > {n3}");
            break;
        case > 0 when n1 > n2 && n2 > n3:
            Console.WriteLine($"{n1} > {n2} > {n3}");
            break;
        case > 0 when n1 > n2 && n2 < n3:
            Console.WriteLine($"{n1} > {n2} < {n3}");
            break;
        default:
            break;
    }
}

int GetIntNumber()
{
    Console.Write("Enter the number: ");
    return int.Parse(Console.ReadLine());
}

void Program5(int nSmall, int nBig)
{
    for (int i = nSmall; i < nBig; i++)
    {
        for (int j = nSmall; j <= nBig; j++)
        {
            if (i == j)
            {
                continue;
            }

            if ((i + j) % 3 == 0)
            {
                int summ = i + j;
                Console.WriteLine($"{i} + {j} = {summ}");
            }
        }
    }

}

void Program6(int number1,int number2)
{
    for (int i = number1; i <= number2; i++)
    {
        for (int j = i + 1; j <= number2; j++)
        {
            if ((i + j) % 3 == 0)
            {
                Console.WriteLine($"{i} + {j} = {i + j}");

            }
        }
    }
    Console.WriteLine("Variant 2:");
    for (int i = number1; i <= number2; i++)
    {
        for (int j = number2; j > i; j--)
        {
            int sum = i + j;
            if (sum % 3 == 0)
            {
                Console.WriteLine($"{i} + {j} = {sum}");

            }
        }
    }
}

bool isPerfectNumber( int n)
{
    int sum = 0;
    return true;
}