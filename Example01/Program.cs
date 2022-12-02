//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль. Не использовать String!
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

Console.WriteLine("Введите целое натурально число");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

if (num < 1)
{
    Console.Write("Введены не корректные данные");
    return;
}

int shift = GetAmountNumbers(num);
//Console.WriteLine(shift);
if (num == shift)
{
    Console.WriteLine("ДА");
}
else
{
    Console.WriteLine("НЕТ");
}

int GetAmountNumbers(int N)
{
    int count = 1;
    int extended = 0;
    int n = N;

    while (n / 10 != 0)
    {
        n = n / 10;
        count++;
    }
    
    n = N;

    for (int i = 0; i < count; i++)
    {
        extended = extended * 10 + n % 10;
        n = n / 10;
    }
    int result = extended;
    return result;
}