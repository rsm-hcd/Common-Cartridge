using CommonCartridge.Core;
using CommonCartridge.Core.Constants;
using CommonCartridge.Core.Interfaces;
using NUnit.Framework;
using Shouldly;
using System.IO;

namespace CommonCartridge.Tests.Unit
{
    [TestFixture]
    public class ParserTests : ParserTestBase
    {
        #region Private Members
        private IParser _sut;
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
            var absolutePath = Path.Combine(RootFilePath, "dummy_xml.xml");

            // Act
            var result = _sut.FromCCFile<Core.Models.v1_2.ManifestType>(absolutePath, RootFilePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(true);
            result.Errors.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void Load_Valid_LTI_1_0_File_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "BasicLTI.xml");

            // Act
            var result = _sut.FromLTIFile<Core.Models.v1_0.CartridgeBasicLTILinkType>(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            var basicLti = result.BasicLTI as Core.Models.v1_0.CartridgeBasicLTILinkType;
            basicLti.ShouldNotBeNull();
            basicLti.Secure_launch_url.ShouldNotBeNullOrWhiteSpace();
        }

        [Test]
        public void Load_Valid_CC_1_2_File_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "imsmanifest.xml");

            // Act
            var result = _sut.FromCCFile<Core.Models.v1_2.ManifestType>(absolutePath, RootFilePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            var manifest = result.Manifest as Core.Models.v1_2.ManifestType;
            manifest.ShouldNotBeNull();
            manifest.Metadata.Lom.ShouldNotBeNull();
            manifest.Metadata.Lom.Items.ShouldNotBeNull();
            manifest.Metadata.Lom.Items.Length.ShouldBeGreaterThan(0);
            manifest.Organizations.ShouldNotBeNull();
            manifest.Organizations.Organization.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            manifest.Resources.ShouldNotBeNull();
            manifest.Resources.Resource.ShouldNotBeNull();
            manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }

        [Test]
        public void Load_Valid_CC_1_2_Archive_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "1.2.0 CC", "1.2.0 CC.imscc");

            // Act
            var result = _sut.FromCCArchive<Core.Models.v1_2.ManifestType>(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            var manifest = result.Manifest as Core.Models.v1_2.ManifestType;
            manifest.ShouldNotBeNull();
            manifest.Metadata.Schema.ShouldNotBeNull();
            manifest.Organizations.ShouldNotBeNull();
            manifest.Organizations.Organization.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
            manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            manifest.Resources.ShouldNotBeNull();
            manifest.Resources.Resource.ShouldNotBeNull();
            manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }
    }
}
