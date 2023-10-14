﻿// Метод ищет позицию заданного элемента массива 
int IndexOf(int[] collection, int find)
{
   int count = collection.Length;
   int index = 0;
   int position = -1; 
   while (index < count)
   {
    if(collection[index] == find)
    {
        position = index;
        break;
    } 
    index = index + 1;
   }
   return position;
}

// Метод заполняет массив collection случайными числами:
void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index = index + 1;
    }
}

// Метод распечатывает элементы массива:
void PrintArray(int[] col)
{
   int count = col.Length;
   int position = 0;
   while(position < count)
   {
    Console.WriteLine(col[position]);
    position = position + 1;
    
   }
}

// Задаём массив и применяем эти методы:
int[] array = new int[10];
FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);

Console.WriteLine("Проверим первый метод");

int pos = IndexOf(array, 444);
Console.WriteLine(pos);