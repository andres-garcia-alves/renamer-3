using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

using NSubstitute;

using Renamer.Engine.Entities;
using Renamer.Engine.NamingPatterns;
using Renamer.Engine.PhysicalRenamer;

namespace Renamer.Engine.UnitTest.NamingPatterns
{
    [TestClass]
    public class PositionalReplaceNamingTests
    {
        private readonly string basePath = @"C:\SomeDir\AnotherDir\";

        [TestMethod]
        public async Task Execute_WithFileExtension()
        {
            var currentName = basePath + "abc def.ghi";
            var expectedName = basePath + "abc def.gZi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.PositionalReplace("10", "Z", true);

            // act
            var naming = new PositionalReplaceNaming(renamer, renameSettings);
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
            var expectedName = basePath + "abZ def.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            renamer.Rename(default, default, default).ReturnsForAnyArgs(Task.FromResult<bool>(true));
            var renameSettings = RenameSettingsFactory.PositionalReplace("3", "Z", false);

            // act
            var naming = new PositionalReplaceNaming(renamer, renameSettings);
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
            var expectedName = basePath + "abc def.gZi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.PositionalReplace("10", "Z", true);

            // act
            var naming = new PositionalReplaceNaming(renamer, renameSettings);
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
            var expectedName = basePath + "abZ def.ghi";

            // arrange
            var renamer = Substitute.For<IRenamer>();
            var renameSettings = RenameSettingsFactory.PositionalReplace("3", "Z", false);

            // act
            var naming = new PositionalReplaceNaming(renamer, renameSettings);
            var namingResult = naming.Preview(ObjectType.File, currentName);

            // assert
            Assert.IsFalse(namingResult.Success);
            Assert.AreEqual(ObjectType.File, namingResult.ObjectType);
            Assert.AreEqual(currentName, namingResult.OldName);
            Assert.AreEqual(expectedName, namingResult.NewName);
        }
    }
}
