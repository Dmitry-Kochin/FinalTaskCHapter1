using System;

internal class Program
{
    private static void Main(string[] args)
    {
        int sizeArrayToOutput = 0;

        int Limit = 3;
        string[] InitialArray = { "hello", "2", "world", ":-)" };
        PrintArray(InitialArray);
        Console.Write(" -> ");
        string[] tempArray = new string[InitialArray.Length];
        tempArray = SelectFromArray(InitialArray, Limit);

        string[] ArrayToOutput = new string[sizeArrayToOutput];
        ArrayToOutput = TruncateArray(tempArray, sizeArrayToOutput);
        PrintArray(ArrayToOutput);

        string[] SelectFromArray(string[] InitialArray, int length)
        {
            string[] tempArray = new string[InitialArray.Length];
            int j = 0;
            foreach (var item in InitialArray)
            {
                if (item.Length <= length)
                {
                    tempArray[j++] = item;
                }
            }
            sizeArrayToOutput = j;
            return tempArray;
        }

        string[] TruncateArray(string[] InitialArray, int count)
        {
            string[] tempArray = new string[count];
            int i = 0;
            while (i < count) tempArray[i] = InitialArray[i++];
            return tempArray;
        }

        void PrintArray(string[] array)
        {
                Console.Write("[");
        int count = 0;
        while (count < array.Length)
        {
            if (count < array.Length - 1)
            {
                Console.Write($"\"{array[count]}\", ");
            }
            else
            {
                Console.Write($"\"{array[count]}\"");
            }
            count++;
        }
        Console.Write("]");
    }
}
}