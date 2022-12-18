namespace HomeWork10;
class Program
{
    static void Main(string[] args)
    {
        string string1 = @"String escape sequences. Sequence, Character name, Unicode encoding. \', Single quote, 0x0027. \"", Double quote, 0x0022. \\, Backslash, 0x005C. \0, Null, 0x0000. \n, New line, 0x000A. \t, Horizontal tab, 0x0009";
        string string2 = "Currency codes. Char, Escape sequence, HTML code," +
            " Description. \u0024, \\u0024, &#36, dollar. \u00A2, \\u00A2," +
            " &#162, cent. \u00A3, \\u00A3, &#163, pound. \u20BD, \\u20BD, " +
            "&#8381, ruble";

        PrintTable(string1);
        Console.WriteLine("\n\n\n------ SECOND TABLE ------\n\n\n");
        PrintTable(string2);
    }

    static void PrintTable( string string1)
    {
        string[] splitString1 = string1.Split('.');
        Console.WriteLine(splitString1[0].ToUpper());
        string[] hat = splitString1[1].Split(',');

        PrintLine(splitString1);

        foreach (var item in hat)
        {
            Console.Write("|" + item.Trim('.') + " ");
        }
        Console.Write("|\n");
        PrintLine(splitString1);


        for (int i = 2; i < splitString1.Length ; i++)
        {
            string[] line = splitString1[i].Split(',');
            int count = 0;
            for (int j = 0; j < line.Length ; j++)
            {
                Console.Write("|" + line[j].Trim('.') + " ");
                count = line[j].Length + 1;
                if (count < hat[j].Length)
                {
                    while (count <= hat[j].Length)
                    {
                        Console.Write(" ");
                        count++;
                    }
                }
            }
            Console.Write("|\n");
        }

        PrintLine(splitString1);

    }
    static void PrintLine(string[] splitString)
    {
        int count = 0;
        int length = splitString[1].Length + 2;

        foreach (var item in splitString[1].Split(','))
        {
            length += 1;
        }

        while (count < length )
        {
            Console.Write("-");
            count++;
        }
        Console.Write("\n");
    }
}

