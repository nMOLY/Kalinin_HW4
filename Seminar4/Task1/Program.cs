Console.WriteLine("Введите число, которое хотите возвести в степень ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа, которую хотите получить ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Полученное число равно " + Pow(a, b));

int Pow(int a, int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        a *= c;
    }
    return a;
}