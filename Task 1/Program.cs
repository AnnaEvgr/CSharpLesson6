/*Задача 1: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3*/

int InputInt(string message)
{
    System.Console.Write($"{message}: ");
    return int.Parse(Console.ReadLine());
}

int[] GenerateArray(int len)
{
    int[] array = new int[len];
    for (int i = 0; i < array.Length; ++i)
    {
        System.Console.Write($"ВВедите число {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }
    return array;
}
int PositiveNum(int[] number)
{
    int positive = 0;
    for (int i = 0; i < number.Length; i++)
    {
        if (number[i] > 0)
        {
            positive++;
        }
    }
return positive;
}
void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int num = InputInt("Сколько чисел хотите ввести ");
int[] array = GenerateArray(num);
PrintArray(array);
int positiveCount = PositiveNum(array);
System.Console.WriteLine($"Количество чисел больше 0 = {positiveCount}");

