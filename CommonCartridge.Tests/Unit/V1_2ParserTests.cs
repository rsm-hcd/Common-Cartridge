using CommonCartridge.Core;
using CommonCartridge.Core.Interfaces;
using CommonCartridge.Core.Interfaces.v1_2;
using NUnit.Framework;
using Shouldly;
using System;
using System.IO;
using System.Threading.Tasks;

namespace CommonCartridge.Tests.Unit
{
    [TestFixture]
    public class V1_2ParserTests : ParserTestBase
    {
        #region Private Members
        private IV1_2Parser _sut;
        #endregion

        #region Setup and Teardown
        [SetUp]
        public void Setup()
        {
            _sut = new V1_2Parser();
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
        public void Load_Valid_File_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "imsmanifest.xml");

            // Act
            var result = _sut.FromCCFile(absolutePath, RootFilePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            result.Manifest.ShouldNotBeNull();
            result.Manifest.Metadata.Lom.ShouldNotBeNull();
            result.Manifest.Metadata.Lom.Items.ShouldNotBeNull();
            result.Manifest.Metadata.Lom.Items.Length.ShouldBeGreaterThan(0);
            result.Manifest.Organizations.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            result.Manifest.Resources.ShouldNotBeNull();
            result.Manifest.Resources.Resource.ShouldNotBeNull();
            result.Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void Load_Valid_Archive_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "1.2.0 CC", "1.2.0 CC.imscc");

            // Act
            var result = _sut.FromCCArchive(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            result.Manifest.ShouldNotBeNull();
            result.Manifest.Metadata.Schema.ShouldNotBeNull();
            result.Manifest.Organizations.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
            result.Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            result.Manifest.Resources.ShouldNotBeNull();
            result.Manifest.Resources.Resource.ShouldNotBeNull();
            result.Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }
    }
}
