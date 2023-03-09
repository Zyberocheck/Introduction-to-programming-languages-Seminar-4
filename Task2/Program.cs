// // Задача 26: Напишите программу, которая принимает 
// на вход число и выдаёт количество цифр в числе.
// // 456 -> 3
// // 78 -> 2
// // 89126 -> 5

// // Задача 28: Напишите программу, которая принимает 
// на вход число N и выдаёт произведение чисел от 1 до N.
// // 4 -> 24 
// // 5 -> 120



int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

// int NumberQu(int number)
// {
//     int i =1;
//     while (number /10!=0)
//     {
//         number = number / 10;
//         i++;
//     }
//     return i;
// }

// int number = Prompt();
// Console.WriteLine(NumberQu(number));


int number = Prompt();
int MultNums( int number)
{
    int mult = 1;
    for (int i =1; i <= number; i++)
        mult*=i;
    return mult;
}


Console.WriteLine(MultNums(number));
