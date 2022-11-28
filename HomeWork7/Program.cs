namespace HomeWork7;
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
                    Console.Write("Enter your value: ");
                    var value = Console.ReadLine();
                    WhatType(value);
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

    //for task1[I am confused]

    //static string WhatType(int value)
    //{
    //    return "int";
    //}

    static string WhatType(float value)
    {
        return "float";
    }

    static string WhatType(string value)
    {
        return "string";
    }

    static void WhatType(int value)
    {
        Console.WriteLine($"{value} is of type 'int'");
    }


    //fot task2

    static void Task2()
    {
        Console.WriteLine("Enter tree int numbers ");
        int n1 = GetValue();
        int n2 = GetValue();
        int n3 = GetValue();


        switch (GetMax(n1,n2))
        {
            case > 0  when GetMax(n1,n2) == n1 && GetMax(n2,n3) == n3 :
                Console.WriteLine($"{n1} > {n2} < {n3} ");
                    break;
            case > 0 when GetMax(n1, n2) == n2 && GetMax(n2, n3) == n3:
                Console.WriteLine($"{n1} < {n2} < {n3} ");
                break;
            case > 0 when GetMax(n1, n2) == n1 && GetMax(n2, n3) == n2:
                Console.WriteLine($"{n1} > {n2} > {n3} ");
                break;
            case > 0 when GetMax(n1, n2) == n2 && GetMax(n2, n3) == n2:
                Console.WriteLine($"{n1} < {n2} > {n3} ");
                break;
            default:
                break;
        }

        Console.WriteLine("Enter three float numbers ");
        float f1 = GetValue("f");
        float f2 = GetValue("f");
        float f3 = GetValue("f");
        WriteMaxAndMinNumbers(f1, f2, f3);
    }

    static int GetMax(int n1, int n2)
    {
        return n1 > n2 ? n1 : n2;
    }

    static float GetMax(float f1, float f2)
    {
        return f1 > f2 ? f1 : f2;
    }

    static void WriteMaxAndMinNumbers(float n1,float n2,float n3)
    {
        switch (GetMax(n1, n2))
        {
            case > 0 when GetMax(n1, n2) == n1 && GetMax(n2, n3) == n3:
                Console.WriteLine($"{n1} > {n2} < {n3} ");
                break;
            case > 0 when GetMax(n1, n2) == n2 && GetMax(n2, n3) == n3:
                Console.WriteLine($"{n1} < {n2} < {n3} ");
                break;
            case > 0 when GetMax(n1, n2) == n1 && GetMax(n2, n3) == n2:
                Console.WriteLine($"{n1} > {n2} > {n3} ");
                break;
            case > 0 when GetMax(n1, n2) == n2 && GetMax(n2, n3) == n2:
                Console.WriteLine($"{n1} < {n2} > {n3} ");
                break;
            default:
                break;
        }
    }

    static dynamic GetValue( string type = "n")
    {
        switch (type)
        {
            case "n":
                Console.Write("Enter your int number: ");
                return int.Parse(Console.ReadLine());
            case "f":
                Console.Write("Enter your float number: ");
                return float.Parse(Console.ReadLine());
            case "s":
                Console.Write("Enter your string value: ");
                return Console.ReadLine();
            case "number":
                Console.Write("Enter your number: ");
                return int.Parse(Console.ReadLine());
            case "name":
                Console.Write("Enter your name: ");
                return Console.ReadLine();
            case "surname":
                Console.Write("Enter your surname: ");
                return Console.ReadLine();
            case "position":
                Console.Write("Enter your position (not necessarily): ");
                return Console.ReadLine();
            case "phone":
                Console.Write("Enter your phone number (not necessarily): ");
                return Console.ReadLine();
            case "salary":
                Console.Write("Enter your salary (not necessarily): ");
                return Console.ReadLine();
            default:
                return 0;
                break;
        }
    }

    

    ////for task1
    //static void WhatType( dynamic value)
    //{
    //    Console.WriteLine($"'{value}' is of type '{GetType(value)}'");
    //}

    //private static string GetType(dynamic value)
    //{
    //    throw new NotImplementedException();     //?????????
    //}

    //for task3
    static void Task3()
    {
        int number = GetValue("number");
        string name = GetValue("name");
        string surname = GetValue("surname");
        string position = GetValue("position");
        string phone = GetValue("phone");
        string salary = GetValue("salary");

        Print(number, name, surname, position, phone, salary);

    }

    static void Print( int number, string name, string surname, string position
        = "---", string phone = "---" , string salary = "---")
    {
        Console.WriteLine($"\nNN: {number}\nName: {name} {surname}\nPosition:" +
            $" {position}\nPhone: {phone}\nSalary: {salary}");
    }
}
