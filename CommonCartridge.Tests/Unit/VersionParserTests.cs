using CommonCartridge.Core;
using CommonCartridge.Core.Constants;
using CommonCartridge.Core.Interfaces;
using NUnit.Framework;
using Shouldly;
using System.IO;

namespace CommonCartridge.Tests.Unit
{
    [TestFixture]
    public class VersionParserTests
    {
        #region Private Members
        private IVersionParser _sut;
        #endregion

        #region Properties
        private string RootFilePath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "Data");
            }
        }
        #endregion

        #region Setup and Teardown
        [SetUp]
        public void Setup()
        {
            _sut = new VersionParser();
        }

        [TearDown]
        public void Teardown() { }
        #endregion

        [Test]
        public void Read_Version_On_CC()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "imsmanifest.xml");

            // Act
            var result = _sut.GetSchemaVersionFromFile(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.Length.ShouldBeGreaterThan(0);
            result.ShouldBe(Versions.VERSION_1_2);
        }

        [Test]
        public void Read_Version_On_LTI()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "BasicLTI.xml");

            // Act
            var result = _sut.GetSchemaVersionFromFile(absolutePath, "blti");

            // Assert
            result.ShouldNotBeNull();
            result.Length.ShouldBeGreaterThan(0);
            result.ShouldBe(Versions.VERSION_1_0);
        }
    }
}
