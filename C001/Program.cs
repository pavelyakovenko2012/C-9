// Factorial
// 4! = 4*3*2*1
// number = 4 до 1
int Factorial(int number)
{
if (number == 1) return 1;
return number * Factorial(number - 1);
}
Console.WriteLine(Factorial(4));

// Базовый случай: условие выхода из рекурсии
// Рекурсивный случай: вызов функции из функции