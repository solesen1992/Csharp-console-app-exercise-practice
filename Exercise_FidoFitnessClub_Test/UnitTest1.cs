using Exercise_FidoFitnessClub.Controller;
using Exercise_FidoFitnessClub.Model;
using Exercise_FidoFitnessClub.TUI;

namespace Exercise_FidoFitnessClub_Test
{
    public class UnitTest1
    {
        [Fact]
        public void SetMember_ShouldSetCorrectMember_WhenEmailIsValid()
        {
            // Arrange
            var dogController = new RegisterDogController();
            string validEmail = "john.doe@example.com";

            // Act
            dogController.SetMember(validEmail);
            var member = dogController.CurrentMember; // Assume you have a public property for the current member

            // Assert
            Assert.NotNull(member);
            Assert.Equal("John Doe", member.Name);
            Assert.Equal(validEmail, member.Email);
        }

        [Fact]
        public void SetMember_ShouldThrowException_WhenEmailIsInvalid()
        {
            // Arrange
            var dogController = new RegisterDogController();
            string invalidEmail = "non.existent@example.com";

            // Act & Assert
            Assert.Throws<Exception>(() => dogController.SetMember(invalidEmail)); // Assuming an exception is thrown for invalid email
        }

        [Fact]
        public void RegisterDog_ShouldRegisterDog_WhenMemberIsSet()
        {
            // Arrange
            var dogController = new RegisterDogController();
            string validEmail = "john.doe@example.com";
            dogController.SetMember(validEmail);

            // Act
            dogController.RegisterDog("Buddy", 2024);
            var dogs = dogController.CurrentMember.Dogs; // Assuming you have a list of dogs under the member

            // Assert
            Assert.Single(dogs); // Ensure one dog is registered
            Assert.Equal("Buddy", dogs[0].Name);
            Assert.Equal(2024, dogs[0].BirthYear);
        }

        [Fact]
        public void RegisterDog_ShouldThrowException_WhenNoMemberIsSet()
        {
            // Arrange
            var dogController = new RegisterDogController();

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => dogController.RegisterDog("Buddy", 2024)); // Expect an exception when no member is set
        }
    }
}