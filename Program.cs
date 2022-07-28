/*
Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
 меньше либо равна 3-м символам. Первоначальный массив можно ввести с клавиатуры, либо задать
 на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
*/

int Prompt(string message) // Ввод числа ( функция )
{
    Console.Write(message);

    return int.Parse(Console.ReadLine());
}

string[] ReadAmountVariables(int amountVariables) // Заполнение массива переменными string 
{
    string[] array = new string[amountVariables];
    for (int i = 0; i < amountVariables; i++)
    {
        Console.Write($"Введите переменную {i + 1} => ");
        array[i] = Console.ReadLine();
    }
    return array;
}

void WriteArrayString(string[] array) // Вывод массива переменных string в консоль 
{
    int lengthArray = array.Length;

    for (int i = 0; i < lengthArray; i++)
    {
        if (i == 0) System.Console.Write("[ ");
        if (i < lengthArray - 1) System.Console.Write(array[i] + ", ");
        if (i == (lengthArray - 1)) System.Console.WriteLine(array[i] + " ]");
    }

}

(string[], bool) VariableLengthLessThree(string[] array, int size) // 
{
    int indexNewArray = 0;
    int lngthArray = array.Length;
	bool notFilled = false;

    for (int i = 0; i < lngthArray; i++)
    {
        if (array[i].Length <= size) indexNewArray++;
    }

    string[] newArray = new string[indexNewArray];

    if (indexNewArray == 0) return (newArray, notFilled);

    indexNewArray = 0;

    for (int j = 0; j < lngthArray; j++)
    {
        if (array[j].Length <= size)
        {
            newArray[indexNewArray] = array[j];
            indexNewArray++;
        }

    }
    notFilled=true;
    return (newArray, notFilled);
}


string text1 = "Введите количество строчных переменных от 1 до 10 => ";
int amountVariables = Prompt(text1);

while (1 > amountVariables || amountVariables > 10)
{
    amountVariables = Prompt(text1);
}

string[] array = ReadAmountVariables(amountVariables);

int checkLength = 3; // 
(string[] newArray, bool statusVariableThree) = VariableLengthLessThree(array, checkLength);

System.Console.WriteLine();

if (statusVariableThree==true) WriteArrayString(newArray);
else System.Console.Write("Введенных  переменных нет значений с количеством символов меньше или равно 3. ");

System.Console.WriteLine();



