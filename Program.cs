// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 

// Записывает введенный с клавиатуры массив строк
string[] ReadString()
{
    Console.Write("Введите исходный массив строк: ");
    string[] arr = Console.ReadLine().Split(" ");
    return(arr);
}

// Выводит массив в консоль
void PrintArray(string[] arr)
{
    Console.WriteLine("[" + String.Join(", ", arr) + "]");
}

// Считает количество элементов массива длиной <= 3 символа
int ResultArrayLength(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] array = ReadString();
PrintArray(array);
System.Console.WriteLine(ResultArrayLength(array));