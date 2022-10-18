
Console.Write("Name: ");
string name = Console.ReadLine();

Console.Write("Surname: ");
string surname = Console.ReadLine();

Console.Write("Phone number: ");
string phoneNumber = Console.ReadLine();


Console.Write("The salary for January: ");
int jan = int.Parse(Console.ReadLine());
Console.Write("The salary for February: ");
int feb = int.Parse(Console.ReadLine());
Console.Write("The salary for March: ");
int mar = int.Parse(Console.ReadLine());
Console.Write("The salary for April: ");
int apr = int.Parse(Console.ReadLine());
Console.Write("The salary for May: ");
int may = int.Parse(Console.ReadLine());
Console.Write("The salary for June: ");
int jun = int.Parse(Console.ReadLine());
Console.Write("The salary for Jule: ");
int jul = int.Parse(Console.ReadLine());

Console.WriteLine($"{name} {surname} {phoneNumber}");

int overall = jan + feb + mar + apr + may + jun + jul;
Console.WriteLine($"The overall salary: {overall}");

var tax = (float)overall * 0.18;
Console.WriteLine($"The overall taxes: {tax.ToString("#.##")}");