using System.Diagnostics.Metrics;

namespace HomeWork9;
class Program
{
    static void Main(string[] args)
    {
        int[] arrInt = new int[] { 23, 12, 6, 13, 45, 123, 5 };
        float[] arrFloat = new float[] { 1.7f, 12, 3.14f, 34.678f, 2, 73 };

        Console.WriteLine(Sum(arrInt));
        Console.WriteLine(Sum(arrFloat));

        Console.WriteLine(Max(arrInt));
        Console.WriteLine(Max(arrFloat));

        Console.WriteLine($" averageI: {Average(arrInt)}");
        Console.WriteLine($" averageF: {Average(arrFloat)}");

        int[] arrInt2 = new int[] { 17, 45, 12, 13, 0 };

        foreach (var item in Concat(arrInt,arrInt2))
        {
            Console.Write(item + ", ");
        }

        Console.WriteLine();

        for (int i = Concat(arrInt, arrInt2).Length - 1; i >= 0; i--)
        {
            Console.Write(Concat(arrInt, arrInt2)[i] + ", ");
        }
    }

    static int Sum(int[] arr1)
    {
        int summ = 0;
        foreach (int item in arr1)
        {
            summ += item;
        }
        return summ;
    }

    //выводится 6 цифр после запятой?????????
    static float Sum(float[] arr1)
    {
        float summ = 0;
        foreach (float item in arr1)
        {
            summ += item;
        }
        return summ;
    }

     static int Max(int[] arr2)
    {
        int max = 0;
        for (int i = 0; i < arr2.Length ; i++)
        {
            max = arr2[i] > max ? arr2[i] : max;
        }
        return max;
    }

    static float Max(float[] arr2)
    {
        float max = 0;
        for (int i = 0; i < arr2.Length; i++)
        {
            max = arr2[i] > max ? arr2[i] : max;
        }
        return max;
    }

    static int Average( int[] arr3)
    {
        return Sum(arr3) / (arr3.Length);
    }

    //опять 6 цифр после запятой........
    static float Average(float[] arr3)
    {
        return Sum(arr3) / (arr3.Length);
    }

    static int[] Concat( int[] arr1, int[] arr2)
    {
        int[] newArray = new int[arr1.Length + arr2.Length];

        for (int i = 0; i < newArray.Length ; i++)
        {
            if ( i < arr1.Length)
            {
                newArray[i] = arr1[i];
            }
            else
            {
                newArray[i] = arr2[i - arr1.Length];
            }   
        }
        return newArray;
    }
}
