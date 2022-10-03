using OblOpg1_1;

namespace TestOblOpg1_1
{
    [TestClass]
    public class TestFootballPlayer
    {
        FootballPlayer player = new FootballPlayer { Age = 1, Id = 1, Name = "John", ShirtNumber = 1 };
        FootballPlayer playerHighValues = new FootballPlayer { Age = 100, Id = 10000, Name = "John", ShirtNumber = 99 };

        FootballPlayer playerNameToShort = new FootballPlayer { Age = 1, Id = 1, Name = "J", ShirtNumber = 1 };
        FootballPlayer playerNameNull = new FootballPlayer { Age = 1, Id = 1, Name = null, ShirtNumber = 1 };

        FootballPlayer playerAgeToLow = new FootballPlayer { Age = 0, Id = 1, Name = "Jonas", ShirtNumber = 1 };

        FootballPlayer playerShirtNumberToLow = new FootballPlayer { Age = 1, Id = 1, Name = "Jonas", ShirtNumber = 0 };
        FootballPlayer playerShirtNumberToHigh = new FootballPlayer { Age = 1, Id = 1, Name = "Jonas", ShirtNumber = 100 };



        [TestMethod]
        public void TestValidateName()
        {
            player.ValidateName();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerNameToShort.ValidateName());
            Assert.ThrowsException<NullReferenceException>(() => playerNameNull.ValidateName());
        }
        [TestMethod]
        public void TestValidateAge()
        {
            player.ValidateAge();
            playerHighValues.ValidateAge();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerAgeToLow.ValidateAge());
        }
        [TestMethod]
        public void TestValidateShirtNumber()
        {
            player.ValidateShirtNumber();
            playerHighValues.ValidateShirtNumber();

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberToLow.ValidateShirtNumber());
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => playerShirtNumberToHigh.ValidateShirtNumber());
        }

    }
}