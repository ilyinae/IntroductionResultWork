// Задача:
// Написать программу, которая из имеющегося массива строк формирует массив строк, длина которых
// меньше или равна 3 символа. Первоначальный алгоритм можно ввести с клавиатуры, либо задать на
// старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше
// обойтись исключительно массивами.

int FillInputArray(string[] inputArray, int minLength)
{
    int outValuesCount = 0;
    for (int i = 0; i < inputArray.Count(); i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент массива:");
        string curValue = Console.ReadLine();
        inputArray[i] = curValue;
        if (curValue.Length < minLength)
            outValuesCount++;
    }
    return outValuesCount;
}
Console.Clear();
Console.WriteLine("Сколько строк будем вводить?");
int inputValuesCount = Int32.Parse(Console.ReadLine());
Console.WriteLine("Сколько символов должно быть в строке чтобы она уже не считалась короткой?");
int minLength = Int32.Parse(Console.ReadLine());
string[] inputArray = new string[inputValuesCount];
string[] outArray = new string[FillInputArray(inputArray, minLength)];
int j = 0;
for (int i = 0; i < inputValuesCount; i++)
{
    if (inputArray[i].Length < minLength)
    {
        outArray[j] = inputArray[i];
        j++;
    }
}
Console.WriteLine($"[{string.Join(", ", inputArray)}]");
Console.WriteLine($"[{string.Join(", ", outArray)}]");