namespace CodingChallenges.WordCount.Tests;

using CodingChallenges.WordCount;


public class WordCountTests
{
	[Theory]
	[InlineData("this is an example", 4)]
	[InlineData("this is another example of a test", 7)]
	[InlineData("", 0)]
	public void ShoudlCountCorrectNumber_WhenCalledWithWordsArg(string filecontent, int expected)
	{
		var result = WordCount.CountWords(filecontent);

		Assert.Equal(expected, result);
	}
}