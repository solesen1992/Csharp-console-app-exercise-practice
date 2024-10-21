using Exercise_FidoFitnessClub;
using Exercise_FidoFitnessClub.Controller;
using Exercise_FidoFitnessClub.Model;

namespace Exercise_FidoFitnessClub.Test
{
    public class UnitTest1
    {
        /*
         * MemberControllerTests
         */
        [Fact]
        public void CreateMember_ShouldAddMember_WhenMemberDoesNotExist()
        {
            // Arrange
            var controller = new MemberController();
            string name = "John Doll";
            string email = "john.doe@";
            string phone = "12345123";

            // Act
            Member createdMember = controller.CreateMember(name, email, phone);
            Member foundMember = controller.FindByEmail(email);

            // Assert
            Assert.NotNull(foundMember);
            Assert.Equal(name, foundMember.Name);
            Assert.Equal(email, foundMember.Email);
            Assert.Equal(phone, foundMember.Phone);
        }

        [Fact]
        public void FindByEmail_ShouldReturnMember_WhenEmailExists()
        {
            // Arrange
            var controller = new MemberController();
            string email = "john@example.com";
            controller.CreateMember("John Doe", email, "98765432");

            // Act
            Member foundMember = controller.FindByEmail(email);

            // Assert
            Assert.NotNull(foundMember);
            Assert.Equal(email, foundMember.Email);
        }

        [Fact]
        public void FindAll_ShouldReturnAllMembers()
        {
            // Arrange
            var controller = new MemberController();
            controller.CreateMember("John", "doe@example.com", "87654321");
            controller.CreateMember("Jane Smith", "jane.smith@example.com", "098-765-4321");

            // Act
            List<Member> members = controller.FindAll();

            // Assert
            Assert.Equal(2, members.Count);
        }

        /*
         * RegisterDogControllerTests
         */
        [Fact]
        public void RegisterDog_ShouldAddDogToCurrentMember()
        {
            // Arrange
            var memberController = new MemberController();
            memberController.CreateMember("Johnny Doe", "doe@", "12345698");

            var registerDogController = new RegisterDogController();
            registerDogController.FindByEmail("doe@");

            // Act
            Dog registeredDog = registerDogController.RegisterDog("Buddy", 2024);
            Member currentMember = registerDogController.FindByEmail("doe@");

            // Assert
            Assert.NotNull(registeredDog);
            Assert.Contains(registeredDog, currentMember.GetDogs());
        }

        [Fact]
        public void UpdateDog_ShouldChangeDogDetails()
        {
            // Arrange
            var memberController = new MemberController();
            string email = "john.doe@gmail.com";
            memberController.CreateMember("Johnny Cash", email, "78901234");

            var registerDogController = new RegisterDogController();
            registerDogController.FindByEmail(email);
            registerDogController.RegisterDog("Buddy", 2024);

            // Act
            registerDogController.UpdateDog("Buddy", "Max", 2025);
            Dog updatedDog = memberController.FindByEmail(email).FindDogByName("Max");

            // Assert
            Assert.NotNull(updatedDog);
            Assert.Equal(2025, updatedDog.FeeYear);
        }
    }
}