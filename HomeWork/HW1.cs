Console.WriteLine("Name of instistution:");
string name = Console.ReadLine();

Console.WriteLine("The number of the institution:");
string number = Console.ReadLine();


Console.WriteLine("The amount of costumers in January:");
//strng input;
int jan = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in February:");
int feb = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in March:");
int mar = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in April:");
int apr = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in May:");
int may = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in June:");
int jun = int.Parse(Console.ReadLine());
Console.WriteLine("The amount of costumers in Jule:");
int jul = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} {number}");

int overall = jan + feb + mar + apr + may + jun + jul;
Console.WriteLine($"The overall amount of costumers: {overall}");

var average = (float) overall / 6;
Console.WriteLine($"The average amount of costumers: {average.ToString("#")}");
