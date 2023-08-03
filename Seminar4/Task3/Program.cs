int[] SetArray(int length)
{
    int[] array= new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
    return array;
}

void GetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

Console.WriteLine("Введите размерность массива ");
int length = int.Parse(Console.ReadLine());
int[] array = SetArray(length);
GetArray(array);