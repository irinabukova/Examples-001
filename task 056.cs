// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,]arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j]=new Random().Next(1,5);
            Console.Write($"{arr[i,j]}  ");

        }
        Console.WriteLine();
    }
}

int Sum (int[,] arr, int i) // сумма значений 1-ой строки 
{
    int minstring = arr[i,0];
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        minstring += arr[0,j];
    }
    return minstring;
}

int String(int[,] arr, int i) 
{ 
    int minstring = Sum(arr,0);
    int iminstring = 0;
    int sum = 0;
    int min = 0;
    for (int j = 1; j < arr.GetLength(1); j++) // сумма значений 2-й и последующих строк
    {
        sum += arr[i,j];        
        if(sum < minstring)  // поиск мин строки
        {
            min = sum;
            iminstring = i+1; 
        }
        min = minstring;
        iminstring = i+1;
        i++;
    }
    Console.WriteLine($"{iminstring}");    

    return iminstring;
}


int[,] array= new int[4,4]; // если задаю размер массива [2,4] - ошибка 
                            //Index was outside the bounds of the array.
FillArray(array);           
Sum(array, 0);
String(array,0); 
