int intNumber;
byte byteNumber;

intNumber = 0;
byteNumber = 0;

int consoleNumber = int.Parse(Console.ReadLine());

if ( consoleNumber <= 255 )
{
    byteNumber += (byte)consoleNumber;
}
else
{
    intNumber += consoleNumber;
}

intNumber += 1;
byteNumber += 1;

if ( byteNumber <= 1 )
{
    byteNumber = (byte)intNumber;
}

if ( intNumber == 1 )
{
    intNumber = byteNumber;
}

int diff;
diff = intNumber - byteNumber;

Console.WriteLine($"Int: {intNumber} \n Byte: {byteNumber} \n Differense: {diff}"); 

//Дополнение

int units;
int decades;
int hundreds;

hundreds = intNumber / 100;
decades = (intNumber % 100) / 10;
units = intNumber % 10;

Console.WriteLine($"intH: {hundreds} \n intD: {decades} \n intU: {units}");