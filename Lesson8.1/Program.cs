namespace Lesson8._1;
class Program
{
    static void Main(string[] args)
    {
        //Массивы - это набор данных одного типа


        int[] arr0; //значение и инициализированно
        int[] arr1 = new int[4]; //значение по умолчанию: 0, 0, 0, 0
        int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
        int[] arr3 = new int[] { 1, 2, 3, 4 }; //автоопределение длинны массива
        int[] arr4 = new[] { 1, 2, 3, 4, 5, 6 };
        int[] arr5 = { 1, 2, 3, 4, 5 };

        arr0 = new[] { 1, 2, 3 }; // обязательно писать new[] тк массив не был инициализированн (arr0 = {1,2,3}; - так нельзя)

        //массив не изменяемый!(нельзя прибавить или убавить ячейку памяти)

        //массивы начинаются с 0
        arr0[0] = 12;
        arr0[1] = 13;

        Console.WriteLine($"Длинна массива arr3 = {arr3.Length}");

        //arr3[4] = 13; // выход за приделы массива

        for (int i = 0; i < arr0.Length ; i++)
        {
            arr0[i] = i;
        }

        //только для чтения нельзя изменить значения "item"
        foreach (int item in arr0 )
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("\n");

        //Массивы - ссылочные типы

        arr1 = arr5; //arr1 ссылается на ту же область, что и arr5
        arr5[4] = 14;
        Console.WriteLine($"arr1[4] = {arr5[4]}");

        //при передаче массива в функцию или метод его элементы можно изменить

        void cleanArray(int[] array)
        {
            for( int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }
        cleanArray(arr1);

        Console.WriteLine("\n After cleaning:");

        foreach (var item in arr5)
        {
            Console.Write(item + " ");
        }

        //массив можно вернуть из функции

        string[] strArray = new string[3];

        Console.WriteLine();

        //запись значений массива из консоли
        for (int i = 0; i < strArray.Length; i++)
        {
            Console.Write("Enter line: ");
            strArray[i] = Console.ReadLine();
        }

        string[] Twice(string[] oldArray)
        {
            string[] newArray = new string[oldArray.Length];

            for (int i = 0; i < oldArray.Length ; i++)
            {
                newArray[i] = oldArray[i] + " " + oldArray[i];
            }
            return newArray;
        }

        foreach (var item in Twice(strArray))
        {
            Console.WriteLine(item);
        }
    }
}

