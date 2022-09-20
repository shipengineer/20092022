/*
int[,] FillMas(int n, int m)
{
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {

        for (int j = 0; j < m; j++)
        {
            mas[i, j] = new Random().Next(-10, 11);
        }

    }

    return mas;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

System.Console.Write("Введите количество строк n = ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов m = ");
int m = Convert.ToInt32(Console.ReadLine());
*/
int SumDiagonal(int[,] mas, int n, int m)
{
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            if (i == j)
            {
                sum += mas[i, j];
            }
        }
    }
    return sum;
}
int[,] newArray = FillMas(n, m);
PrintArray(newArray);
System.Console.WriteLine(SumDiagonal(newArray, n, m));
/*
**задача 2 HARD необязательная.** 
 Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры) , причем чтоб количество элементов было четное. Вывести на экран красивенько таблицей. Перемешать случайным образом элементы массива, причем чтобы каждый гарантированно переместился на другое место (возможно для этого удобно будет использование множества) и выполнить это за m*n / 2 итераций. То есть если массив три на четыре, то надо выполнить не более 6 итераций. И далее в конце опять вывести на экран как таблицу.
 
 */

// 1 проверка на четнность элементов

// 2 написать функцию обмена мест
/*
void Swap(ref int leftItem, ref int rightItem) // меняет местами элементы по заданному адресу
{
    int temp = leftItem;

    leftItem = rightItem;

    rightItem = temp;
}
//после пермещения занести значение в массив двухмерный с нетрогаемыми индексами
int[,] RndMas(int[,] mas, int n, int m)
{
    int k = new Random().Next(0, n);
    int r = new Random().Next(0, m);
    int[,] ignore = new int[n * m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < length; j++)
        {
            if(ignore[i,j]) 
            ignore[i,j] = false
        }
    }
}
*/
//Создание и инициализация массива
int[,] srcArray = new int[5, 7];
int i = 0;
for (int r = 0; r < srcArray.GetLength(0); r++)
{
    for (int c = 0; c < srcArray.GetLength(1); c++)
    {
        i++;
        srcArray[r, c] = i;
    }
}
//Вывод исходного состояния
Console.WriteLine("массив перед смешиванием");
printArray(srcArray);
Console.WriteLine("массив после смешивания");
//Смешивание
mix(srcArray);
//Вывод смешанного массива
printArray(srcArray);
Console.ReadKey();

/// <summary>
/// Смешивание элементов(основной алгоритм)
/// </summary>
/// <param name="srcArray"></param>
void mix(int[,] srcArray)
{
    var rnd = new Random();
    for (var i = 0; i < srcArray.Length * 10; i++)
    {
        int r1 = rnd.Next(0, srcArray.GetLength(0)),
            r2 = rnd.Next(0, srcArray.GetLength(0)),
            c1 = rnd.Next(0, srcArray.GetLength(1)),
            c2 = rnd.Next(0, srcArray.GetLength(1));
        int temp = srcArray[r1, c1];
        srcArray[r1, c1] = srcArray[r2, c2];
        srcArray[r2, c2] = temp;
    }
}
/// <summary>
/// Вывод массива на консоль
/// </summary>
/// <param name="srcArray"></param>
static void printArray(int[,] srcArray)
{
    for (int r = 0; r < srcArray.GetLength(0); r++)
    {
        for (int c = 0; c < srcArray.GetLength(1); c++)
        {
            var cur = srcArray[r, c].ToString();
            cur = cur.Length == 2 ? cur : (" " + cur);
            Console.Write(cur + " ");
        }
        Console.WriteLine();
    }
}

