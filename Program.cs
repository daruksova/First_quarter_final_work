// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 

// Записывает введенный с клавиатуры массив строк
string[] ReadString()
{
    Console.Write("Введите исходный массив строк: ");
    string[] arr = Console.ReadLine()!.Split(" ");
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

// Создает массив, в котором будут храниться все значения длиной <= 3
string[] InitialResultArray(string[] arr, int newArrayLength)
{
    string[] resultArray = new string[newArrayLength];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            resultArray[count] = arr[i];
            count++;
        }
    }
    return resultArray;
}

string[] array = ReadString();
Console.Write("Исходный массив: ");
PrintArray(array);
string[] resultArray = InitialResultArray(array, ResultArrayLength(array));
Console.Write("Конечный массив: ");
PrintArray(resultArray);