namespace CodingChallenges.WordCount.Tests;

using CodingChallenges.WordCount;


public class WordCountTests
{
	[Theory]
	[InlineData("this is an example", 4)]
	[InlineData("this is another example of a test", 7)]
	[InlineData("", 0)]
	[InlineData("   coucou", 1)]
	[InlineData("   coucou    ", 1)]
	[InlineData("   coucou    test", 2)]
	[InlineData("   coucou    \ntest\n", 2)]
	[InlineData("   coucou    \n test lol \n xd", 4)]
	public void ShoudlCountCorrectNumber_WhenCalledWithWordsArg(string filecontent, int expected)
	{
		var result = WordCount.CountWords(filecontent);

		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("multiple line\n", 1)]
	[InlineData("multiple line\n\n\n3", 3)]
	[InlineData("multiple line\r\n2\n", 2)]
	[InlineData("", 0)]
	[InlineData("line\n", 1)]
	[InlineData("line", 0)]
	public void ShouldCountCorrectLines_WhenCalledWithLinesArg(string filecontent, int expected)
	{
		var result = WordCount.CountLines(filecontent);

		Assert.Equal(expected, result);
	}

	[Theory]
	[InlineData("test\n", 5)]
	[InlineData("test", 4)]
	[InlineData("", 0)]
	[InlineData("café", 5)]
	[InlineData("€", 3)]
	[InlineData("😀", 4)]
	[MemberData(nameof(DataHelper.MultiLinesBytes), MemberType = typeof(DataHelper))]
	public void ShouldCountCorrectBytes_WhenCallingCountBytes(string filecontent, int expected)
	{
		var result = WordCount.CountBytes(filecontent);

		Assert.Equal(expected, result);
	}


	[Theory]
	[InlineData("hello", 5)]
	[InlineData("", 0)]
	[InlineData("\r", 1)]
	[InlineData("café", 4)]
	[InlineData("€", 1)]
	[InlineData("😀", 1)]
	public void ShouldCountCorrectCharacters_WhenCallingCountCharacters(string filecontent, int expected)
	{
		var result = WordCount.CountCharacters(filecontent);

		Assert.Equal(expected, result);
	}
}