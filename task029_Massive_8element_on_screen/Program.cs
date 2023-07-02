// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine()!;
    int result = Convert.ToInt32(readInput);
    return result;
}

int[] RandomMassive(int length, int ran_min,int ran_max)
{
    int[] array = new int[length]; //объявили массив, задали ему длину
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(ran_min,ran_max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    for(int i = 0; i < array.Length - 1; i++)
    {
        System.Console.Write($"{array[i]}, "); //доходим до предпоследнего элемента
    }
    System.Console.Write($"{array[array.Length - 1]}");//выводим последний элемент, избавляемся от запятой 
    System.Console.Write("]");
}

int length = Prompt("Input massive length: ");
int random_min = Prompt("Input random_min: ");
int random_max = Prompt("Input random_max: ");

int[] array = RandomMassive(length, random_min, random_max);//заполняем массив
PrintArray(array);