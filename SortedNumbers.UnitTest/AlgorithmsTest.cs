using NUnit.Framework;
using SortedNumbersAPI.Scripts;

namespace SortedNumbers.UnitTest
{
    public class AlgorithmsTest
    {
        private const string sortedString = "1 2 3 4 5 6 7 8 9 10";
        
        [Test]
        public void SortedCorrectlyBy_BubbleSort_ReturnTrue()
        {
            string unsortedString = "10 9 8 7 6 5 4 3 2 1";
            var algorithms = new Algorithms();
            unsortedString = algorithms.BubbleSort(unsortedString);

            Assert.AreEqual(sortedString, unsortedString);
        }
        [Test]
        public void SortedCorrectlyBy_InsertionSort_ReturnTrue()
        {
            string unsortedString = "10 9 8 7 6 5 4 3 2 1";
            var algorithms = new Algorithms();
            unsortedString = algorithms.InsertionSort(unsortedString);

            Assert.AreEqual(sortedString, unsortedString);
        }

        [Test]
        public void SortedCorrectlyBy_SimpleSort_ReturnTrue()
        {
            string unsortedString = "10 9 8 7 6 5 4 3 2 1";
            var algorithms = new Algorithms();
            unsortedString = algorithms.SimpleSort(unsortedString);

            Assert.AreEqual(sortedString, unsortedString);
        }

    }
}