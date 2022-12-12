//Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.




void PrintArray(string[] array)

{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

string[] array = { "cat", "задание", "777777", "Ирина", "hello", "Moscow", "2t", "вау", "1o1o1o" };
string[] array1 = new string[array.Length];

int j = 0;
for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
     array1[j] = array[i];
        j++;
    }

Array.Resize(ref array1, j);
Console.Write("Имеющийся массив: ");
PrintArray(array);
Console.WriteLine();
Console.Write("Новый массив: ");
PrintArray (array1);
