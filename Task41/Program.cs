// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько
// чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// задача от преподавателя)
// Пользователь вводит с клавиатуры неопределенное количество чисел (while (true)). 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. Ввод чисел останавливается 
// при помощи ввода слова "stop"

Console.WriteLine("Введите количество чисел:  ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
RandonNumbers(numbers);
Console.WriteLine("В этом массиве: ");
PrintArray(numbers);

void RandonNumbers(int[] numbers)
{
    for(int i = 0; i < size; i++)
    {
        numbers[i] = new Random().Next(-100, 100);
    }
}

int count = 0;
for (int i = 0; i < numbers.Length; i++)
{
if (numbers[i] > 0)
count++;
}
Console.WriteLine($"из {numbers.Length} чисел, {count} ,больше 0");

void PrintArray(int[] numbers )
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + ", ");
    }
    Console.Write("]");
    Console.WriteLine();
}


