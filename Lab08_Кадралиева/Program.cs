// // 1
// int lessonNumber = 5;
// while (lessonNumber >= 1)
// {
//     Console.WriteLine($"Пара {lessonNumber}");
//     lessonNumber--;
// }
// Console.WriteLine("Пары закончились");

// // 2
// Console.WriteLine();
// Console.WriteLine("Введите оценки по одной, для завершения введите -1");
// int grade = int.Parse(Console.ReadLine());
// int count2 = 0;

// while (grade != -1)
// {
//     Console.WriteLine($"Оценка принята: {grade}");
//     count2++;
//     grade = int.Parse(Console.ReadLine());
// }

// Console.WriteLine("Ввод завершён");
// Console.WriteLine($"Количество введённых оценок: {count2}");

// // 3
// Console.WriteLine();
// int sum3 = 0;
// int count3 = 0;
// int max = int.MinValue;

// Console.WriteLine("Вводите оценки, для завершения введите -1:");
// int grade3 = int.Parse(Console.ReadLine());

// while (grade3 != -1)
// {
//     sum3 += grade3;
//     count3++;
//     if (grade3 > max)
//     {
//         max = grade3;
//     }
//     grade3 = int.Parse(Console.ReadLine());
// }

// if (count3 > 0)
// {
//     Console.WriteLine($"Средний балл: {(double)sum3 / count3}");
//     Console.WriteLine($"Наибольшая оценка: {max}");
// }
// else
// {
//     Console.WriteLine("Оценок не было введено");
// }

// // 4
// Console.WriteLine();
// string correctPassword = "qwerty123";
// int failedAttempts = 0;

// while (true)
// {
//     Console.Write("Введите пароль от личного кабинета: ");
//     string password = Console.ReadLine();

//     if (password == correctPassword)
//     {
//         Console.WriteLine("Доступ разрешён");
//         break;
//     }

//     failedAttempts++;
//     Console.WriteLine("Неверный пароль, попробуйте снова");
// }

// Console.WriteLine($"Количество неудачных попыток: {failedAttempts}");

// // 5
// Console.WriteLine();
// string answer;

// do
// {
//     Console.Write("Введите дату посещения (например, 01.09): ");
//     string date = Console.ReadLine();
//     Console.WriteLine($"Запись добавлена: {date}");

//     Console.Write("Добавить ещё одну запись? (да/нет): ");
//     answer = Console.ReadLine();
// } while (answer == "да");

// Console.WriteLine("Дневник сохранён");

// // Задача А
// Console.WriteLine();
// int N = 5;
// int i = 1;
// while (i <= 10)
// {
//     Console.WriteLine($"{N} × {i} = {N * i}");
//     i++;
// }

// // Задача В
// Console.WriteLine();
// int totalPages = 0;
// int days = 0;

// Console.WriteLine("Введите страницы за день (для завершения -1):");
// int pages = int.Parse(Console.ReadLine());

// while (pages != -1)
// {
//     totalPages += pages;
//     days++;
//     pages = int.Parse(Console.ReadLine());
// }

// Console.WriteLine($"Всего прочитано: {totalPages} страниц за {days} дней");


// // Индивидуальное задание
// Console.WriteLine();
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine().Trim();

// if (string.IsNullOrEmpty(surname))
// {
//     Console.WriteLine("Фамилия не введена. Завершение работы.");
//     return;
// }

// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);

// var assigned = Enumerable.Range(1, 10)
//     .OrderBy(_ => rnd.Next())
//     .Take(2)
//     .OrderBy(x => x)
//     .ToList();

// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");

// Вариант 1. Обратный отсчёт
Console.WriteLine();
int n1 = 5;   

while (n1 >= 1)
{
    Console.WriteLine(n1);
    n1--;
}
Console.WriteLine("Старт!");

// Вариант 8. Три попытки входа
Console.WriteLine();
string correctPass8 = "6767";
int attempts = 0;

while (attempts < 3)
{
    Console.Write("Введите пароль: ");
    string entered = Console.ReadLine();

    if (entered == correctPass8)
    {
        Console.WriteLine("Доступ разрешён");
        break;
    }

    attempts++;
    Console.WriteLine($"Неверный пароль. Осталось попыток: {3 - attempts}");
}

if (attempts == 3)
{
    Console.WriteLine("Доступ заблокирован");
}