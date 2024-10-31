Console.Clear();
string num1 = "";
int count = 0;
Console.WriteLine($"Вводите числа, когда закончите, введите 'stop':");
for (int i = 0; i < 999; i++)
{
    num1 = Console.ReadLine();
    if (num1 != "stop")
    {
        Convert.ToInt32(num1);
        count++;
    }
    else
    {
        break;
    }
}
Console.Write($"Из введенных чиcел - {count} положительных!");
