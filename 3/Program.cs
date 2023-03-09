// Задача 38: Задайте массив целых чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
int[] array = GetRandomArray(4, 0, 99);
Console.WriteLine($"[{string.Join(", ",array)}] -> {DifferenceMaxMin(array)}");

int[] GetRandomArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i = 0; i < size; i++){
        result[i] = new Random().Next(minValue, maxValue + 1);}
    return result;}

int DifferenceMaxMin(int[] array){
    int max = array[0];
    int min = array[0];
    foreach(int el in array){
        max = el > max ? el : max; // if (el>max) max = el;
        min = el < min ? el : min;} // if (el<min) min = el;
    int result = max - min;
    return result;}