
// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// пользователь вводит число элементов в массиве и минимальное, и максимальное значение . 
// надо заполнить массив рандоными данными от минимального до максимального значение .И важное уточнениее , 
// делать все в методе который возвращает массив


int[] GetArrey(int n, int min, int max)
{
       
    int[] arr = new int[n];
    for (int i = 0; i < n; i++)
    {
        arr[i] = new Random().Next(min, max);
    }


    for (int i = 0; i < n - 1; i++)
    {
        int minPos = i;
        for (int j = i + 1; j < n; j++)
        {
            if (arr[minPos] > arr[j])//выстраивает от меньшего к большему
            if(array[minPos] < array[j])//выстраивает от большего к меньшему
            {
                minPos = j;
            }
        }

        int temp = arr[minPos];
        arr[minPos] = arr[i];
        arr[i] = temp;
    }

    for (int i = 0; i < n; i++)
    {
        System.Console.WriteLine($"{arr[i]}");
    }
    
    return arr;
}

System.Console.WriteLine("№29 input n");
int n = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("№29 input min");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("№29 input max");
int max = Convert.ToInt32(Console.ReadLine());


GetArrey(n, min, max);

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double RaiseToDegree(double A, int B)
{
    return Math.Pow(A,B);
}
System.Console.WriteLine("№25 input A");
int A = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("№25 input B");
int B = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine(RaiseToDegree(A,B));

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10

double SummOfDigit(int num)
{
    int result = 0;
    while  (num != 0)
    {
        result = result + num % 10;
        num = num/10; 
    }
  
return result;
}

System.Console.WriteLine(SummOfDigit (452));
 