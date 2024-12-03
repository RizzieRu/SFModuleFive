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

Console.WriteLine("Введите текст:");

string text = Console.ReadLine();

Console.WriteLine("Введите глубину эха:");

int deep = Convert.ToInt32(Console.ReadLine());

Echo(text, deep);
