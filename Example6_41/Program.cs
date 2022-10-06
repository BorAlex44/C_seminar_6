using static System.Console;
Clear();
WriteLine("Введите размер массива: ");
int size = int.Parse(ReadLine()!);
int[] array = GetArray(new int[size]);
WriteLine($"[{String.Join(" ", array)}]");
GetMinus(array);




int[] GetArray(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        WriteLine("Введите число: ");
        number[i] = int.Parse(ReadLine()!);
    }
    return number;
}

void GetMinus(int[] NewArray)
{
    int count = 0;
    for (int i = 0; i < NewArray.Length; i++)
    {
        if (NewArray[i] < 0)
        {
            count++;
        }
    }
    WriteLine($"Количество чисел меньше нуля введенные пользователем равно {count}");
}