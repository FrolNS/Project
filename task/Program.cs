/*
Написать программу, которая из имеющегося массива строк
формирует массив из строк, длина которых меньше либо равна 3 символа.
Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.
*/
int SizeOfNewArray(string[] userArray)
{
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if(userArray[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}

string[] NewArray(string[] userArray, int size)
{
    string[] newArray = new string[size];
    int count = 0;
    for (int i = 0; i < userArray.Length; i++)
    {
        if(userArray[i].Length <= 3)
        {
            newArray[count] = userArray[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] arrayFromUser)
{
    Console.Write("[");
    for (int i = 0; i < arrayFromUser.Length; i++)
    {
        Console.Write(arrayFromUser[i]);
        if (i < arrayFromUser.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

string[] ArrayFromUser(int length)
{
    Console.WriteLine("Введите строки");
    string[] userArray = new string[length];
    for (int i = 0; i < length; i++)
    {
        userArray[i] = Console.ReadLine();
    }
    return userArray;
}

Console.WriteLine("Введите длину массива");
int sizeOfArray = Convert.ToInt32(Console.ReadLine());
string[] array = ArrayFromUser(sizeOfArray);
PrintArray(array);
int sizeOfNewArray = SizeOfNewArray(array);
string[] newArray = NewArray(array, sizeOfNewArray);
PrintArray(newArray);