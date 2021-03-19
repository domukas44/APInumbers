using Moq;
using NUnit.Framework;
using SortedNumbersAPI.Controllers;
using SortedNumbersAPI.Scripts;

namespace SortedNumbers.UnitTest
{
    public class ControllerTest
    {
        private NumbersController controller;
        private Mock<IIOFile> streamMock;
        private Mock<IAlgorithms> algorithmsMock;

        [SetUp]
        public void SetUp()
        {
            
            streamMock = new Mock<IIOFile>();
            algorithmsMock = new Mock<IAlgorithms>();
            controller = new NumbersController(streamMock.Object, algorithmsMock.Object);
        }
        [Test]
        public void PostSortsAndSaves_ReturnTrue()
        {

            algorithmsMock.Setup(v => v.SimpleSort("4 3 2 1")).Returns("1 2 3 4");
            streamMock.Setup(v => v.CorrectInput("4 3 2 1")).Returns("");
            streamMock.Setup(v => v.SaveResult("4 3 2 1"));

            var result = controller.Post("4 3 2 1");

            Assert.AreEqual("data successfully sorted and saved", result);
        }

        [Test]
        public void Post2ComparesAndSaves_ReturnTrue()
        {

            algorithmsMock.Setup(v => v.SimpleSort("4 3 2 1")).Returns("1 2 3 4");
            algorithmsMock.Setup(v => v.InsertionSort("4 3 2 1")).Returns("1 2 3 4");
            algorithmsMock.Setup(v => v.BubbleSort("4 3 2 1")).Returns("1 2 3 4");
            streamMock.Setup(v => v.CorrectInput("4 3 2 1")).Returns("");
            streamMock.Setup(v => v.SaveResult("4 3 2 1"));

            string result = controller.Post2("4 3 2 1");

            Assert.That(result.Contains("Insertion sort") && result.Contains("Simple sort") && result.Contains("Bubble sort"));

        }

    }
}