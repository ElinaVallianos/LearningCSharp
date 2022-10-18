byte byteNumber = 13;
byte bytenumber2 = 15;
short shortNumber = 32124;
int intNumber = 1235456;
long LongNumber = 632156155;

LongNumber = intNumber;

//byteNumber = (byte)shortNumber;
shortNumber = (short)intNumber;

LongNumber = LongNumber + intNumber;

LongNumber += intNumber;
Console.WriteLine(byteNumber);

string string1, string2;

string1 = "My name ";
string2 = "Peter";

string1 += string2;

Console.WriteLine(string1);

Console.WriteLine(byteNumber > bytenumber2);
Console.WriteLine(byteNumber + 2 >= bytenumber2);
Console.WriteLine(byteNumber + 2 <= bytenumber2);
Console.WriteLine(byteNumber + 2 == bytenumber2);
Console.WriteLine(byteNumber + 2 != bytenumber2);



