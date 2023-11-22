#nullable enable
using System;

Calculator calculator = new Calculator();

double resultAdd = Calculate(calculator.Add, 5, 3);
Console.WriteLine($"Сложение: 5 + 3 = {resultAdd}");

double resultSubtract = Calculate(calculator.Subtract, 8, 4);
Console.WriteLine($"Вычитание: 8 - 4 = {resultSubtract}");

double resultMultiply = Calculate(calculator.Multiply, 6, 2);
Console.WriteLine($"Умножение: 6 * 2 = {resultMultiply}");

double resultDivide = Calculate(calculator.Divide, 9, 3);
Console.WriteLine($"Деление: 9 / 3 = {resultDivide}");


double resultDivideByZero = Calculate(calculator.Divide, 7, 0);
Console.WriteLine($"Деление на ноль: 7 / 0 = {resultDivideByZero}");


double Calculate(Func<double, double, double> operation, double a, double b)
{
    return operation(a, b);
}

public class Calculator
{

    public double Add(double a, double b) => a + b;
    public double Subtract(double a, double b) => a - b;
    public double Multiply(double a, double b) => a * b;

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Ошибка: Деление на ноль!");
            return 1;
        }
        return a / b;
    }
}

