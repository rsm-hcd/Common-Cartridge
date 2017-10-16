using CommonCartridge.Core;
using CommonCartridge.Core.Interfaces;
using NUnit.Framework;
using Shouldly;
using System;
using System.IO;
using System.Threading.Tasks;

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
            var absolutePath = Path.Combine(RootFilePath, "dummy_xml.xml");

            // Act
            var result = _sut.FromFile(absolutePath, RootFilePath);

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
            var result = _sut.FromFile(absolutePath, RootFilePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);

            Should.NotThrow(() =>
            {
                if (result.v1_0_Manifest == null && result.v1_1_Manifest == null && result.v1_2_Manifest == null && result.v1_3_Manifest == null)
                {
                    throw new ArgumentNullException();
                }
            });

            if (result.v1_0_Manifest != null)
            {
                result.v1_0_Manifest.Metadata.Schema.ShouldNotBeNull();
                result.v1_0_Manifest.Organizations.ShouldNotBeNull();
                result.v1_0_Manifest.Organizations.Organization.ShouldNotBeNull();
                result.v1_0_Manifest.Organizations.Organization.Count.ShouldNotBeNull();
                result.v1_0_Manifest.Organizations.Organization.Count.ShouldBeGreaterThan(0);
                result.v1_0_Manifest.Resources.ShouldNotBeNull();
                result.v1_0_Manifest.Resources.Resource.ShouldNotBeNull();
                result.v1_0_Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
            }

            if (result.v1_1_Manifest != null)
            {
                result.v1_1_Manifest.Metadata.Lom.ShouldNotBeNull();
                result.v1_1_Manifest.Metadata.Lom.Items.ShouldNotBeNull();
                result.v1_1_Manifest.Metadata.Lom.Items.Length.ShouldBeGreaterThan(0);
                result.v1_1_Manifest.Organizations.ShouldNotBeNull();
                result.v1_1_Manifest.Organizations.Organization.ShouldNotBeNull();
                result.v1_1_Manifest.Organizations.Organization.Item.ShouldNotBeNull();
                result.v1_1_Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
                result.v1_1_Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
                result.v1_1_Manifest.Resources.ShouldNotBeNull();
                result.v1_1_Manifest.Resources.Resource.ShouldNotBeNull();
                result.v1_1_Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
            }

            if (result.v1_2_Manifest != null)
            {
                result.v1_2_Manifest.Metadata.Lom.ShouldNotBeNull();
                result.v1_2_Manifest.Metadata.Lom.Items.ShouldNotBeNull();
                result.v1_2_Manifest.Metadata.Lom.Items.Length.ShouldBeGreaterThan(0);
                result.v1_2_Manifest.Organizations.ShouldNotBeNull();
                result.v1_2_Manifest.Organizations.Organization.ShouldNotBeNull();
                result.v1_2_Manifest.Organizations.Organization.Item.ShouldNotBeNull();
                result.v1_2_Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
                result.v1_2_Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
                result.v1_2_Manifest.Resources.ShouldNotBeNull();
                result.v1_2_Manifest.Resources.Resource.ShouldNotBeNull();
                result.v1_2_Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
            }

            if (result.v1_3_Manifest != null)
            {
                result.v1_3_Manifest.Metadata.Lom.ShouldNotBeNull();
                result.v1_3_Manifest.Metadata.Lom.Items.ShouldNotBeNull();
                result.v1_3_Manifest.Metadata.Lom.Items.Count.ShouldBeGreaterThan(0);
                result.v1_3_Manifest.Organizations.ShouldNotBeNull();
                result.v1_3_Manifest.Organizations.Organization.ShouldNotBeNull();
                result.v1_3_Manifest.Organizations.Organization.Item.ShouldNotBeNull();
                result.v1_3_Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
                result.v1_3_Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
                result.v1_3_Manifest.Resources.ShouldNotBeNull();
                result.v1_3_Manifest.Resources.Resource.ShouldNotBeNull();
                result.v1_3_Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
            }
        }

        [Test]
        public void Load_Valid_1_2_Archive_Returns_Valid_Object()
        {
            // Arrange
            var absolutePath = Path.Combine(RootFilePath, "1.2.0 CC", "1.2.0 CC.imscc");

            // Act
            var result = _sut.FromArchive(absolutePath);

            // Assert
            result.ShouldNotBeNull();
            result.HasErrors.ShouldBe(false);
            result.v1_2_Manifest.ShouldNotBeNull();
            result.v1_2_Manifest.Metadata.Schema.ShouldNotBeNull();
            result.v1_2_Manifest.Organizations.ShouldNotBeNull();
            result.v1_2_Manifest.Organizations.Organization.ShouldNotBeNull();
            result.v1_2_Manifest.Organizations.Organization.Item.ShouldNotBeNull();
            result.v1_2_Manifest.Organizations.Organization.Item.Item.ShouldNotBeNull();
            result.v1_2_Manifest.Organizations.Organization.Item.Item.Count.ShouldBeGreaterThan(0);
            result.v1_2_Manifest.Resources.ShouldNotBeNull();
            result.v1_2_Manifest.Resources.Resource.ShouldNotBeNull();
            result.v1_2_Manifest.Resources.Resource.Count.ShouldBeGreaterThan(0);
        }
    }
}
