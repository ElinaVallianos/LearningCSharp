namespace Lesson7._1;
class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Enter task number: ");
            var taskNumber = Console.ReadLine();

            switch (taskNumber)
            {
                case "1":
                    Console.WriteLine($"Program {taskNumber}");
                    Task1();
                    break;
                case "2":
                    Console.WriteLine($"Program {taskNumber}");
                    Task2();
                    break;
                case "3":
                    Console.WriteLine($"Program {taskNumber}");
                    Task3();
                    break;
                case "q" or "Q":
                    Console.WriteLine($"Bye, bye!");
                    return;
                default:
                    if (taskNumber == "exit")
                    {
                        Console.WriteLine($"Bye, bye!");
                        return;
                    }
                    Console.WriteLine($"Program {taskNumber} doesn't exist.");
                    break;
            }
        }
    }

    static void Task1()
    {
        int n1 = GetIntNumber(1);
        int n2 = GetIntNumber(2);

        Console.WriteLine(Sum(n1, n2));

        float f1 = GetFloatNumber(1);
        float f2 = GetFloatNumber(2);

        Console.WriteLine(Sum(f1, f2));

        n1 = GetIntNumber(1);
        n2 = GetIntNumber(2);

        n1 = GetIntNumber(1, "parametr");
        n2 = GetIntNumber(2, "parametr");

    }

    static void Task2()
    {
        int n1 = GetIntNumber(1);
        int n2 = GetIntNumber(2);
        int n3 = GetIntNumber(3);

        Console.WriteLine(Sum(n1, n2, n3));
        Console.WriteLine(Sum(n1, n2));

        n1 = GetIntNumber(name: "parametr", order: 1);

    }

    static void Task3()
    {
        int n1 = GetNumber("n", 1, "int number");
        int n2 = GetNumber();
        Console.WriteLine(Sum(n1, n2));

        float f1 = GetNumber("f", 1, "float number");
        float f2 = GetNumber("f");

        Console.WriteLine(Sum(f1, f2));

    }

    //static int GetIntNumber(int order = 0)
    //{
    //    if (order > 0) Console.WriteLine($"Enter the {order}th int number: ");
    //    else Console.Write($"Enter an int number: ");
    //    return int.Parse(Console.ReadLine());
    //}




    /// <summary>
    /// Return an integer
    /// </summary>
    /// <param name="order">Order of an enumerated parametr</param>
    /// <param name="name">Name of enumerated parametr</param>
    /// <returns></returns>
    static int GetIntNumber(int order = 0, string name = "int number")
    {
        if (order > 0) Console.Write($"Enter the {order}th {name}: ");
        else Console.Write($"Enter an int number: ");
        return int.Parse(Console.ReadLine());
    }


    //static int GetIntNumber(string name1, int order)
    //{
    //    if (order > 0) Console.WriteLine($"Enter the {order}th {name1}: ");
    //    else Console.Write($"Enter any {name1}: ");
    //    return int.Parse(Console.ReadLine());
    //}



    //параметры по умолчанию идут только после обязательных!!!

    static int Sum(int n1, int n2, int n3 = 0)
    {
        Console.Write($"Sum of int numbers: ");
        return n1 + n2 + n3;
    }

    static float Sum(float f1, float f2)
    {
        Console.Write($"Sum of float numbers: ");
        return f1 + f2;
    }




    static float GetFloatNumber(int order)
    {
        if (order > 0) Console.Write($"Enter the {order}th float number: ");
        else Console.Write($"Enter an float number: ");
        return float.Parse(Console.ReadLine());
    }

    //static int GetIntNumber()
    //{
    //    Console.WriteLine($"Enter int number: ");

    //    return int.Parse(Console.ReadLine());
    //}

    static dynamic GetNumber(string type = "n", int order = 0, string name = "number")
    {
        switch (type )
        {
            case "n":
                return GetIntNumber(order, name);
            case "f":
                return GetFloatNumber(order);
            default:
                return 0;
        }
    }
}
