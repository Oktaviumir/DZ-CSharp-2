// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


Console.WriteLine("Введите размер массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] num = new double[size];
FillArrayRandomNum(num);
Console.WriteLine("массив: ");
PrintArray(num);
double min = Int32.MaxValue;
double max = Int32.MinValue;

void FillArrayRandomNum(double[] num)
{
    for(int i = 0; i < num.Length; i++)
        {
            num[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}

void PrintArray(double[] num)
{
    Console.Write("[ ");
    for(int i = 0; i < num.Length; i++)
        {
            Console.Write(num[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}
for (int i = 0; i < num.Length; i++)
{
    if (num[i] > max)
        {
            max = num[i];
        }
    if (num[i] < min)
        {
            min = num[i];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");