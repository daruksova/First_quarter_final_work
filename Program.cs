// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с 
// клавиатуры, либо задать на старте выполнения алгоритма. 

string[] ReadString()
{
    Console.Write("Введите исходный массив строк: ");
    string[] arr = Console.ReadLine().Split(" ");
    return(arr);
}

void PrintArray(string[] arr)
{
    Console.WriteLine("[" + String.Join(", ", arr) + "]");
}

string[] array = ReadString();
PrintArray(array);