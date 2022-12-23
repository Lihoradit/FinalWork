string[] array = new string[5] { "13", "Ракета", "=)", "$!@", "ша" };
Console.WriteLine("Изначальный массив строк:");
ShowString(array);
void ShowString(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]}");
        if (i + 1 < array.Length) Console.Write(",");
    }
    Console.WriteLine("]");
}
Console.WriteLine("Новый массив строк, где меньше 4 символов :");
string[] NewArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }
    string[] newArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 2)
        {
            newArray[count] = array[i];
            count++;
        }
    }
    return newArray;
}
ShowString(NewArray(array));