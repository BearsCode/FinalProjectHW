string[] ArrayUpToThree(string[] array1) 

{
    int sizeArray2 = 0;

    for (int i = 0; i < array1.Length; i++)
        if (array1[i].Length <= 3) sizeArray2++;

    string[] array2 = new string[sizeArray2];

    for (int i = 0, j = 0; i < array1.Length; i++)
        if (array1[i].Length <= 3)
        {
            array2[j] = array1[i];
            j++;
        }

    return array2;
}

void ShowArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    
    Console.WriteLine();
}

string[] array1 = { "@"-_-", "Hello", "World", "HomeWork", "HW", "", "2022", "31", "12", "NY" };


string[] array2 = ArrayUpToThree(array1);
ShowArray(array2);
