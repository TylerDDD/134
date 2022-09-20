// Задача номер 64.

int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M, N));

// Задача номер 68.

/* Console.WriteLine("Введите два положительных числа: M и N.");
int m = InputInt("Введите M: ");
int n = InputInt("Введите N: ");
Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
} */


// Задача номер 66.

/* int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n} = {CountNaturalSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountNaturalSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountNaturalSum(m, n - 1);
}  */


