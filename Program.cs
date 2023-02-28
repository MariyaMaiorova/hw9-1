//Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.

//M = 1; N = 5 -> "2, 4"
//M = 4; N = 8 -> "4, 6, 8"

int Promt(string msg)
{
    System.Console.Write(msg + "-> ");
    return int.Parse(Console.ReadLine());
}

void ShowNumbers(int start, int finish)
{
    if (start > finish)
    {
        return;
    }
    System.Console.WriteLine($"{start}; ");
    ShowNumbers(start + 1, finish); 
}

int number1 = Promt("введите число М");
int number2 = Promt("введите число N");

ShowNumbers(number1, number2);
