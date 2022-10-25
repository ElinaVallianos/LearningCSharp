int a = 0;
int b = 1;

int c = a++ + ++b;

const int Today = 25;

//Today = 0:


Console.WriteLine($" c = {c}, a = {a}, b = {b}"); //a =1

c = a++ + a;

Console.WriteLine($" c = {c}, a = {a}"); //a =2 , c = 3
Console.WriteLine($" a = {a++}, a = {++a}"); //a =2 , a = 4


//Логические операторы
bool isTrue = true;
bool isFalse = false;

//not
Console.WriteLine("\noperator not");
Console.WriteLine($"!true = {!isTrue}");
Console.WriteLine($"!false = {!isFalse}");

//and
Console.WriteLine("\noperator and");
Console.WriteLine($"true && true = {isTrue && isTrue}");
Console.WriteLine($"true && false = {isTrue && isFalse}");
Console.WriteLine($"false && false = {isFalse && isFalse}");

//or
Console.WriteLine("\noperator or");
Console.WriteLine($"true || true = {isTrue || isTrue}");
Console.WriteLine($"true || false = {isTrue || isFalse}");
Console.WriteLine($"false || false = {isFalse || isFalse}");

//xor (исключительно один true) 
Console.WriteLine("\noperator xor");
Console.WriteLine($"true ^ true = {isTrue ^ isTrue}");
Console.WriteLine($"true ^ false = {isTrue ^ isFalse}");
Console.WriteLine($"false ^ false = {isFalse ^ isFalse}");

//тернарный оператор - условие ? выражение : выражение2
int x = 5;
int y = 7;

int z = x > y ? x + 1 : y - 2;
Console.WriteLine($"z = {z}, x = {x}");

//циклы
Console.WriteLine();
Console.Write("Enter 1st number: ");
x = int.Parse(Console.ReadLine());
Console.Write("Enter 2nd number: ");
y = int.Parse(Console.ReadLine());

int n = x <= y ? x : y;

while (n <= (x >= y ? x : y)) 
{
    Console.Write( n + "\t");
    //четные не деляться на 3
    if ( n % 2 == 0 && n % 3 != 0 )
    {
        Console.Write(n);
    }
    Console.Write("\t");
    //делятся на 5 и на 3
    if (n % 5 == 0 || n % 3 == 0)
    {
        Console.Write(n);
    }
    Console.Write("\t");
    //делится либо на 5 либо на 3, но не одновременно
    if (n % 5 == 0 ^ n % 3 == 0)
    {
        Console.Write(n);
    }
    n++;
    Console.WriteLine();
}


Console.WriteLine("Enter a number: ");
int k = int.Parse(Console.ReadLine());

if ( (x > k && k > y) || ( y > k && k > x ))
{
    Console.WriteLine(k);
}