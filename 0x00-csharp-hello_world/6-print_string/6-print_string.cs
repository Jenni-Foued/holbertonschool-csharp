using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "Holberton School";
		Console.WriteLine(string.Concat(Enumerable.Repeat(str, 3)));
		Console.WriteLine(str.Substring(0, 9));
    }
}
