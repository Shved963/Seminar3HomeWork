//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//Задание должно быть выполнено в методе и метод должен вернуть массив чисел.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.WriteLine("Введите целое натуральное число");

bool isParsed = int.TryParse(Console.ReadLine(), out int num);

if (!isParsed)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

if (num <= 0)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

int[] squaresTable = GetNumberSquareTable(num);

PrintArray(squaresTable);

int[] GetNumberSquareTable(int N) // Заполнение массива
{
    int[] array = new int[N];
    for (int i = 0; i < N; i++)
    {
        array[i] = (int)(Math.Pow(i+1, 3)); //(int) переделываем double после Pow в int
    }

    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}