using Microsoft.VisualBasic;
using System.Text;

namespace HomeWork12;
class Program
{
    static void Main(string[] args)
    {
        string input = @"input.txt";

        string out1 = @"Output/numbers100-199.txt";
        string out2 = @"Output/numbers200-299.txt";
        string out3 = @"Output/numbers300-399.txt";

        CreateInput(input);
        Separator(input, out1, out2, out3);
    }

    static void CreateInput( string input)
    {
        string[] lines = new string[1000];
        for (int i = 0; i < lines.Length; i++)
        {
            Random rand = new Random();
            int x = rand.Next(100, 400);
            lines[i] = "" + x;
        }
        File.WriteAllLines(input, lines);
    }

    static void Separator( string input, string output1, string output2, string output3)
    {
        string[] numbers = File.ReadAllLines(input);

        SortAndWriteInFile(numbers, output1, "1");
        SortAndWriteInFile(numbers, output2, "2");
        SortAndWriteInFile(numbers, output3, "3");
        
    }

    static void SortAndWriteInFile(string[] input,string filePathWay, string sortItem) //сортирует по указанной строке
                                                                                    //и записывает в файл
    {
        StringBuilder numbers = new StringBuilder();
        int count = 0;
        foreach (var item in input)
        {
            if (item.StartsWith(sortItem))
            {
                numbers.Append(item + ' ');
                count++;
                if (count == 10)
                {
                    numbers.Append('\n');
                    count = 0;
                }
            }
        }
        string[] output = numbers.ToString().Split('\n');
        File.WriteAllLines(filePathWay, output);
    }
}
