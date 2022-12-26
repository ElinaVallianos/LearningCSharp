namespace Lesson11;
class Program
{
    static void Main(string[] args)
    {
        //отличия буквальных(дословных) сторк от необработанных
        string str1;
        str1 = @"\files\""My files""\";
        str1 = """\files\"My files"\""";

        string name = "Pi number";
        float pi = 3.1415f;

        str1 = $@"{{{name}}} = {pi}";
        str1 = $"""{name} = {pi}""";

        str1 = $@"
config {{
    {{name}}: ""{name}""
    {{value}}: ""{pi}""
}}";
        Console.WriteLine(str1);

        str1 = $$"""
    confing {
        {name}: "{{name}}"
        {value}: "{{pi}}"
    }
    """;

        Console.WriteLine(str1);

        //--------------------------------------------------------------------

        str1 = "Abcdefgh";
        string str2 = "Cities of Montenegro: Podgorica, Bar, Cetine. Podgorica is the capital.";

        //проверяет содержит ли строка символ или подстроку
        Console.WriteLine("\n -- Containce");

        bool ContainseA = str1.Contains('A'); //True

        if (str2.Contains("Bar"))
        {
            Console.WriteLine("Bar is in Montenegro");
        }
        bool containsAnyText = str1.ToLower().Contains("any text"); //не изменяем исходную строку

        //заменяет символ или подстроку на новое
        Console.WriteLine("\n -- Replace");

        Console.WriteLine(str2.Replace(' ', '_'));
        Console.WriteLine(str2.Replace("Podgorica", "Cetine"));

        //проверяет начинается ли строка с какого-то символа или подстроки
        Console.WriteLine("\n -- StartWith");

        Console.WriteLine("str1 start with Abc = " + str1.StartsWith("Abc"));

        string[] splitstring1 = str2.Split();

        foreach (var item in splitstring1)
        {
            if (item.ToLower().Trim().StartsWith('c'))
            {
                Console.WriteLine(item);
            }
        }

        //проверяет заканчивается ли строка каким-то словом или символом
        Console.WriteLine("\n -- EndsWith");

        foreach (var item in splitstring1)
        {
            if (item.ToLower().Trim().EndsWith('.'))
            {
                Console.WriteLine(item);
            }
        }

        //возвращают позицию подстроки или символа.
        //Если метод не нашел такой подстроки или символа, то он возвращает -1.
        Console.WriteLine("\n -- IndexOf & LastIndexOf");

        Console.WriteLine(str1.IndexOf('G'));
        Console.WriteLine(str1.IndexOf('g'));

        //Найти слово "Bar" и удалить
        Console.WriteLine(str2.Remove(str2.IndexOf("Bar"), 5));

        Console.WriteLine(str2.LastIndexOf("Podgorica"));

        int numberOf_i = 0;
        int startIndex = 0; //с какого места ищет ( со второго i,  например)

        while (str2.IndexOf('i', startIndex) > 0)
        {
            //найти символ 'i' с позиции startIndex
            startIndex = str2.IndexOf('i', startIndex);
            Console.WriteLine(startIndex);
            startIndex++;
            numberOf_i++;

        }
        Console.WriteLine("Number of 'i' = " + numberOf_i);
        Console.WriteLine();

        Console.WriteLine(RemoveAll(str2, "Podgorica"));

        string RemoveAll(string input, string target)
        {
            string result = input;

            for (int i = 0; (i = result.ToLower().IndexOf(target.ToLower(), i)) > 0;)
            {

                result = result.Remove(i, target.Length);
            }
            return result;
        }

        //объединяет элемент последовательности (массивов)  в строку
        Console.WriteLine("\n -- Join");

        string newStringFromArray = String.Join(' ', splitstring1);
        Console.WriteLine(newStringFromArray);
        Console.WriteLine();

        int[] intArr = { 1, 2, 3, 4, 5 };
        Console.WriteLine(String.Join(", ", intArr));

        string str3 = String.Join("", str2.Split(',', '.', ':', '(', ')'));
        Console.WriteLine(str3);

        //дополняют строку пробелами до указанной длинны
        Console.WriteLine("\n -- PadLeft & PadRight");
        Console.WriteLine(str1.PadRight(10) + '|');
        Console.WriteLine(str1.PadLeft(10) + '|'); //10 - результирующая дина строки.
                                                   //Если число меньше чем длина строки, он ничего не добавляет.
                                                   //то же самое с помощю форматирования
        Console.WriteLine($"{str1,-10}|"); // пробелы справа
        Console.WriteLine($"{str1,10}|");    // пробелы слева
        Console.WriteLine($"{str1,5}|");    // 5 короче длины строки -- он ничего не будет делать



    }
}

