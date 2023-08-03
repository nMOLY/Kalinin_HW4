Console.WriteLine("Введите число, сумму цифр которого хотите получить ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Сумма цифр числа равна " + SumOfDigits(a));

int SumOfDigits(int a)
{
    int sum = 0;
    while (a % 10 != 0)
    {
        sum += a % 10;
        a /= 10;
    }
    return sum;
}

/* Увидел в критериях оценки что нельзя строкой решать((
int SumOfDigits(int a)
{
    string arr = a.ToString();
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += int.Parse(arr[i].ToString());
    }
    return sum;
}
*/