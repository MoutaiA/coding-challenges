using System.Text;
using System.Text.RegularExpressions;

namespace CodingChallenges.WordCount;

public class WordCount
{
	public static int CountWords(string filecontent)
	{
		return Regex.Count(filecontent, @"\S+");
	}

	public static int CountLines(string filecontent)
	{
		return filecontent.AsSpan().Count('\n');
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