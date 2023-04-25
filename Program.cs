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

