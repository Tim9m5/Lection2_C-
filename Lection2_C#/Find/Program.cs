// Task_Find
// int[] array = { 1, 12, 31, 4, 18, 15, 16, 17, 18 };

// int n = array.Length;
// int find = 18;

// int index = 0;
// while (index < n)
// {

//     if (array[index]==find)
//     {
//         Console.WriteLine(index);
//         break; //останавливает выполнение цикла после первого найденного соответствия, 
//         //если убрать эту строку то выдаст два значения т.к в массиве два числа 18.
//     }    
//     // index = index+1
//     index++;
//  }


//Task_find2

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если мы ищем элемент которого точно не существует, например 444
    // то программа выдаст нам значение position по умолчанию т.е. -1, если мы поставим 
    // int position = 0 то будет выдываться 0 и будет непонятно почему он выдал 0, хотя значение 
    // в ячейке с индексом 0 другое. 
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10]; // new int [n] - создать новый массив в котором будет n элементов, по умолчанию нули

FillArray(array); // заполнить массив
array[4] = 4; // принудительно(искусственно) добавили 4 на 4 позицию
array[6] = 4; // принудительно(искусственно) добавили 4 на 6 позицию
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 444);
Console.WriteLine(pos);