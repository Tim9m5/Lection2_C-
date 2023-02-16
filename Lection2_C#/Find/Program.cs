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
    while (index<length)
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

int [] array = new int[10]; // new int [n] - создать новый массив в котором будет n элементов, по умолчанию нули

FillArray (array);
PrintArray (array);