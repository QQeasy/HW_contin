Console.Clear();

Console.WriteLine($"Вводите значения k1, b1: ");
float k1 = ReadNum();
float b1 = ReadNum();
Console.WriteLine($"Вводите значения k2, b2: ");
float k2 = ReadNum();
float b2 = ReadNum();

Console.Write($"Для того, чтобы найти точку пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2} введите 'YES': ");
string result = Console.ReadLine();
float x = 0;
float y = 0;
if (result == "YES")
{
    x = ((b2 - b1) / (k1 - k2));
    y = (x*k1 + b1);
    Console.WriteLine($"Точка пересечения прямых y = {k1}*x + {b1} и y = {k2}*x + {b2} - ({x}:{y}):");
}


//ввод чисел int
float ReadNum()
{
    float i = Convert.ToInt32(Console.ReadLine());
    return i;
}
