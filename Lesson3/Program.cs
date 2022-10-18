int number;

bool isEven;


Console.Write("Write your number: ");
number = int.Parse(Console.ReadLine());

if (number%2 != 0)
{
    isEven = false;
    Console.WriteLine($"The number {number} is not even.");
}
else
{
    isEven = true;
    Console.WriteLine($"The number {number} is even.");
}



