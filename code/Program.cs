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
        string curValue = Console.ReadLine();           // считываем введенное значение из консоли
        inputArray[i] = curValue;                       // записываем его во воходной массив
        if (curValue.Length < minLength)                // если его длина меньше пороговой для "коротких строк" - считаем сколько введено таких элементов чтобы создать массив выходных значений
            outValuesCount++;
    }
    return outValuesCount;                              // возвращаем количество введенных коротких строк        
}

Console.Clear();
Console.WriteLine("Сколько строк будем вводить?");                                                  // задаем длину входного массива
int inputValuesCount = Int32.Parse(Console.ReadLine());
Console.WriteLine("Сколько символов должно быть в строке чтобы она уже не считалась короткой?");    // задаем пороговое значение длины строки для занесения в результирующий массив
int minLength = Int32.Parse(Console.ReadLine());
string[] inputArray = new string[inputValuesCount];
string[] outArray = new string[FillInputArray(inputArray, minLength)];                              // создаем выходной массив длиной по числу введенных коротких строк
int j = 0;
for (int i = 0; i < inputValuesCount; i++)                                                          // для каждого элемента входного массива - если он короче чем заданное пороговое значение 
{
    if (inputArray[i].Length < minLength)
    {
        outArray[j] = inputArray[i];                                                                // записываем его в выходной массив
        j++;
    }
}

Console.WriteLine($"[{string.Join(", ", inputArray)}]");        //результирующий вывод массивов в консоль
Console.WriteLine($"[{string.Join(", ", outArray)}]");