/// start = 1 - начальная точка
/// end - N - конец
// [1;N]
string PrintNumbers (int start, int end)
{
// Базовый случай
if (start == end) return start.ToString();
// Рекурсивный случай
return (start + ", " + PrintNumbers(start+1, end));
}

int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(1, N));