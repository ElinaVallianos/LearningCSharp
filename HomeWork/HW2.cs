
Console.WriteLine("Name:");
string name = Console.ReadLine();

Console.WriteLine("Surname:");
string surname = Console.ReadLine();

Console.WriteLine("Phone number:");
string phoneNumber = Console.ReadLine();


Console.WriteLine("The salary for January:");
int jan = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for February:");
int feb = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for March:");
int mar = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for April:");
int apr = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for May:");
int may = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for June:");
int jun = int.Parse(Console.ReadLine());
Console.WriteLine("The salary for Jule:");
int jul = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} {surname} {phoneNumber}");

int overall = jan + feb + mar + apr + may + jun + jul;
Console.WriteLine($"The overall salary: {overall}");

var tax = (float)overall * 0.18;
Console.WriteLine($"The overall taxes: {tax.ToString("#.##")}");