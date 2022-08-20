int Power(int number, int degree)
{
// Базовый степень
if (degree == 1) return number; // 5^1 = 5
if (degree == 0) return 1;
// Рекурсивный случай
return (number * Power(number, degree - 1));
}
System.Console.WriteLine(Power(3,5));
