using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using NSubstitute;

using Renamer.Engine.Entities;
using Renamer.Engine.NamingPatterns;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.UnitTest.NamingPatterns
{
    [TestClass]
    public class ByPatternNamingTests
    {
        private readonly string basePath = @"C:\SomeDir\AnotherDir\";

        [TestMethod]
        public async Task Execute_WithFileExtension()
        {
            var currentName = basePath + "abc def.ghi";
            var expectedName = basePath + "Photo 0001.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.ByPattern("Photo ", "1", "1", "4", true);

            // act
            var naming = new ByPatternNaming(renamer, renameSettings);
            var namingResult = await naming.Execute(ObjectType.File, currentName);

            // assert
            Assert.IsTrue(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public async Task Execute_WithoutFileExtension()
        {
            var currentName = basePath + "abc def.ghi";
            var expectedName = basePath + "Photo 0002.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.ByPattern("Photo ", "1", "1", "4", false);

            // act
            var naming = new ByPatternNaming(renamer, renameSettings);
            var namingResult = await naming.Execute(ObjectType.File, currentName);

            // assert
            Assert.IsTrue(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public void Preview_WithFileExtension()
        {
            var currentName = basePath + "abc def.ghi";
            var expectedName = basePath + "Photo 0003.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.ByPattern("Photo ", "1", "1", "4", true);

            // act
            var naming = new ByPatternNaming(renamer, renameSettings);
            var namingResult = naming.Preview(ObjectType.File, currentName);

            // assert
            Assert.IsFalse(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }

        [TestMethod]
        public void Preview_WithoutFileExtension()
        {
            var currentName = basePath + "abc def.ghi";
            var expectedName = basePath + "Photo 0004.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.ByPattern("Photo ", "1", "1", "4", false);

            // act
            var naming = new ByPatternNaming(renamer, renameSettings);
            var namingResult = naming.Preview(ObjectType.File, currentName);

            // assert
            Assert.IsFalse(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }
    }
}
