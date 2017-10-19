using CommonCartridge.Core;
using CommonCartridge.Core.Constants;
using CommonCartridge.Core.Interfaces.v1_0;
using NUnit.Framework;
using Shouldly;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CommonCartridge.Tests.Unit
{
    [TestFixture]
    public class V1_0ParserTests : ParserTestBase
    {
        #region Private Members
        private IV1_0Parser _sut;
        #endregion

        #region Setup and Teardown
        [SetUp]
        public void Setup()
        {
            _sut = new V1_0Parser();
        }

        [TearDown]
        public void Teardown() { }
        #endregion

        [Test]
        public void Load_Invalid_File_Returns_File_Not_Found_Exception()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "dummy_xml.xml");

            // Act
            var result = _sut.FromCCFile(absolutePath, RootFilePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(true);
            result.Errors.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void Load_Valid_LTI_File_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "BasicLTI.xml");

            // Act
            var result = _sut.FromLTIFile(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            result.BasicLTI.ShouldNotBeNull();
            result.BasicLTI.Secure_launch_url.ShouldNotBeNullOrWhiteSpace();
        }
    }
}
