// часть 1 и часть 2
// Weather weather = Weather.Rainy;

// Console.WriteLine(weather);
// Console.WriteLine((int)weather);
// switch (weather)
// {
//     case Weather.Sunny:
//         Console.WriteLine("Солнечно: возьми солнечные очки.");
//         break;

//     case Weather.Cloudy:
//         Console.WriteLine("Облачно: возьми лёгкую куртку.");
//         break;

//     case Weather.Rainy:
//         Console.WriteLine("Дождь: возьми зонт.");
//         break;

//     case Weather.Snowy:
//         Console.WriteLine("Снег: оденься тепло.");
//         break;
// }
// enum Weather
// {
//     Sunny,
//     Cloudy,
//     Rainy,
//     Snowy
// }
// часть 3
// int? age = null;
// double? temperature = null;
// Console.WriteLine(age.HasValue);
// Console.WriteLine(temperature.HasValue);
// age = 20;
// temperature = 23.5;
// Console.WriteLine(age.HasValue);
// Console.WriteLine(temperature.HasValue);
// Console.WriteLine(age.Value);
// Console.WriteLine(temperature.Value);
// age = null;
// temperature = null;
// Console.WriteLine(age ?? 18);
// Console.WriteLine(temperature ?? 20.0);
// небольшое задание
// Console.Write("Введите возраст: ");
// string? input = Console.ReadLine();
// int? age = null;
// if (int.TryParse(input, out int value))
// {
//     age = value;
// }

// if (age.HasValue)
// {
//     Console.WriteLine($"Ваш возраст: {age.Value}");
// }
// else
// {
//     Console.WriteLine("Возраст не указан");
// }
// часть 4

// Console.Write("Введите уровень сложности (Easy/Normal/Hard): ");
// string? inputDifficulty = Console.ReadLine();

// if (Enum.TryParse<Difficulty>(
//     inputDifficulty, true, out Difficulty difficulty))
// {
//     Console.WriteLine("Введено корректно");
//     Console.WriteLine("Выбран уровень: " + difficulty);
// }
// else
// {
//     Console.WriteLine("Некорректный уровень");
// }
// enum Difficulty
// {
//     Easy,
//     Normal,
//     Hard
// }

// финальная задача

// Console.Write("Имя персонажа: ");
// string? name = Console.ReadLine();

// Console.Write("Класс (Warrior/Mage/Archer): ");
// string? inputClass = Console.ReadLine();

// if (!Enum.TryParse<HeroClass>(inputClass, true, out HeroClass heroClass))
// {
//     Console.WriteLine("Такого класса нет");
//     return;
// }

// Console.Write("Возраст: ");
// string? inputAge = Console.ReadLine();

// int? age = null;

// if (int.TryParse(inputAge, out int parsedAge))
// {
//     age = parsedAge;
// }

// Console.Write("Победы: ");
// string? inputWins = Console.ReadLine();
// int? wins = null;
// if (int.TryParse(inputWins, out int parsedWins))
// {
//     wins = parsedWins;
// }
// double? bonus = 2.5;
// Console.WriteLine("\n=== Персонаж ===");
// Console.WriteLine("Имя: " + name);
// Console.WriteLine("Класс: " + heroClass);
// Console.WriteLine("Описание: " + N(heroClass));
// Console.WriteLine("Возраст: " + (age?.ToString() ?? "Не указан"));
// Console.WriteLine("Побед: " + (wins ?? 0));

// if (bonus.HasValue)
// {
//     Console.WriteLine("Бонус: " + bonus.Value);
// }
// else
// {
//     Console.WriteLine("Бонус не указан");
// }



// string N(HeroClass heroClass)
// {
//     switch (heroClass)
//     {
//         case HeroClass.Warrior:
//             return "Сильный воин";

//         case HeroClass.Mage:
//             return "Использует магию";

//         case HeroClass.Archer:
//             return "Метко стреляет из лука";

//         default:
//             return "Неизвестный класс";
//     }
// }

// enum HeroClass
// {
//     Warrior,
//     Mage,
//     Archer
// }
// самостоятельные задания 
// 1 
// Console.Write("Введите цвет (red/yellow/green): ");
// string h = Console.ReadLine();

// SV lig;

// if (h == "red")
//     lig = SV.red;
// else if (h == "yellow")
//     lig = SV.yellow;
// else if (h == "green")
//     lig = SV.green;
// else
// {
//     Console.WriteLine("Ошибка");
//     return;
// }

// Console.WriteLine(Get(lig));

// string Get(SV lig)
// {
//     switch (lig)
//     {
//         case SV.red:
//             return "Стоп";
//         case SV.yellow:
//             return "Внимание";
//         case SV.green:
//             return "Можно идти";
//         default:
//             return "Ошибка";
//     }
// }

// enum SV
// {
//     red,
//     yellow,
//     green
// }
// 2 
// Console.Write("Введите первое число");
// string c = Console.ReadLine();
// int? m1 = null;
// if (int.TryParse(c, out int m))
// {
//     m1 = m;
// }
// Console.Write("Введите второе число");
// string f = Console.ReadLine();
// int? m2 = null;
// if (int.TryParse(f, out int z))
// {
//     m2 = z;
// }

// if (m1.HasValue && m2.HasValue)
// {
//     Console.WriteLine($"Оба числа есть, сумма {m1 + m2}");

// }
// else if (!m1.HasValue && m2.HasValue)
// {
//     Console.WriteLine($"Первого числа нет, сумма второго и нуля {(m1 ?? 0) + m2}");
// }
// else if (m1.HasValue && !m2.HasValue)
// {
//     Console.WriteLine($"Второго числа нет, сумма первого и нуля {(m2 ?? 0) + m1}");
// }
// else
// {
//     Console.WriteLine("Обоих чисел нет, результат 0");
// }

// 3

