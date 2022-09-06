// Напишите программу, которая будет выдавать название дня недели по заданному номеру.
// 	3 -> Среда 
// 5 -> Пятница

// Console.WriteLine("Введите номер дня недели");
// string day = Console.ReadLine();

// if (day == "1") Console.WriteLine("Понедельник");
// else if (day == "2") Console.WriteLine("Вторник");
// else if (day == "3") Console.WriteLine("Среда");
// else if (day == "4") Console.WriteLine("Четверг");
// else if (day == "5") Console.WriteLine("Пятница");
// else if (day == "6") Console.WriteLine("Суббота");
// else if (day == "7") Console.WriteLine("Воскресенье");
// else Console.WriteLine("Такого не бывает");

Console.WriteLine("Введите число от 1 до 7:");
int a = int.Parse(Console.ReadLine());
string[] weekDays = new string[] { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (a > 0 && a < 8)
{
  Console.WriteLine(weekDays[a - 1]);
}
else
{
  Console.WriteLine("Нет такгого дня");
}





