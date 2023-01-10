namespace Lesson13;

//перечисления - набор именнованых связанных между собой констант
enum Color
{
    Unknown,  //по умолчанию = 0
    Red,      // = 1
    Green,    // = 2
    Blue      // = 3
}

//можно задавать любые числовые значения для каждой константы
enum DecimalPlace
{
    Ones = 1,
    Tens = 10,
    Hundreds = 100,
    Thousands =1000
}

//числовые значения начинаются с последнего назначенного номера и могут повторяться
// несколько констант могут иметь одинаковые числовое значение
enum MyEnum
{
    One = 1, //tсли One  = 1
    Two, // = 2
    Three, // = 3
    Four = 8, // = 8
    Five,  //  = 9 
    Six,
    Seven = 0, // если = 0
    Eight, 
    Nine,
    Ten = Four
}
//Битовые флаги
//неисключающие перечисления - перечисления, которые могут хранить несколько значений одновременно
[Flags]
enum DaysOfWeeks
{
    Monday = 1,    //00000001
    Tuseday = 2,   //00000010
    Wednesday = 4, //00000100
    Thursday = 8,  //00001000
    Friday = 16,   //00010000
    Satyrday = 32, //00100000
    Sunday = 64,   //01000000
    //часто используемые значения можно объеденить в дополнительные константы
    WorkDays = Monday | Tuseday | Wednesday | Thursday  | Friday,
    Weekends = Satyrday | Sunday //01100000
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a color: Red - 1, Green - 2, Blue - 3");

        int colorNumber = int.Parse(Console.ReadLine());
        Console.Write("Your color: ");
        switch (colorNumber)
        {
            case 1:
                Console.WriteLine("Red");
                break;
            case 2:
                Console.WriteLine("Green");
                break;
            case 3:
                Console.WriteLine("Blue");
                break;
            default:
                break;
        }

        Color myColor;
        myColor = new Color();
        //задаем значение переменной myColor в заввисимости от введенного номера
        switch (colorNumber)
        {
            case 1:
                myColor = Color.Red;
                break;
            case 2:
                myColor = Color.Green;
                break;
            case 3:
                myColor = Color.Blue;
                break;
            default:
                myColor = Color.Unknown;
                break;
        }

        Console.Write("Your color: ");

        switch (myColor )
        {
            case Color.Red:
                Console.WriteLine("Red");
                break;
            case Color.Green:
                Console.WriteLine("Green");
                break;
            case Color.Blue:
                Console.WriteLine("Blue");
                break;
            default:
                Console.WriteLine("Unknown");
                break;
        }

        //задаем значение перечисления с помощью числового значения константы
        myColor = (Color)colorNumber;
        Console.Write("Your color: ");
        switch (colorNumber)
        {
            case 1:
                Console.WriteLine("Red");
                break;
            case 2:
                Console.WriteLine("Green");
                break;
            case 3:
                Console.WriteLine("Blue");
                break;
            default:
                break;
        }

        //проверяем соответствует ли числу colorNumber какая либо константа типа Color
        myColor = Enum.IsDefined((Color)colorNumber) ? (Color)colorNumber : Color.Unknown;
        //вывести имя константы
        Console.WriteLine("\nYour color: " + myColor);
        //выводится числовое значение константы
        Console.WriteLine("\nYour color number = " + (int)myColor);

        Console.WriteLine();

        Random random = new Random();
        int x = random.Next(10000);

        Console.Write($"""
            Number {x} contains:
            {x / (int)DecimalPlace.Thousands} Thousands
            {x / (int)DecimalPlace.Hundreds} Hundreds
            {x / (int)DecimalPlace.Tens} Tens
            {x} ones               
            """);

        Console.WriteLine('\n');

        //сохраняем в переменную два значения
        DaysOfWeeks gymDay = DaysOfWeeks.Monday | DaysOfWeeks.Wednesday;
        Console.WriteLine(gymDay);

        //Добавляем значение в переменную
        gymDay = gymDay | DaysOfWeeks.Friday;
        //gymDay |= DayOfWeek.Friday;
        Console.WriteLine(gymDay);

        //удаление значения
        gymDay ^= DaysOfWeeks.Friday; // gymDay = gymDay ^ DaysOfWeeks.Friday;
        Console.WriteLine(gymDay);

        //удаление всех значений кроме какого то
        gymDay &= DaysOfWeeks.Monday;
        Console.WriteLine(gymDay);

        //все рабочие дни кроме среды
        gymDay = DaysOfWeeks.WorkDays ^ DaysOfWeeks.Wednesday;
        Console.WriteLine(gymDay);

        //все выходные и среда
        gymDay = DaysOfWeeks.Weekends | DaysOfWeeks.Wednesday;
        Console.WriteLine(gymDay);

        if (gymDay.HasFlag(DaysOfWeeks.Wednesday))
        {
            Console.WriteLine("Wendesday is a gym day");
        }

        var today = DaysOfWeeks.Wednesday;
        if (gymDay.HasFlag(today))
        {
            Console.WriteLine("Go to the gym!");
        }
    }
}

