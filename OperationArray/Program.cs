string[] FilterArray(string[] array)
{
    string[] arr = new string[array.Length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arr[j] = array[i];
            j++;
        }
    }
    return arr;
}

void PrintArray(string[] array)
{
    Console.Write("[ "); 
    bool prev = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == null) 
        {
            prev = false;
            continue;
        }
        if (prev) 
        {
            Console.Write(", ");
        }
        Console.Write($"{array[i]}");
        prev = true;
    
    }
    Console.WriteLine("]");
}

string[] array1 = new string[10] {
    "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "10"
};
string[] array2 = FilterArray(array1);
PrintArray(array1);
Console.Write(" -> ");
PrintArray(array2);

