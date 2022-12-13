//
/*
    Написать программу, которая из имеющегося массива строк формирует
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
int size2 = 0;

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

string[] Fun_arr(string[] mas){
    for (int i = 0; i < mas.Length; i++){
        if (mas[i].Length <= 3){
            farr[size2] = mas[i];
            size2++;
        }
    }
    return farr;
}

if (count == 0){
    Console.WriteLine("В массиве нет строк меньше либо равных трём.");
} else {
    Fun_arr(arr);
    for (int i = 0; i < farr.Length; i++){
        Console.Write("{0} ", farr[i]);
    }
    
}