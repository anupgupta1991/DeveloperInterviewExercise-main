
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileData;
using Moq;

namespace FileDataUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_FileDetailsVersion()
        {
            BarclaysTask1 barclaysTask1 = new BarclaysTask1();

            Mock<IFileDetails> mockFile = new Mock<IFileDetails>();

            //I need to use Moq framework to test the random value. But I do not rememver and implemented beacause of no time left.

            Assert.IsTrue(1000 == 1100);
        }
        [TestMethod]
        public void Test_FileDetailsVersionAndSize()
        {
            BarclaysTask2 barclaysTask2 = new BarclaysTask2();

            Mock<IFileDetails> mockFile = new Mock<IFileDetails>();

            //I need to use Moq framework to test the random value. But I do not rememver and implemented beacause of no time left.

            Assert.IsTrue(1000 == 1100);
        }
    }
}
