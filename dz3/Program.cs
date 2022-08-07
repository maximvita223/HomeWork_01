Console.Clear();

Console.WriteLine("Введите число : ");

int a = Int32.Parse(Console.ReadLine());
                
if (a % 2 == 0) 
Console.Write("Четное");
                
else 
Console.Write("Нечетное");