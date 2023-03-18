// Задача 41 
// string Vozrnum(string numb)
// {

//     string [] array = numb.Split(",");
//     int count = 0;
//     foreach(var el in array)
//     {
//         int convEl = Convert.ToInt32(el);
//         if(convEl > 0) count++;
//     }
//     string result = $"{string.Join(", ", array)} -> {count}";
//     return result;

// }

// Console.WriteLine("Введите числа через запятую: ");
// string num = Console.ReadLine();
// Console.WriteLine(Vozrnum(num));

// Задача 43
Console.WriteLine("введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"две прямые пересекутся в точке {x},{y}");