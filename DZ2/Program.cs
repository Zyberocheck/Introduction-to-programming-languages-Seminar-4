// Задача 27: Напишите программу, которая 
// принимает на вход число и выдаёт сумму 
// цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}
int numberI = Prompt();
int leng = NumberLeng(numberI);

int NumberLeng(int numberI)
{
    int i=0;
    while(numberI > 0)
    {
        numberI/=10;
        i++;
    }
    return i;
}


int SumNumI(int numberI)
{

    int sumI =0;
    for (int i =0; i<=leng; i++)
    {
        sumI = sumI + numberI % 10;
        numberI = numberI / 10;
        
    }
    return sumI;
    
}

Console.WriteLine(SumNumI(numberI));

// это... было... сложно...!!!


    