// Задача 41
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите количество чисел:");
//         int m = int.Parse(Console.ReadLine()); // Считываем количество чисел, которые введет пользователь

//         int count = 0; // Количество чисел, больших 0

//         Console.WriteLine("Введите числа:");
//         for (int i = 0; i < m; i++)
//         {
//             int num = int.Parse(Console.ReadLine()); // Считываем число, которое вводит пользователь

//             if (num > 0) // Проверяем, больше ли введенное число 0
//             {
//                 count++;
//             }
//         }

//         Console.WriteLine($"Количество чисел, больших 0: {count}");
//     }
// }

// Задача 43
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Введите параметры первой прямой:");
//         Console.Write("k1 = ");
//         double k1 = double.Parse(Console.ReadLine()); // Считываем коэффициент k1

//         Console.Write("b1 = ");
//         double b1 = double.Parse(Console.ReadLine()); // Считываем коэффициент b1

//         Console.WriteLine("Введите параметры второй прямой:");
//         Console.Write("k2 = ");
//         double k2 = double.Parse(Console.ReadLine()); // Считываем коэффициент k2

//         Console.Write("b2 = ");
//         double b2 = double.Parse(Console.ReadLine()); // Считываем коэффициент b2

//         double x = (b2 - b1) / (k1 - k2); // Вычисляем x-координату точки пересечения
//         double y = k1 * x + b1; // Вычисляем y-координату точки пересечения

//         Console.WriteLine($"Точка пересечения прямых: ({x}; {y})");
//     }
// }
