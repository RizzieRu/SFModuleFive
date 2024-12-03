using SFModuleFive.Models;
using System.Text;

static string GetTextFromConsoleReadLine(string text)
{
	Console.WriteLine(text);

	string val = null;

	while (true)
	{
		val = Console.ReadLine();

		if (string.IsNullOrWhiteSpace(val))
		{
			Console.WriteLine("Текст не должен быть пустым. Попробуйте ещё раз:");
		}
		else
		{
			break;
		}
	}

	return val;
}

static int GetIntFromConsoleReadLine(string text)
{
	Console.WriteLine(text);

	int val;

	while (true)
	{
		try
		{
			val = Convert.ToInt32(Console.ReadLine());
			break;
		}
		catch
		{
			Console.WriteLine("Пожалуйста, введите целое число. Попробуйте ещё раз:");
		}
	}

	return val;
}

static bool GetBoolFromConsoleReadLine(string text)
{
	Console.WriteLine(text);
	Console.WriteLine("Y — да");
	Console.WriteLine("N — нет");
	Console.WriteLine("Введите ответ в виде символа ниже:");

	bool val;
	string? temp;

	while (true)
	{
		temp = Console.ReadLine();

		if (temp == "Y")
		{
			val = true;
			break;
		}
		else if (temp == "N")
		{
			val = false;
			break;
		}
		else
		{
			Console.WriteLine("Пожалуйста, введите ответ в виде символа, где Y = да; N = нет. Попробуйте ещё раз:");
		}
	}

	return val;
}

static List<string> GetListStringFromConsoleReadLine(string text)
{
	Console.WriteLine(text);

	var val = new List<string>();
	string temp;

	while (true)
	{
		Console.WriteLine("Чтобы прекратить ввод, введите \"D\"");
		temp = GetTextFromConsoleReadLine($"Продолжите ввод. Уже указано: {val.Count}");
		
		if (temp.ToLower() == "d")
		{
			break;
		}
		else
		{
			val.Add(temp);
		}
	}

	return val;
}

static User SetUser()
{
	string name = GetTextFromConsoleReadLine("Введите имя:");

	string surName = GetTextFromConsoleReadLine("Введите фамилию:");

	int age = GetIntFromConsoleReadLine("Введите возраст:");

	bool isHavePet = GetBoolFromConsoleReadLine("У вас есть животные?");

	int? petCount = null;

	if (isHavePet) petCount = GetIntFromConsoleReadLine("Укажите количество животных:");

	List<string>? petsNames = null;

	if (petCount > 0) petsNames = GetListStringFromConsoleReadLine("Укажите имена ваших животных.");

	int countOfFavoriteColors = GetIntFromConsoleReadLine("Введите количество ваших любимых цветов:");

	List<string>? favoriteColors = null;

	if (countOfFavoriteColors > 0) favoriteColors = GetListStringFromConsoleReadLine("Укажите ваши любимые цвета.");

	var user = new User(name, surName, age, isHavePet, countOfFavoriteColors, favoriteColors, petCount, petsNames);

	return user;
}

void ShowUser(User user)
{
	StringBuilder builder = new StringBuilder();

	builder.AppendLine("Информация о пользователе:");
	builder.AppendLine($"Имя: {user.Name}");
	builder.AppendLine($"Фамилия: {user.SecondName}");
	builder.AppendLine($"Возраст: {user.Age} лет");

	builder.AppendLine($"Животные: {(user.IsHavePet ? "есть" : "нет" )}");

	if (user.IsHavePet)
	{
		builder.AppendLine($"Количество животных: {user.PetCount}");
	}

	if (user.IsHavePet && user.PetsNames != null)
	{
		builder.Append($"Список кличек Ваших животных: ");
		foreach (string petName in user.PetsNames)
		{
			builder.Append($"{petName} ");
		}
	}

	builder.AppendLine($"\nЛюбимых цветов: {user.CountOfFavoriteColors}");

	if (user.FavoriteColors != null)
	{
		builder.Append($"Список ваших любимых цветов: ");
		foreach (string favoriteColor in user.FavoriteColors)
		{
			builder.Append($"{favoriteColor} ");
		}
	}

	Console.Clear();

	Console.WriteLine(builder.ToString());
}

var user = SetUser();

ShowUser(user);

Console.ReadLine();