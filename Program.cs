string[] data = File.ReadAllLines("data.txt");
string[] strategy = { "A X", "A Y", "A Z", "B X", "B Y", "B Z", "C X", "C Y", "C Z" };
int[] points = { 3, 4, 8, 1, 5, 9, 2, 6, 7, };
int sum = 0;

foreach (string line in data)
{
	for (int i = 0; i < strategy.Length; i++)
	{
		if (line.Equals(strategy[i]))
		{
			sum += points[i];
		}
	}
}

Console.WriteLine(sum);
