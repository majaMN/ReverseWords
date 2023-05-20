using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void ReverseWords_ShouldReverseWords()
        {
            // Arrange
            string input = "this is a test";
            string expectedOutput = "test a is this";

            // Act
            string reversedWords = TechnicalAssessment.Program.ReverseWords(input);

            // Assert
            Assert.Equal(expectedOutput, reversedWords);
        }
    }
}