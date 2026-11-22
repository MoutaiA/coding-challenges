namespace CodingChallenges.WordCount.Tests.Helper;

public class FileHelper
{
	public static string SetFilePath(string path)
	{
		return Path.Combine(AppContext.BaseDirectory, "data", path);
	}
}