// AuthorModelTests.cs
using AuthorMySQL.Data;
using System.ComponentModel.DataAnnotations;
using Xunit;

namespace AuthorMySQL.Tests
{
    public class AuthorModelTests
    {
        [Fact]
        public void Author_WithValidData_ShouldBeValid()
        {
            // Arrange
            var author = new Author
            {
                AuthorId = "123-45-6789",
                AuthorFirstName = "Jane",
                AuthorLastName = "Doe",
                Phone = "123-456-7890",
                Contract = true
            };

            // Act
            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(author, new ValidationContext(author), results, true);

            // Assert
            Assert.True(isValid);
            Assert.Empty(results);
        }

        [Fact]
        public void Author_MissingRequiredFields_ShouldBeInvalid()
        {
            var author = new Author();

            var results = new List<ValidationResult>();
            var isValid = Validator.TryValidateObject(author, new ValidationContext(author), results, true);

            Assert.False(isValid);
            Assert.Contains(results, r => r.MemberNames.Contains("AuthorId"));
            Assert.Contains(results, r => r.MemberNames.Contains("AuthorFirstName"));
            Assert.Contains(results, r => r.MemberNames.Contains("AuthorLastName"));
            Assert.Contains(results, r => r.MemberNames.Contains("Phone"));
        }
    }
}