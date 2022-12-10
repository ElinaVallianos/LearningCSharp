namespace HomeWork9._1;
class Program
{
    static void Main(string[] args)
    {
        int[] arr1 = new int[] { 2, 4, 6, 3, 1 };
        int[] arr2 = new int[] { 2, 7, 6, 5 };
        int[] arr3 = new int[] { 3, 4, 6, 7, 1, 5 };

        int[,] arr4 = new int[3, 2];
        int[,] arr5 = new int[3, 2];

        int[][] arr6 = new int[3][] { arr1, arr2, arr3 };

        Console.Write("В обратном порядке: ");
        PrintArr(Revers(arr1));
        Console.Write(arr1.Length );

        Console.Write("Удаление элемента 0 из { 2, 4, 6, 3, 1 } : ");
        PrintArr(Remove(arr1, 0));
        Console.Write("Удаление элемента -1 из { 2, 4, 6, 3, 1 } : ");
        PrintArr(Remove(arr1, -1));
        Console.Write("Удаление элемента 5 из { 2, 4, 6, 3, 1 } : ");
        PrintArr(Remove(arr1, 5));

        PrintTwiseArray(Fill(arr4));
        PrintTwiseArray( SummOfMatrix(arr4, Fill(arr5)));

        PrintDifficultArray(JaggedToMatrix(arr6));
    }

    static void PrintArr(int[] arr)
    {
        int count = 0;
        foreach (var item in arr)
        {
            Console.Write(item);
            count++;
            if (count < arr.Length )
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }

    static void PrintTwiseArray(int[,] arr)
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.Write("{ ");
            for (int j = 0; j < arr.Length / 3; j++)
            {
                Console.Write(arr[i, j] + " ");
            }
            Console.WriteLine("}");
        }
    }

    static void PrintDifficultArray(int[][] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write($"Массив [{i}]: ");

            PrintArr(arr[i]);
        }
    }


    //1
    static int[] Revers( int[] arr)
    {
        int[] newArr = new int[arr.Length];
        int k = 0;
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            newArr[k] = arr[i];
            k++;
        }
        return newArr;
    }

    //2
    static int[] Remove(int[] arr, int index)
    {
        if (index > (arr.Length - 1))
        {
            return arr;
        }

        if (index < 0)
        {
            index = arr.Length + index;
        }

        int[] newArr = new int[arr.Length - 1];
        int k = 0;
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == index)
            {
                continue;
            }
            newArr[k] = arr[i];
            k++;
        }
        
        return newArr;
    }
    //3
    static int[,] Fill(int[,] arr)
    {
        Console.WriteLine();
        for (int j = 0, k = 1; j < arr.GetLength(0); j++, k++)
        {
            for (int i = 0; i < arr.GetLength(1); i++)
            {
                if (j == 0)
                {
                    Console.Write($"Enter your number for {i} position: ");
                    arr[j, i] = int.Parse(Console.ReadLine());
                    continue;
                }
                arr[j, i] = arr[ 0 , i] * k;
            }
        }
        return arr;
    }

    //4
    static int[,] SummOfMatrix( int[,] arr1 , int[,] arr2 )
    {
        int[,] newArr = new int[3, 2];
        for (int j = 0; j < newArr.GetLength(0); j++)
        {
            for (int i = 0; i < newArr.GetLength(1); i++)
            {
                newArr[j, i] = arr1[j, i] + arr2[j, i];
            }
        }
        return newArr;
    }

    //5
    static int[][] JaggedToMatrix(int[][] arr)
    {
        int[][] newArray = new int[arr.GetLength(0)][];
        int[] small = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            small = arr[i].Length >= small.Length ? small : arr[i];
        }
        int index = small.Length;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            while (arr[i].Length != index)
            {
                arr[i] = Remove(arr[i], index);
            }
            newArray[i] = arr[i];
        }
        return newArray;
    }
}

