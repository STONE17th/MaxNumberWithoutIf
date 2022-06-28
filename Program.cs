Console.Clear();
Console.Write("Введите первое число: ");
int Number1 = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите второе число: ");
int Number2 = int.Parse(Console.ReadLine() ?? "0");

int NumDiffPos = Number1 - Number2;
int NumDiffNeg = Number1 - Number2;
int TestNum = 1;

while (true)
{
    try 
    {
        TestNum = 1/NumDiffPos;
    }
    catch
    {
        Console.WriteLine($"Максимальное число {Number2}");
        break;
    }
    try 
    {
        TestNum = 1/NumDiffNeg;
    }
    catch
    {
        Console.WriteLine($"Максимальное число {Number1}");
        break;
    }
    NumDiffPos++;
    NumDiffNeg--;
}