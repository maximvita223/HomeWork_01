Console.Clear();

Console.Write("введите 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("введите 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
    Console.Write($"Число {num1} больше {num2}");
else
    Console.Write($"Число {num1} меньше {num2}");