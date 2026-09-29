int lessonNumber = 1;
int totalLessons = 5;

while (lessonNumber <= totalLessons)
{
    Console.WriteLine($"Пара {totalLessons}");
    totalLessons -= 1;
}

Console.WriteLine("Пары закончились");

//2
Console.WriteLine("Введите оценки по одной, для завершения введите -1");
int grade = int.Parse(Console.ReadLine());
int count = 0;

while (grade != -1)
{
    Console.WriteLine($"Оценка принята: {grade}");
    count++;
    grade = int.Parse(Console.ReadLine());
}

Console.WriteLine("Вход завершён");
Console.WriteLine($"Количество введенных оценок: {count}");

// 