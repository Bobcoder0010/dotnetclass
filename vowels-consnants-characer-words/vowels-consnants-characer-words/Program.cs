using System;
using System.Globalization;
using System.Text;

class Program
{
	static void Main()
	{
		string word = "Hello, this is an example sentence.";
		Console.WriteLine("Enter a sentence:")

	
		Console.WriteLine("Title Case: " + titleCaseSentence);


		string toggleCaseSentence = ToToggleCase(sentence);
		Console.WriteLine("Toggle Case: " + toggleCaseSentence);
	}

	static string ToTitleCase(string sentence)
	{
		TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
		return textInfo.ToTitleCase(sentence.ToLower());
	}

	static string ToToggleCase(string sentence)
	{
		StringBuilder sb = new StringBuilder(sentence.Length);
		foreach (char c in sentence)
		{
			if (char.IsLower(c))
				sb.Append(char.ToUpper(c));
			else if (char.IsUpper(c))
				sb.Append(char.ToLower(c));
			else
				sb.Append(c);
		}
		return sb.ToString();
	}
}