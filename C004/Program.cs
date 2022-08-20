int SumNumbers(int number)
{
// Базовый случай
if (number == 0) return 0;
// number постоянно делится на 10 нацело
// если число при делении на 10 дает 0 целых, то мы подсчитали
// цифры
return (number % 10 + SumNumbers(number / 10));
}
Console.WriteLine(SumNumbers(45));
