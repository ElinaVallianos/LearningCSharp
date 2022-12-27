using System.Text;

namespace Lesson12;
class Program
{
    static void Main(string[] args)
    {
        string str1 = "Abcdefgh";
        string str2 = "Cities of Montenegro: Podgorica, Bar, Cetine. Podgorica is the capital.";

        int maxLength = 0;

        foreach (var item in str2.Split())
        {
            Console.WriteLine(item);
            maxLength = maxLength > item.Length ? maxLength : item.Length;
        }
        Console.WriteLine();

        //дополняем строку пробелами слева
        foreach (var item in str2.Split())
        {
            Console.WriteLine(item.PadLeft(maxLength));
        }
        Console.WriteLine();


        //выравнивание по центру
        foreach (var item in str2.Split())
        {
            Console.WriteLine('|' +
                (item.PadLeft(maxLength - (maxLength - item.Length) / 2)).
                PadRight(maxLength) +

                '|');
        }

        // TrimStart & TrimEnd - обрезает сторку сначала и в конце


        //преобразует сторку в массив символов
        Console.WriteLine("\n --ToCharArray: ");

        char[] charArray1, charArray2;
        charArray1 = str1.ToCharArray();
        charArray2 = str1.ToCharArray(2,4); //скопирует со 2 4 элемента

        Console.WriteLine(String.Join(' ', charArray2));

        //дополнительные конструкторы строки
        Console.WriteLine("\n --new string: ");

        string str3, str4;

        //создание строки из массива символов
        str3 = new string(charArray2);

        str4 = new string(charArray1, 2, 4);

        Console.WriteLine(str3 == str4);

        //создает строку из повторяющихся символов
        str4 = new string('-', 20);
        Console.WriteLine(str4);

        //проверяет является ли строка пустой или не инициализированной
        Console.WriteLine("\n --IsNullOrEmpty: ");

        str4 = "";
        if (String.IsNullOrEmpty(str4) == false )
        {
            Console.WriteLine("str4 is not empty: " + str4);
        }

        str4 = " \n\t";
        if (String.IsNullOrWhiteSpace(str4) == false) //проверяет содержатся ли какие либо символы
                                                      //кроме пробелов и табуляций ( ' ' , '\n' , '\t' ) 
        {
            Console.WriteLine("str4 is not empty: " + str4);
        }

        //класс StringBuilder -------------------------------------------------
        Console.WriteLine("\n --StringBuilder: ");

        StringBuilder sb = new StringBuilder();
        sb = new StringBuilder("Hello, world!");

        str4 = sb.ToString();
        Console.WriteLine(sb);

        //свойства
        //длинна и емкость
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capasity = " + sb.Capacity);
        Console.WriteLine();

        //добавляет строку в конец
        sb.Append(" Podgorica");
        Console.WriteLine(sb);

        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capasity = " + sb.Capacity);
        Console.WriteLine();

        //очищает хранимое значение
        sb.Clear();
        sb.Append("Podgorica");
        Console.WriteLine(sb);

        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capasity = " + sb.Capacity);

        sb = new StringBuilder(50);
        sb.Append("Podgorica");
        Console.WriteLine(sb);
        Console.WriteLine("sb.Length = " + sb.Length);
        Console.WriteLine("sb.Capasity = " + sb.Capacity);
        Console.WriteLine();

        //sb.Insert(); 

        //Чтение и запись файлов ----------------------------------------------
        Console.WriteLine("\n-- Class File");

        string filePath = @"input.txt";

        string input = File.ReadAllText(filePath); // other way : File.ReadAllText(@"input.txt");

        Console.WriteLine(input);
        Console.WriteLine();

        string[] strings = File.ReadAllLines(filePath);

        foreach (var item in strings )
        {
            Console.Write(item + " ");
        }

        string outPath = @"Data/output.txt";
        //запись строки в файл
        //File.WriteAllText(outPath, input);
        //запись массива строк в файл
        File.WriteAllLines(outPath, strings);

        File.AppendAllText( outPath, "\nNew Text\n");

        File.AppendAllLines(outPath, strings);
    }
}

