using GameWorldLibrary;
using Newtonsoft.Json.Linq;

namespace GameTests
{
    [TestClass]
    public class GetListMethodTests
    {
        [TestMethod]
        public void SubArray_TestMethod()
        {

            // Arrange
            string testArrayString = "1_2_3_4";            
            int[] expected = { 1, 2, 3, 4 };

            // Act
            int[] actual = GetList.SubArray(testArrayString);

            // Assert
            CollectionAssert.AreEqual(actual,expected);

        }

    }
}