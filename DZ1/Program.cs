//  Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
//  3, 5 -> 243 (3⁵)
//  2, 4 -> 16

Console.WriteLine("Введите два числа, ая возвиду первое в степень второго: ");
double a = Convert.ToInt32(Console.ReadLine());
double b = Convert.ToInt32(Console.ReadLine());

// 2 решения

// for( int i = 1; i<b; i++)
// {
    
//     mult = mult * a;


// }

double mult;

mult = Math.Pow(  a,  b);
Console.WriteLine(mult);


