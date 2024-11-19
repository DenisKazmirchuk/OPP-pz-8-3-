using System;

class Program
{
    // Універсальний делегат для арифметичних операцій
    public delegate double ArithmeticOperation(double a, double b);

    static void Main()
    {
        // Зчитуємо два числа від користувача
        Console.WriteLine("Введіть перше число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Введіть друге число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        // Запитуємо тип операції
        Console.WriteLine("Виберіть операцію: (+, -, *, /)");
        string operation = Console.ReadLine();

        // Створення змінної делегата, який буде вказувати на відповідну операцію
        ArithmeticOperation arithmeticOperation = null;

        // Вибір операції за допомогою умов
        switch (operation)
        {
            case "+":
                arithmeticOperation = Add;
                break;
            case "-":
                arithmeticOperation = Subtract;
                break;
            case "*":
                arithmeticOperation = Multiply;
                break;
            case "/":
                if (num2 == 0)
                {
                    Console.WriteLine("Помилка: на нуль ділити не можна!");
                    return;
                }
                arithmeticOperation = Divide;
                break;
            default:
                Console.WriteLine("Невірна операція!");
                return;
        }

        // Викликаємо делегат для виконання операції
        double result = arithmeticOperation(num1, num2);

        // Виводимо результат
        Console.WriteLine($"Результат операції {num1} {operation} {num2} = {result}");
    }

    // Метод для додавання
    static double Add(double a, double b)
    {
        return a + b;
    }

    // Метод для віднімання
    static double Subtract(double a, double b)
    {
        return a - b;
    }

    // Метод для множення
    static double Multiply(double a, double b)
    {
        return a * b;
    }

    // Метод для ділення
    static double Divide(double a, double b)
    {
        return a / b;
    }
}
