// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Prompt(string message)
{
    System.Console.Write(message);
    string readInput = System.Console.ReadLine()!;
    int result = Convert.ToInt32(readInput);
    return result;
}

int InPower(int a, int b)
{
    int result = 1;
    for(int i = 1; i <= b; i++)
    {
        result *= a; // result = result * a;
    }
    return result;
}

bool ExpCheck(int exponent)
{
    if(exponent < 0)
    {
        System.Console.WriteLine("Степень не должна быть отрицательной!");
        return false;
    }
    return true;
}

int A = Prompt("Input number A: ");
int B = Prompt("Input number B: ");
if(ExpCheck(B))
{
    System.Console.WriteLine($"Number A={A} in power of B={B} = {InPower(A,B)}");
}

