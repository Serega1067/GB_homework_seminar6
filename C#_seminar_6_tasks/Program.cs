/*
Задача 1.
Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел 
больше 0 ввёл пользователь.
*/

int[] NumInput(int arg)
{
    int[] resultArr = new int[arg];
    for (int i = 0; i < arg; i++)
    {
        resultArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return resultArr;
}

int CountNumGreaterThanZero(int[] arg)
{
    int count = 0;
    foreach (int i in arg)
    {
        if (i > 0) count++;
    }
    return count;
}

Console.WriteLine("\nВведите число сколько чисел нужно ввести с " +
                  "клавиатуры: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите {m} чисел: ");
int[] arrNumInput = NumInput(m);
int countNum = CountNumGreaterThanZero(arrNumInput);
Console.WriteLine($"Вы ввели {countNum} чисел больше 0\n");

/*
Задача 2.
Пользователь вводит с клавиатуры кол-во строк и столбцов для массива. 
Вывести массив в виде матрицы, создав "рамку" из единиц, а 
внутреннюю зону матрицы заполнить нулями.
*/

/*
void DrawMatrix(int arg1, int arg2)
{
    int[,] arr = new int[arg1, arg2];
    for (int i = 0; i < arg1; i++)
    {
        for (int j = 0; j < arg2; j++)
        {
            if (i == 0 || i == arg1 - 1 || j == 0 || j == arg2 - 1)
            {
                arr[i, j] = 1;
                Console.Write(arr[i, j]);
            }
            else
            {
                arr[i, j] = 0;
                Console.Write(arr[i, j]);
            }
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());

DrawMatrix(row, column);
*/
