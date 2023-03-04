// Создать массив, заполнить случайными числами и вывести на печать.
void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) //будет печатать массив
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int[] array = new int[10];//создать случ массив. ПО умолчанию заполнен случайными числами.

FillArray(array);
PrintArray(array);

// 1) мы определили длину массива int[] array = new int[10]
// 2) вызвали метод, который заполнил нам макссив FillArray(array);
// 3) вывели в консоль массив
