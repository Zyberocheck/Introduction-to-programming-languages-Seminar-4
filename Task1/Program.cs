// Напишите программу, которая принимает 
// на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36




int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}


int SumNums ( int number)
{
    int sum = 0;
    for (int i =0; i <= number; i++)
        sum+=i;
    return sum;
}

int number = Prompt(); // int a = Prompt(); -- было так. что за a? что тогда такое number
Console.WriteLine(SumNums(number)); // Console.WriteLine(SumNums(a));                                                                               


54 минута

