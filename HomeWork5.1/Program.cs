Console.WriteLine("Enter two numbers.");
Console.Write("1st number: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("2nd number: ");
int n2 = int.Parse(Console.ReadLine());

int nBig = n1 > n2 ? n1 : n2;
int nSmall = n1 < n2 ? n1 : n2;

//1
Console.WriteLine();

for (int i = nSmall; i < nBig; i++)
{
    for (int j = nSmall ; j <= nBig ; j++)
    {
        if ( i == j)
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

//2
Console.WriteLine();

int nSumm = 0;
int nSmallForSumm = nSmall;
int nBigForSumm = nBig;

do
{
    nSumm += nSmallForSumm;
    nSmallForSumm++;

} while (nSmallForSumm <= nBigForSumm );
Console.WriteLine($"Summ: {nSumm}");


//3 [есть ли в последовательности совершенные числа]
Console.WriteLine();

for (int i = nSmall ; i <= nBig ; i++)
{
    int summ = 0;
    int divisor = 1;
    while (divisor < i)
    {
        if (i % divisor == 0)
        {
            summ += divisor;
        }
        divisor++;
    }
    if (summ == i)
    {
        Console.WriteLine($"Perfect Number: {i}");
    }
}