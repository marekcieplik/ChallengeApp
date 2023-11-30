namespace ChallengeApp.Tests
{
    public class TypeTest
    {
        [Test]
        public void When_ComparisonOfReferences_WithUserLoginAreTheSame_ShouldBeNotEqual()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            // assert
            Assert.AreNotEqual(user1, user2);
         }
        [Test]
        public void When_ComparisonOfLogin_WithUserLoginAreTheSame_ShouldBeEqual()
        {
            // arrange
            var user1 = GetUser("Adam");
            var user2 = GetUser("Adam");
            // assert
            Assert.AreEqual(user1.Login, user2.Login);
        }

        [Test]
        public void When_ComparisonOfValueType_WithDifferentValues_ShouldBeNotEqual()
        {
            // arrange
            int numberInt1 = 1;
            int numberInt2 = 2;
            float numberFloat1 = 1f;
            float numberFloat2 = 2f;
            // assert
            Assert.AreNotEqual(numberInt1, numberInt2);
            Assert.AreNotEqual(numberFloat1, numberFloat2);
        }

        [Test]
        public void When_ComparisonOfValueType_WithTheSameValues_ShouldBeEqual()
        {
            // arrange
            int numberInt1 = 1;
            int numberInt2 = 1;
            float numberFloat1 = 1;
            float numberFloat2 = 1;
            // assert
            Assert.AreEqual(numberInt1, numberInt2);
            Assert.AreEqual(numberFloat1, numberFloat2);
        }

        [Test]
        public void When_ComparisonOfStringImmutable_WithTheSameValues_ShouldBeEqual()
        {
            // arrange
            string text1 = "TheSame";
            string text2 = "TheSame";
            // assert
            Assert.AreEqual(text1, text2);
        }

        private User GetUser(string username)
        {
            return new User(username);
        }
    }
}
