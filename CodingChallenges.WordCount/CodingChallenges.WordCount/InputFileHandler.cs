namespace CodingChallenges.WordCount;

public class InputFileHandler
{
	public static string Open(string filepath)
	{
		if (!File.Exists(filepath))
			throw new FileNotFoundException("Sorry, No such file or directory!");
		return File.ReadAllText(filepath);
	}
}