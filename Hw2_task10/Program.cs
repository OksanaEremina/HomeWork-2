// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.WriteLine ("Введите число: ");
string? line = Console.ReadLine();
if (line != null) {
    char[] array = line.ToCharArray();
    Console.WriteLine(array[1]);
}

