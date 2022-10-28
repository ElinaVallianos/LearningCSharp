Console.WriteLine("Enter three numbers.");
Console.Write("1st number: ");
int n1 = int.Parse(Console.ReadLine());
Console.Write("2nd number: ");
int n2 = int.Parse(Console.ReadLine());
Console.Write("3th number: ");
int n3 = int.Parse(Console.ReadLine());

bool NUMBER = true;
NUMBER = n2 < n1 && n1 < n3;
Console.WriteLine(NUMBER);

int nBig = n1 > n2 ? n1 : n2;
nBig = nBig > n3 ? nBig : n3;
int nSmall = n1 > n2 ? n2 : n1;
nSmall = n3 > nSmall ? nSmall : n3;
int nMedium = n1;
nMedium = (nMedium == nBig || nMedium == nSmall) ? n2 : nMedium;
nMedium = (nMedium == nSmall || nMedium == nBig) ? n3 : nMedium;

Console.WriteLine($"{nSmall} < {nMedium} < {nBig}");


int count = nSmall;
while (count < nMedium )
{
    Console.Write($"{count}, ");
    ++count;
}
Console.Write($"{count}\n");

count = nBig;
while (count > nMedium)
{
    Console.Write($"{count}, ");
    count = count - 1;
}
Console.Write($"{count}\n ");

count = nSmall + 1;
int counterNumbers = 0;
while (count < nMedium)
{
    if ((count % 2 == 0) && ( count % 4 != 0))
    {
        ++counterNumbers;
    }
    ++count;
}
Console.Write($"{counterNumbers}\n ");


count = nSmall + 1;
int Summ = 0;
while (count < nBig)
{
    if ((count % 3 == 0) ^ (count % 7 == 0))
    {
        Summ = Summ + count;
    }
    ++count;
}
Console.Write($"{Summ}\n ");