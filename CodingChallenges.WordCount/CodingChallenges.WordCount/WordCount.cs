using System.Text;

namespace CodingChallenges.WordCount;

public class WordCount
{
	public static int CountWords(string filecontent)
	{
		if (filecontent == "") return 0;

		int count = 0;

		foreach (var word in filecontent.Split())
		{
			count += 1;
		}

		return count;
	}

	public static int CountLines(string filecontent)
	{
		var count = 0;
		foreach (var _ in filecontent.AsSpan().EnumerateLines())
		{
			count++;
		}
		return count;
	}

	public static int CountBytes(string filecontent)
	{
		return Encoding.UTF8.GetByteCount(filecontent);
	}

	public static int CountCharacters(string filecontent)
	{
		return filecontent.EnumerateRunes().Count();
	}
}