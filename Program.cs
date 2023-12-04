void OutputStringArray(string[] array)
{
    Console.WriteLine($"['{string.Join("', '", array)}']");
}

string[] SearchString(string[] array, int countStringDigit = 3)
{
    int countString = 0;
    foreach (var item in array)
        if (item.Length <= countStringDigit) countString++;
    
    string[] resultArray = new string[countString];
        
    for (int iArr = 0, iRes = 0; iArr < array.Length; iArr++)
        if (array[iArr].Length <= countStringDigit)
            resultArray[iRes++] = array[iArr];
    
    return resultArray;
}

string[] InputStringArray()
{
    Console.Clear();
    int length = -1;
    while(true)
    {
        Console.Write("Enter the number of rows in the array: ");
        string str = Console.ReadLine();
        if (int.TryParse(str, out length) && length >= 0) break;
        Console.WriteLine("incorrect number of rows in the array\n");
    }
    
    string[] array = new string[length];
    
    Console.WriteLine("Fill in the array line by line");
    
    for (int i = 0; i < length; i++)
        array[i] = Console.ReadLine();
        
    return array;
}

string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};
//string[] array4 = InputStringArray();

string[] result1 = SearchString(array1);
string[] result2 = SearchString(array2);
string[] result3 = SearchString(array3);
//string[] result4 = SearchString(array4);

OutputStringArray(array1);
OutputStringArray(result1);
Console.WriteLine();

OutputStringArray(array2);
OutputStringArray(result2);
Console.WriteLine();

OutputStringArray(array3);
OutputStringArray(result3);
Console.WriteLine();

//OutputStringArray(array4);
//OutputStringArray(result4);
//Console.WriteLine();
