﻿// Найти максимальное значение из 9ти, функция

int Max(int arg1, int arg2, int arg3) // в arg подставляются соответствующее переменные того же типа
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result; // Возвращает значение в MAX
}
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 11;
int b2 = 14;
int c2 = 25;
int a3 = 22;
int b3 = 100;
int c3 = 10;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);

int max = Max(Max(a1, b1, c1),Max(a2, b2, c2), Max(a3, b3, c3));//короткая версия кода выше


Console.WriteLine(max);