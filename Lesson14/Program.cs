namespace Lesson14;
class Program
{
    //Модификаторы параметров метода
    static void Main(string[] args)
    {
        int result;
        int a = 1, b = 2, c = 3, d = 4;

        result = Sum();
        Console.WriteLine(result);

        result = Sum(a,b);
        Console.WriteLine(result);

        result = Sum(a, b, c, d);
        Console.WriteLine(result);

        result = Sum(a,b,c,d, 12 , 34 , 5, 6, 7);
        Console.WriteLine(result);

        string[] names = GetNames("Player", a, b, 2, 4, 6, 34, 12);
        Console.WriteLine(string.Join('\n', names));

        Console.WriteLine("\n------ ref modifier -----"); //значение может быть изменено внутри метода
        Clamp(3, d);
        Console.WriteLine("d = " + d);

        Clamp(3, ref d); //так же указать ref
        Console.WriteLine("d = " + d);

        Console.WriteLine("\n------ out modifier -----"); //значение должно(!) быть изменено внутри метода

        int counter;

        CharCounter("ahuaahyagyggaaaagyajhav", 'a', out counter); //можно передавать
                                                                  //неинициализированные переменные
        Console.WriteLine("counter = " + counter);

        if (CharCounter("ahuaahyagyggaaaagyajhav", 'a', out counter))
        {
            Console.WriteLine("counter = " + counter);
        }

        if (CharCounter("ahuaahyagyggaaaagyajhav", 'x', out counter))
        {
            Console.WriteLine("counter = " + counter);
        }

        Console.WriteLine("\n------ in modifier -----"); //значение  не может(!) быть изменено внутри метода

        //кортежи - набор сгруппированных значений
        Console.WriteLine("\n------ Tuples");

        (int, int) tuple1 = (2, 4);
        Console.WriteLine(tuple1);
        //по умолчанию значения в кортедже имют имена Item1 , Item2....
        Console.WriteLine("tuple1.Item1 = " + tuple1.Item1);

        //но можно задавать и свои имена
        (string Name, int Age) person = ("Piter", 22);

        Console.WriteLine($"Name = {person.Name}, Age = {person.Age}");

        var vector2 = (X: 0, Y: 1);
        vector2.X = 13;
        vector2.Y = 5;

        vector2 = RandomeMove();
        Console.WriteLine($"X: {vector2.X}, Y: {vector2.Y}");

        //обявление кортеджа pair с элементами M и N 
        (int M, int N) pair = (12, 13);

        // декомпозиция
        // обявление двух переменных m и n типа int и присваивание им значений с помощью картеджа pair
        (int m, int n) = (12, 13);

        (a, b) = RandomeMove(); // присваивание значений переменным  a и b  с помощью кортеджа
        Console.WriteLine($"m: {m}, n: {n}");
        (m, n) = (n, m); //обмен значений переменных с помощью кортеджей
        Console.WriteLine($"m: {m}, n: {n}");

        //при сравнении кортеджей важны только тип и порядок значений
        vector2 = (12, 13);
        Console.WriteLine(pair == vector2);
        pair.M = 15;
        Console.WriteLine(pair == vector2);

    }

    //передача в метод массива параметров
    static  int Sum(params int[] numbers)
    {
        int sum = 0;
        foreach (var item in numbers)
        {
            sum += item;
        }
        return sum;
    }

    //массив параметров должен быть последним в списке параметров
    static string[] GetNames(string name, params int[] numbers)
    {
        string[] result = new string[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            result[i] = name + '-' + numbers[i];
        }

        return result;
    }

    // без модификатора ref входящее значение пораметра не изменяется 
    static void Clamp(int max, int value)
    {
        if (value > max) value = max;
    }

    //модификатор ref - передача пораметра по ссылке
    static void Clamp(int max, ref int value)
    {
        if (value > max) value = max;
    }

    static bool CharCounter(string str, char ch, out int count)
    {
        count = 0;
        bool result = false;

        foreach (var item in str)
        {
            if (item == ch)
            {
                count++;
            }

            if (count > 0)
            {
                result = true;
            }
        }
        return result;
    }

    //кортеж как возвращаемый тип
    static (int, int) RandomeMove()
    {
        Random random = new Random();
        int x, y;

        x = random.Next(1000);
        y = random.Next(1000);

        return (x, y);
    }
}

