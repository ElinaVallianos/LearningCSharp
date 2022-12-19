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
        string string3 = "List of companies.Company,Contact,Country.Alfreds " +
            "Futterkiste,Maria Anders,Germany.Centro comercial Moctezuma," +
            "Francisco Chang,Mexico.Ernst Handel,Roland Mendel,Austria." +
            "Island Trading,Helen Bennett,United Kingdom.Laughing Bacchus " +
            "Winecellars,Yoshi Tannamuri,Canada.Magazzini Alimentari Riuniti," +
            "Giovanni Rovelli,Italy.";

        PrintTable(string1);
        PrintTable(string2);
        PrintTable(string3);
    }

    static void PrintTable( string string1)
    {
        string[] splitString1 = string1.Trim('.' , ' ').Split('.');
        Console.WriteLine(splitString1[0].ToUpper());

        string[][] body = new string[splitString1.Length - 1][];
        for (int i = 1; i < splitString1.Length; i++) 
        {
            string[] line = splitString1[i].Trim('.', ' ').Split(',');
            for (int j = 0; j < line.Length; j++)
            {
                body[i - 1] =  line;
            }
        }

        PrintLine(body);

        for (int i = 0; i < body.Length ; i++)
        {
            int count = 0;
            for (int j = 0; j < body[i].Length ; j++)
            {
                Console.Write("| " + body[i][j].Trim('.',' ') + " ");
                count = body[i][j].Trim(' ').Length;
                if (count < MaxLength(body , j))
                {
                    while (count < MaxLength(body, j))
                    {
                        Console.Write(" ");
                        count++;
                    }
                }
            }
            if ( i == 0)
            {
                Console.Write("|\n");
                PrintLine(body);
            }
            else
            {
                Console.Write("|\n");
            }
        }

        PrintLine(body);
        Console.WriteLine();

    }


    static void PrintLine(string[][] body)
    {
        int count = 0;
        int length = 0;
        for (int i = 0; i < body[0].Length; i++)
        {
            length += MaxLength(body, i) + 3;
        }

        while (count <= length )
        {
            Console.Write("-");
            count++;
        }
        Console.Write("\n");
    }


    static int MaxLength(string[][] arr, int index)
    {
        int max = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            max = max >= arr[i][index].Trim().Length ? max : arr[i][index].Trim().Length;
        }
        return max;
    }
}
