string[] array=new string[5]{"123","Ракета","=)","$!@","шлепа"};
ShowString(array);
void ShowString(string[] array)
{
    Console.WriteLine("Изначальный массив строк:");
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        
        Console.Write($"{array[i]}");
        if(i+1<array.Length) Console.Write(",");
    }
    Console.Write("]");
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length<=3) Console.Write(array[i]);
}