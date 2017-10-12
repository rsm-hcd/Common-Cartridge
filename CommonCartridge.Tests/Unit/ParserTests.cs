using CommonCartridge.Core;
using CommonCartridge.Core.Interfaces;
using NUnit.Framework;
using Shouldly;
using System;
using System.IO;

namespace CommonCartridge.Tests.Unit
{
    [TestFixture]
    public class ParserTests
    {
        #region Private Members
        private IParser _sut;
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
            _sut = new Parser();
        }

        [TearDown]
        public void Teardown() { }
        #endregion

        [Test]
        public void Load_Invalid_File_Returns_File_Not_Found_Exception()
        {
            // Arrange
            var absolutePath = "C:\\test\\import.xml";
            Exception result = null;

            // Act
            try
            {
                _sut.FromFile(absolutePath);
            } catch (Exception ex)
            {
                result = ex;
            }

            // Assert
            result.ShouldNotBeNull();
            result.ShouldBeOfType<FileNotFoundException>();
        }

        [Test]
        public void Load_Valid_File_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "imsmanifest.xml");

            // Act
            var result = _sut.FromFile(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.Metadata.ShouldNotBeNull();
            result.Metadata.Lom.ShouldNotBeNull();
            result.Metadata.Lom.Items.ShouldNotBeNull();
            result.Metadata.Lom.Items.Length.ShouldBeGreaterThan(0);
            result.Organizations.ShouldNotBeNull();
            result.Organizations.Organization.ShouldNotBeNull();
            result.Organizations.Organization.Item.ShouldNotBeNull();
            result.Organizations.Organization.Item.Item.ShouldNotBeNull();
            result.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            result.Resources.ShouldNotBeNull();
            result.Resources.Resource.ShouldNotBeNull();
            result.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }
    }
}
