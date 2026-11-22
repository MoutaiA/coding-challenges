namespace CodingChallenges.WordCount.Tests;

public class DataHelper
{
	public static string CreateMultiLinesString()
	{
		return """
			1
			2
			3
			4
			5

			""";
	}

	public static TheoryData<string, int> MultiLinesBytes => new()
	{
		{ CreateMultiLinesString(), 10 },
	};
}
