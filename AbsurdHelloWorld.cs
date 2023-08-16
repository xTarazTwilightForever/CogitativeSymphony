using System;
using NUnit.Framework;
using CogitativeSymphony; 

namespace AbsurdHelloWorld.Tests.Tests
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void TestGenerateHelloWorld()
        {
            var result = Program.GenerateHelloWorld();
            Assert.AreEqual("Hello, World!", result);
        }

        [TestCase('H')]
        [TestCase('e')]
        [TestCase('l')]
        [TestCase('o')]
        [TestCase(' ')]
        [TestCase('W')]
        [TestCase('r')]
        [TestCase('d')]
        [TestCase('!')]
        public void TestEachCharacter(char character)
        {
            var result = Program.GenerateHelloWorld();
            Assert.IsTrue(result.Contains(character.ToString()));
        }

        [Test]
        public void TestIsProgramWorking()
        {
            var result = Program.IsProgramWorking();
            Assert.IsTrue(result);
        }
    }
}
