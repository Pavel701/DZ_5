//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Write("Введите размер массива: ");

int size = int.Parse(Console.ReadLine());

int[] numbers = new int[size];
Random random = new Random();

for (int i = 0; i < numbers.Length; i++) {
numbers[i] = random.Next(100, 1000);
}
Console.WriteLine("Элементы массива:");
int count = 0;
foreach (int number in numbers) {
Console.Write($"{number} ");
if (number % 2 == 0) {
count++;
}
}
Console.WriteLine($"\nКоличество чётных чисел в массиве: {count}");

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов с нечётными индексами.
int[] numbers = new int[10];
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++) {
      numbers[i] = random.Next(1, 100);
    }
    Console.WriteLine("Элементы массива:");
    int sum = 0;
    for (int i = 1; i < numbers.Length; i += 2) {
      Console.Write($"{numbers[i]} ");
      sum = sum + numbers[i];
    }

Console.WriteLine($"\nСумма элементов с нечётными индексами: {sum}");

//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
double[] numbers = { 3,21, 7.04, 22.93, 2.71, 78.24};
double max = numbers[0];
double min = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}

double difference = max - min;
Console.WriteLine("Максимальный элемент: " + max);
Console.WriteLine("Минимальный элемент: " + min);
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + difference);


