// Задача 29: Напишите программу, которая 
// задаёт массив из 8 элементов и выводит 
// их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int Prompt()
{
    Console.WriteLine("Введите число: ");
    return Convert.ToInt32(Console.ReadLine());
}

int size = Prompt();

// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(0,211);
//     }
//     return array;
// }

// int[] newarray = CreateArray(size);

// Console.WriteLine($"[{String.Join(", ", newarray)}]");

// Печалька конечно что задания так пересеклись...

// Поэтому попробую еще раз)




int[] CreateArray(int size)
{
    int[] array = new int[size];
    int i= 0;
    while(i < size)
    {
        array[i] = new Random().Next(-100,101);
        i++;

    }
    return array;
  
}

int[] arraylast = CreateArray(size);

Console.WriteLine($"[{String.Join(", ", arraylast)}]");


