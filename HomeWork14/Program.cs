namespace HomeWork14;
class Program
{
    static void Main(string[] args)
    {
        (int Min, int Max) = GetMinMax(44, 22, 12, 1, 3, 67, 33);
        Console.WriteLine($" min number = {Min}\nmax number = {Max}");

        (Min, Max) = GetMinMax(32, 100, 32, 766, 7, 91);
        Console.WriteLine($" min number = {Min}\nmax number = {Max}");

        int[] test = new int[] { 1, 2, 5, 7 };
        (bool result, int count) = Expand(ref test, 8);
        if (result)
        {
            for (int i = test.Length - count, j = 1; i < test.Length ; i++, j++)
            {
                test[i] = j;
            }
        }
        Console.WriteLine(String.Join(", ", test));

    }

    static (int , int) GetMinMax( params int[] numbers)
    {
        int min = numbers[0];
        int max = numbers[0];
        foreach (var item in numbers)
        {
            max = max >= item ? max : item;
            min = min <= item ? min : item;
        }
        return (min, max);
    }

    static (bool, int) Expand(ref int[] array, int length)
    {
        bool result = false;
        int count = 0;

        if (array.Length < length )
        {
            int[] newArray = new int[length];
            for (int i = 0; i < array.Length ; i++)
            {
                newArray[i] = array[i];
            }
            result = true;
            count = newArray.Length - array.Length;
            array = newArray;
        }
        return (result, count);
    }
}