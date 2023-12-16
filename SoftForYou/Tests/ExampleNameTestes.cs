using Domain.ExampleNames;
using Xunit;

namespace Tests
{
    public class ExampleNameTestes
    {
        [Fact]
        public void CreateExampleName_ThenSuccess()
        {
            // Arrange
            string firstName = "Katarzyma";
            string lastName = "Nowak";

            // Act
            var result = new ExampleNames(firstName, lastName);

            // Assert
            Assert.Equal(firstName, result.FirstName);
            Assert.Equal(lastName, result.LastName);
        }

        [Fact]
        public void CreateExampleName_WhenFirstNameEmpty_ThenThrowsException()
        {
            // Arrange
            string firstName = string.Empty;
            string lastName = "Nowak";

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => new ExampleNames(firstName, lastName));
        }

        [Fact]
        public void CreateExampleName_WhenLastNameEmpty_ThenThrowsException()
        {
            // Arrange
            string firstName = "Katarzyna";
            string lastName = string.Empty;

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => new ExampleNames(firstName, lastName));
        }

        [Fact]
        public void CreateExampleName_WhenFirstNameWhiteSpace_ThenThrowsException()
        {
            // Arrange
            string firstName = "  ";
            string lastName = "Nowak";

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => new ExampleNames(firstName, lastName));
        }

        [Fact]
        public void CreateExampleName_WhenLastNameWhiteSpace_ThenThrowsException()
        {
            // Arrange
            string firstName = "Katarzyna";
            string lastName = "   ";

            // Act

            // Assert
            Assert.Throws<ArgumentNullException>(() => new ExampleNames(firstName, lastName));
        }
    }
}