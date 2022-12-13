//
/*
    Написать программу, которая из имеющегося массивастрок формирует
    массив из строк, длина которых меньше либо равна трём символам.
    Первоначальный массив можно ввести с клавиватуры, либо
    задать на страте выполнения алгоритма. При решении не 
    рекомендуется использовать коллекции, лучше обойтись
    исключиьельно массивами.
*/


/* Формирование массива */

string Get_Array(string a){
    a = Console.ReadLine();
    return a;
}

int size = int.Parse(Console.ReadLine());
int count = 0;
int size2 = -1;

string[] arr = new string[size];

for (int i = 0; i < size; i++){
    arr[i] = Get_Array(arr[i]);
}

for (int i = 0; i < size; i++){
    if (arr[i].Length <= 3){
        count++;
    }
}

Console.WriteLine(count);

string[] farr = new string[count];

if (count == 0){
    Console.WriteLine(farr);
} else {
    for (int i = 0; i <= size; i++){
        if (arr[i].Length <= 3){
            size2++;
            farr[size2] = arr[i];
        }
    }
    Console.WriteLine(farr);
}