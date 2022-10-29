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

int nBig;
int nSmall;
int nMedium;
if (n1 == n2 || n1 == n3 || n2 == n3)
{
    if (n1 == n2 && n2 == n3)
    {
        Console.WriteLine($"{n1} = {n2} = {n3}");
        nBig = n1;
        nMedium = nBig;
        nSmall = nBig;
    }
    else
    {
        if (n1 == n2)
        {
            if (n1 > n3)
            {
                Console.WriteLine($"{n3} < {n2} = {n1}");
                nBig = n1;
                nSmall = n3;
                nMedium = nBig;
            }
            else
            {
                Console.WriteLine($"{n2} = {n1} < {n3}");
                nBig = n3;
                nMedium = nBig;
                nSmall = n2;
            }
        }
        else
        {
            if (n1 == n3)
            {
                if (n2 > n1)
                {
                    Console.WriteLine($"{n1} = {n3} < {n2}");
                    nBig = n2;
                    nMedium = nBig;
                    nSmall = n1;
                }
                else
                {
                    Console.WriteLine($"{n2} < {n3} = {n1}");
                    nBig = n1;
                    nMedium = nBig;
                    nSmall = n2;
                }
            }
            else
            {
                if (n1 > n2)
                {
                    Console.WriteLine($"{n2} = {n3} < {n1}");
                    nBig = n1;
                    nMedium = nBig;
                    nSmall = n2;
                }
                else
                {
                    Console.WriteLine($"{n1} < {n3} = {n2}");
                    nBig = n2;
                    nMedium = nBig;
                    nSmall = n1;
                }
            }
        }
    }
}
else
{
    nBig = n1 > n2 ? n1 : n2;
    nBig = nBig > n3 ? nBig : n3;
    nSmall = n1 > n2 ? n2 : n1;
    nSmall = n3 > nSmall ? nSmall : n3;
    nMedium = n1;
    nMedium = (nMedium == nBig || nMedium == nSmall) ? n2 : nMedium;
    nMedium = (nMedium == nSmall || nMedium == nBig) ? n3 : nMedium;

    Console.WriteLine($"{nSmall} < {nMedium} < {nBig}");
}




int count = nSmall;
while (count < nMedium )
{
    Console.Write($"{count}, ");
    count++;
}
Console.Write($"{count}\n");

count = nBig;
while (count > nMedium)
{
    Console.Write($"{count}, ");
    count--;
}
Console.Write($"{count}\n");

count = nSmall;
int counterNumbers = 0;
while (count <= nMedium)
{
    if ((count % 2 == 0) && ( count % 4 != 0))
    {
        counterNumbers++;
    }
    count++;
}
Console.WriteLine(counterNumbers);


count = nSmall;
int Summ = 0;
while (count <= nBig)
{
    if ((count % 3 == 0) ^ (count % 7 == 0))
    {
        Summ = Summ + count;
    }
    count++;
}
Console.WriteLine(Summ);