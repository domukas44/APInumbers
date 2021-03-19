using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SortedNumbersAPI.Scripts;

namespace SortedNumbers.UnitTest
{
    class IOFileTest
    {
        [Test]
        public void CorrrectInput_ReturnTrue()
        {
            var input = "10 9 8 7 6 5 4 3 2 1";
            var stream = new IOFile();

            input = stream.CorrectInput(input);

            Assert.AreEqual(input, "");
        }

        [Test]
        public void CorrrectInputOnlyNumbers_ReturnFalse()
        {
            var input = "1 2 3 11 22";
            var stream = new IOFile();

            input = stream.CorrectInput(input);

            Assert.AreNotEqual(input, "");
        }

        [Test]
        public void CorrrectInputWithLetters_ReturnFalse()
        {
            var input = "1 2 3 a b";
            var stream = new IOFile();

            input = stream.CorrectInput(input);

            Assert.AreNotEqual(input, "");
        }
    }
}
