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

