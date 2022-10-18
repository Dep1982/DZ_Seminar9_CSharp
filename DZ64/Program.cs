// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии
int InNumber()
{
    while (true)
    {
        string text = Console.ReadLine();
        if (int.TryParse(text, out int number) && number > 0)
        {
            return number;
        }
        else
        {
            Console.Write("Не удалось распознать число, либо оно отрицательное. \nВведите число ещё раз: ");
        }
    }
}

Console.Write("Введите положительное число: ");
int number = InNumber();

NaturalNumber(number);

void NaturalNumber(int number)
{
    if (number == 0)
    {
        return;
    }
    else
    {
        Console.Write($"{number} ");
        NaturalNumber(number - 1);
    }
}
