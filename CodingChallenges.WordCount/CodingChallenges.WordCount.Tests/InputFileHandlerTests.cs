namespace CodingChallenges.WordCount.Tests;

using CodingChallenges.WordCount;
using CodingChallenges.WordCount.Tests.Helper;

public class InputFileHandlerTests
{
	[Fact]
	public void ShouldReturnFileContent_WhenFileExists()
	{
		// Arrange
		string filepath = FileHelper.SetFilePath("test.txt");

		// Act
		var result = InputFileHandler.Open(filepath);

		// Assert
		Assert.Equal("This is a test file", result);
	}

	[Fact]
	public void ShouldThrowNotFound_WhenWrongPathProvided()
	{
		string filepath = FileHelper.SetFilePath("test.");

		var ex = Assert.Throws<FileNotFoundException>(() => InputFileHandler.Open(filepath));
		Assert.Contains("Sorry, No such file or directory!", ex.Message);
	}

	[Fact]
	public void ShouldReturnNothing_WhenFileEmpty()
	{
		string filepath = FileHelper.SetFilePath("empty.txt");

		var result = InputFileHandler.Open(filepath);

		Assert.Empty(result);
	}
}
