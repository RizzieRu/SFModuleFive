void Echo(string text, int deep)
{
	string modif = text;

	if (modif.Length > 2)
	{
		modif = modif.Remove(0, 2);
		Console.BackgroundColor = (ConsoleColor) deep;
		Console.WriteLine($"...{modif}");
	}

	if (deep > 1)
	{
		Echo(modif, deep - 1);
	}
}

static int PowerUp(int N, byte pow)
{
	if (pow == 0) return 1;

	if (pow == 1)
	{
		return N;
	}
	else
	{
		return N * PowerUp(N, --pow);
	}
}

void ExecutePowerUp()
{
	Console.WriteLine("Введите число:");
	int number = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine("Введите степень:");
	byte pow = Convert.ToByte(Console.ReadLine());

	Console.WriteLine($"Результат: {PowerUp(number, pow)}");
}

void ExecuteEcho()
{
	Console.WriteLine("Введите текст:");

	string text = Console.ReadLine();

	Console.WriteLine("Введите глубину эха:");

	int deep = Convert.ToInt32(Console.ReadLine());

	Echo(text, deep);
}

ExecutePowerUp();