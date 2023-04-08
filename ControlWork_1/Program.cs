/*
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
    [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
    [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
    [“Russia”, “Denmark”, “Kazan”] → []
*/


string[] ArrayString() //Первый метод - для заполнения массива данными
{
    Console.WriteLine("Введите количество строк");
    int num = Convert.ToInt32(Console.ReadLine());
    string[] strArray = new string[num];
    string str = String.Empty;

    Console.WriteLine("Введите строку: ");
    for (int i = 0; i < strArray.Length; i++) strArray[i] = Console.ReadLine()!;
    return strArray;
}
ArrayString();
Console.WriteLine();