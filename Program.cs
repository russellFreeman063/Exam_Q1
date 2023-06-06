// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] CreateArrayWithMaxElementLength(string[] array, int max)
{
    string[] newArray = new string[array.Length];
    int j = 0;
    for(int i = 0; i < array.Length; i++)
        if(array[i].Length > 0 && array[i].Length <= max)
            {
                newArray[j] = array[i];
                j++;
            }
    return newArray;
}

void ShowStringArray(string[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

string[] myArray = {"123", "GeekBrains", "", "Test", "Go"};
int max = 3;
string[] newArray = CreateArrayWithMaxElementLength(myArray, max);
ShowStringArray(newArray);
