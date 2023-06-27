namespace HomeTask_22
{
    public class StringManipulator
    {
        public string ConcatenateStrings(string str1, string str2)
        {
            return str1 + str2;
        }


        public int GetStringLength(string str)
        {
            return str.Length;
        }


        public string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();

            Array.Reverse(charArray);

            return new string(charArray);
        }


        public bool IsPalindrome(string str)
        {
            string reversedStr = ReverseString(str);
            return str.Equals(reversedStr, StringComparison.OrdinalIgnoreCase);
        }
    }


    [TestFixture]
    public class StringManipulatorTests
    {
        private StringManipulator stringManipulator;

        [SetUp]
        public void Setup()
        {
            stringManipulator = new StringManipulator();
        }

        [Test]
        public void ConcatenateStrings_ShouldReturnConcatenatedString()
        {
            // Arrange
            string str1 = "Hello";
            string str2 = "World";
            string expected = "HelloWorld";

            // Act
            string result = stringManipulator.ConcatenateStrings(str1, str2);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetStringLength_ShouldReturnLengthOfTheString()
        {
            // Arrange
            string str = "Hello";
            int expected = 5;

            // Act
            int result = stringManipulator.GetStringLength(str);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void ReverseString_ShouldReturnReversedString()
        {
            // Arrange
            string str = "Hello";
            string expected = "olleH";

            // Act
            string result = stringManipulator.ReverseString(str);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnTrueForPalindromeString()
        {
            // Arrange
            string palindrome = "Madam";
            bool expected = true;

            // Act
            bool result = stringManipulator.IsPalindrome(palindrome);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void IsPalindrome_ShouldReturnFalseForNonPalindromeString()
        {
            // Arrange
            string nonPalindrome = "Hello";
            bool expected = false;

            // Act
            bool result = stringManipulator.IsPalindrome(nonPalindrome);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}