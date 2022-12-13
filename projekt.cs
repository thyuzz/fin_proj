/*
    Написать программу, которая из имеющегося массива строк формирует
    массив из строк, длина которых меньше либо равна трём символам.
    Первоначальный массив можно ввести с клавиватуры, либо
    задать на страте выполнения алгоритма. При решении не 
    рекомендуется использовать коллекции, лучше обойтись
    исключиьельно массивами.
*/

/* функция заполнения массива */
string Get_Array(string a){
    a = Console.ReadLine();
    return a;
}

/* объявление переменных и массива*/
int size = int.Parse(Console.ReadLine());
int count = 0;
int size2 = 0;
string[] arr = new string[size];

/* вызов функции для заполнения массива и поиск количества удовлетворяющих условию элементов */
for (int i = 0; i < size; i++){
    arr[i] = Get_Array(arr[i]);
    if (arr[i].Length <= 3){
        count++;
    }
}

string[] farr = new string[count];

/* функция заполняющая второй массив, в котором содержаться только удовлетворяющие условию элементы */
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
    farr[0] = " ";
    Console.WriteLine(farr[0]);
} else {
    Fun_arr(arr);
    for (int i = 0; i < farr.Length; i++){
        Console.Write("{0} ", farr[i]);
    }
}