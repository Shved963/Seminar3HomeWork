//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
//Задание должно быть выполнено в методе. В методе не должно быть вывода в консоль.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координаты первой точки");

bool isParsedXa = int.TryParse(Console.ReadLine(), out int xa);
bool isParsedYa = int.TryParse(Console.ReadLine(), out int ya);
bool isParsedZa = int.TryParse(Console.ReadLine(), out int za);

Console.WriteLine("Введите координаты второй точки");

bool isParsedXb = int.TryParse(Console.ReadLine(), out int xb);
bool isParsedYb = int.TryParse(Console.ReadLine(), out int yb);
bool isParsedZb = int.TryParse(Console.ReadLine(), out int zb);

if (!isParsedXa || !isParsedYa || !isParsedZa)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

if (!isParsedXb || !isParsedYb || !isParsedZb)
{
    Console.WriteLine("Введены не корректные данные");
    return;
}

double distanceBetweenPoints = GetDistanceBetweenPoints(xa, ya, za, xb, yb, zb);

Console.WriteLine($"Расстояние между двумя точками с координатами {xa}, {ya}, {za} и {xb}, {yb}, {zb} равно {distanceBetweenPoints}");



double GetDistanceBetweenPoints(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double segmentX12 = x2 - x1;
    double segmentY12 = y2 - y1;
    double segmentZ12 = z2 - z1;

    double distance = Math.Sqrt(Math.Pow(segmentX12, 2) + Math.Pow(segmentY12, 2) + Math.Pow(segmentZ12, 2));

    return distance;

}