// //  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число:");
string? line = Console.ReadLine();
if (line != null){
    int num = int.Parse(line);
    if(num == 6 || num == 7) {
        Console.WriteLine("Да");
    } else {
        Console.WriteLine("Нет");
    }
} 



